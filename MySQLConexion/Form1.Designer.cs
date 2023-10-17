namespace MySQLConexion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPuerto = new TextBox();
            label3 = new Label();
            txtBD = new TextBox();
            label4 = new Label();
            txtHost = new TextBox();
            label5 = new Label();
            txtContrasena = new TextBox();
            label6 = new Label();
            btnConectar = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(144, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(254, 31);
            txtUsuario.TabIndex = 1;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(144, 175);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(254, 31);
            txtPuerto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 181);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 4;
            label3.Text = "Puerto";
            // 
            // txtBD
            // 
            txtBD.Location = new Point(144, 138);
            txtBD.Name = "txtBD";
            txtBD.Size = new Size(254, 31);
            txtBD.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 144);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 6;
            label4.Text = "Base de Datos";
            // 
            // txtHost
            // 
            txtHost.Location = new Point(144, 101);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(254, 31);
            txtHost.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 107);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 8;
            label5.Text = "Host";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(144, 64);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(254, 31);
            txtContrasena.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 70);
            label6.Name = "label6";
            label6.Size = new Size(101, 25);
            label6.TabIndex = 10;
            label6.Text = "Contraseña";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(214, 229);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(184, 34);
            btnConectar.TabIndex = 12;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(419, 27);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.RowTemplate.Height = 33;
            dgvDatos.Size = new Size(585, 236);
            dgvDatos.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 415);
            Controls.Add(dgvDatos);
            Controls.Add(btnConectar);
            Controls.Add(txtContrasena);
            Controls.Add(label6);
            Controls.Add(txtHost);
            Controls.Add(label5);
            Controls.Add(txtBD);
            Controls.Add(label4);
            Controls.Add(txtPuerto);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPuerto;
        private Label label3;
        private TextBox txtBD;
        private Label label4;
        private TextBox txtHost;
        private Label label5;
        private TextBox txtContrasena;
        private Label label6;
        private Button btnConectar;
        private DataGridView dgvDatos;
    }
}