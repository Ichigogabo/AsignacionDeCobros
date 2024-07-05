use PruebaTecnicaNetForemostBD;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gabriel Antonio Allex Obando
-- Create date: 04/07/2024
-- Description:	Asigna los Saldos a los gestores
-- =============================================
CREATE PROCEDURE [Cobros].[AsignacionDeSaldos]
AS
BEGIN

/*
=====================================================
======== Declaraciòn de variables a utilizar ========
=====================================================
*/

DECLARE @CantDatos FLOAT ,@CantGestores FLOAT, @GestorId INT, @CantIteraciones INT, @Iteracion INT = 1;
DECLARE @Tbl_vinculacion TABLE (GestorId INT, SaldoId INT);

/*
===================================================
======== Asignando valores a las variables ========
===================================================
*/

SET @CantDatos = (SELECT count(1) FROM Cobros.Saldo);
SET @CantGestores = (SELECT count(1) FROM Cobros.Gestor);
SET @CantIteraciones = ceiling((@CantDatos/@CantGestores));

/*
=================================================================================================================================
======== Ciclo que se ejecutara dependiendo de la cantidad de registros existentes en las tablas "Saldo", "Gestor" ==============
=================================================================================================================================
*/

WHILE (@Iteracion <= @CantIteraciones)
BEGIN

/*
=====================================================================================
======== Cursor el cual realiza la asignacion de saldos a los gestores ==============
=====================================================================================
*/

	DECLARE CursoDatos CURSOR FOR 

	SELECT Id 
	FROM Cobros.Gestor 

	OPEN CursoDatos 

	FETCH NEXT FROM CursoDatos INTO @GestorId
	WHILE (@@FETCH_STATUS = 0)
	BEGIN

		INSERT INTO @Tbl_vinculacion
		SELECT TOP 1 @GestorId AS GestorId, S.Id AS SaldoId
		FROM	Cobros.Saldo S
		WHERE	not exists (SELECT 1 FROM @Tbl_vinculacion V WHERE S.Id = V.SaldoId)

		FETCH NEXT FROM CursoDatos INTO @GestorId

	END

	CLOSE CursoDatos
	DEALLOCATE CursoDatos

	SET @Iteracion += 1
END

/*
=====================================================================================================================
======== Extraccion de los datos de las tablas una vez realizada la vinculacion de saldos ===========================
=====================================================================================================================
*/

SELECT	ROW_NUMBER() OVER (ORDER BY S.Saldo DESC) AS [Nº]
		,Ltrim(Rtrim(G.Nombres)) AS Nombres
		,Ltrim(Rtrim(G.Apellidos)) AS Apellidos
		,Ltrim(Rtrim(G.CodigoDeIdentidad)) AS [Còdigo de identidad]
		,S.Saldo Saldo
FROM	@Tbl_vinculacion V
		Inner join Cobros.Gestor G ON V.GestorId = G.Id
		Inner join Cobros.Saldo S ON V.SaldoId = S.Id



END
GO
