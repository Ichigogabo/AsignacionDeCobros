/*
===================================================================================
============== Creacion  y uso de la Base de Datos y Esquema ======================
===================================================================================
*/

CREATE DATABASE PruebaTecnicaNetForemostBD;

USE PruebaTecnicaNetForemostBD;

CREATE SCHEMA Cobros;

/*
====================================================================
================ Creacion de las tablas a utilizar =================
====================================================================
*/

CREATE TABLE Cobros.Gestor 
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Nombres varchar(100),
	Apellidos varchar(100),
	CodigoDeIdentidad varchar(14)

	constraint Ctr_Codigo Unique (CodigoDeIdentidad)
);

CREATE TABLE Cobros.Saldo 
(
	Id INT PRIMARY KEY IDENTITY (1,1),
	Saldo INT
);


/*
====================================================================
=================== Insertando Datos de Pruebas ====================
====================================================================
*/

insert into Cobros.Gestor values
('Oliver Ruben','Obando Traña','0012811030025J'),
('Jerald David','Larios Cruz','0413105820002U'),
('Maria Jose','Cortez Tellez','0012808640059W'),
('Maria Margarita','Flores Velazques','0013010840042M'),
('Ervin Bismark','Hernandes Rios','4012202630004W'),
('Meydell Josue','Lezama Marenco','0011911650001D'),
('Eduardo Ramon','Villalobos','2892305660001S'),
('Josue Misael','Jarquin Cerda','1240510840000B'),
('Alexs Francisco','Aburto Cruz','2810705740019D'),
('Harold Augusto','Gonzalez Villarreyna','4023009670000B');


insert into Cobros.Saldo values
(2277), (3953), (4726), (1414), (627), (1784), (1634), (3958), (2156), (1347), (2166), (820), 
(2325), (3613), (2389),(4130), (2007), (3027), (2591), (3940), (3888), (2975), (4470), (2291), 
(3393), (3588), (3286), (2293), (4353),(3315), (4900), (794), (4424), (4505), (2643), (2217), 
(4193), (2893), (4120), (3352), (2355), (3219), (3064), (4893),(272), (1299), (4725), (1900), 
(4927), (4011);