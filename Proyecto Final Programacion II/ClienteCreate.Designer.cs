namespace Proyecto_Final_Programacion_II
{
    partial class ClienteCreate
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
            nombre_text = new TextBox();
            telefono_text = new TextBox();
            direccion_text = new TextBox();
            apellido_text = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(64, 136);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Leelawadee", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(47, 40);
            label2.Name = "label2";
            label2.Size = new Size(267, 29);
            label2.TabIndex = 0;
            label2.Text = "REGISTRO DE CLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(58, 217);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 0;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(64, 175);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 0;
            label4.Text = "Telefono";
            // 
            // nombre_text
            // 
            nombre_text.BorderStyle = BorderStyle.FixedSingle;
            nombre_text.Location = new Point(147, 96);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(127, 23);
            nombre_text.TabIndex = 1;
            // 
            // telefono_text
            // 
            telefono_text.BorderStyle = BorderStyle.FixedSingle;
            telefono_text.Location = new Point(147, 178);
            telefono_text.Name = "telefono_text";
            telefono_text.Size = new Size(127, 23);
            telefono_text.TabIndex = 2;
            // 
            // direccion_text
            // 
            direccion_text.BorderStyle = BorderStyle.FixedSingle;
            direccion_text.Location = new Point(147, 217);
            direccion_text.Name = "direccion_text";
            direccion_text.Size = new Size(127, 23);
            direccion_text.TabIndex = 2;
            // 
            // apellido_text
            // 
            apellido_text.BorderStyle = BorderStyle.FixedSingle;
            apellido_text.Location = new Point(147, 134);
            apellido_text.Name = "apellido_text";
            apellido_text.Size = new Size(127, 23);
            apellido_text.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(66, 93);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 0;
            label5.Text = "Nombre ";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(173, 266);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 3;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ClienteCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_degradado_lineas_dinamicas_23_2149005728;
            ClientSize = new Size(364, 326);
            Controls.Add(button1);
            Controls.Add(direccion_text);
            Controls.Add(apellido_text);
            Controls.Add(telefono_text);
            Controls.Add(nombre_text);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.Transparent;
            Name = "ClienteCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClienteCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombre_text;
        private TextBox telefono_text;
        private TextBox direccion_text;
        private TextBox apellido_text;
        private Label label5;
        private Button button1;
    }
}