namespace Proyecto_Final_Programacion_II
{
    partial class MenuPrincipal
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
            verproductos = new Button();
            versuplidores = new Button();
            verclientes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Leelawadee UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(41, 46);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 11;
            label1.Text = "MENU PRINCIPAL";
            // 
            // verproductos
            // 
            verproductos.BackColor = Color.Transparent;
            verproductos.FlatStyle = FlatStyle.Flat;
            verproductos.ForeColor = Color.Transparent;
            verproductos.Location = new Point(68, 171);
            verproductos.Name = "verproductos";
            verproductos.Size = new Size(75, 23);
            verproductos.TabIndex = 8;
            verproductos.Text = "Productos";
            verproductos.UseVisualStyleBackColor = false;
            verproductos.Click += verproductos_Click;
            // 
            // versuplidores
            // 
            versuplidores.BackColor = Color.Transparent;
            versuplidores.FlatStyle = FlatStyle.Flat;
            versuplidores.ForeColor = Color.Transparent;
            versuplidores.Location = new Point(68, 127);
            versuplidores.Name = "versuplidores";
            versuplidores.Size = new Size(75, 23);
            versuplidores.TabIndex = 9;
            versuplidores.Text = "Suplidores";
            versuplidores.UseVisualStyleBackColor = false;
            versuplidores.Click += versuplidores_Click;
            // 
            // verclientes
            // 
            verclientes.BackColor = Color.Transparent;
            verclientes.FlatStyle = FlatStyle.Flat;
            verclientes.ForeColor = Color.Transparent;
            verclientes.Location = new Point(68, 88);
            verclientes.Name = "verclientes";
            verclientes.Size = new Size(75, 23);
            verclientes.TabIndex = 10;
            verclientes.Text = "Clientes";
            verclientes.UseVisualStyleBackColor = false;
            verclientes.Click += verclientes_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_degradado_lineas_dinamicas_23_2149005728;
            ClientSize = new Size(201, 249);
            Controls.Add(label1);
            Controls.Add(verproductos);
            Controls.Add(versuplidores);
            Controls.Add(verclientes);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button verproductos;
        private Button versuplidores;
        private Button verclientes;
    }
}