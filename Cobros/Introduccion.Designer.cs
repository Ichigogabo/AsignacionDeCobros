namespace Cobros
{
    partial class Introduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDatos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(125, 22);
            label1.Name = "label1";
            label1.Size = new Size(555, 37);
            label1.TabIndex = 0;
            label1.Text = "Prueba Tecnica Gabriel Antonio Allex Obando";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(326, 81);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 1;
            label2.Text = "Instrucciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 135);
            label3.Name = "label3";
            label3.Size = new Size(657, 21);
            label3.TabIndex = 2;
            label3.Text = "1) Ejecutar en SQL Server los Script unicados en la carpeta \"SQL\" en el proyecto \"Cobros.DAL\"";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 176);
            label4.Name = "label4";
            label4.Size = new Size(258, 21);
            label4.TabIndex = 3;
            label4.Text = "1.1 Ejecutar el Scrip \"Base de Datos\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 217);
            label5.Name = "label5";
            label5.Size = new Size(327, 21);
            label5.TabIndex = 4;
            label5.Text = "1.2 Ejecutar el Scrip \"SP_AsignacionDeSaldos\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 266);
            label6.Name = "label6";
            label6.Size = new Size(257, 21);
            label6.TabIndex = 5;
            label6.Text = "2) Dar dlic al boton \"Mostrar Datos\"";
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(317, 342);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(144, 60);
            btnDatos.TabIndex = 6;
            btnDatos.Text = "Mostrar Datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // Introduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Introduccion";
            Text = "Introduccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDatos;
    }
}