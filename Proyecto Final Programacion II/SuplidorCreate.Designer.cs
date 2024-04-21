namespace Proyecto_Final_Programacion_II
{
    partial class SuplidorCreate
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
            guardar_btn = new Button();
            telefono_text = new TextBox();
            direccion_text = new TextBox();
            nombre_text = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // guardar_btn
            // 
            guardar_btn.BackColor = Color.Transparent;
            guardar_btn.FlatStyle = FlatStyle.Flat;
            guardar_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardar_btn.ForeColor = Color.Transparent;
            guardar_btn.Location = new Point(165, 226);
            guardar_btn.Name = "guardar_btn";
            guardar_btn.Size = new Size(75, 34);
            guardar_btn.TabIndex = 23;
            guardar_btn.Text = "Guardar";
            guardar_btn.UseVisualStyleBackColor = false;
            guardar_btn.Click += guardar_btn_Click;
            // 
            // telefono_text
            // 
            telefono_text.BorderStyle = BorderStyle.FixedSingle;
            telefono_text.Location = new Point(145, 140);
            telefono_text.Name = "telefono_text";
            telefono_text.Size = new Size(127, 23);
            telefono_text.TabIndex = 21;
            // 
            // direccion_text
            // 
            direccion_text.BorderStyle = BorderStyle.FixedSingle;
            direccion_text.Location = new Point(146, 184);
            direccion_text.Name = "direccion_text";
            direccion_text.Size = new Size(127, 23);
            direccion_text.TabIndex = 22;
            // 
            // nombre_text
            // 
            nombre_text.BorderStyle = BorderStyle.FixedSingle;
            nombre_text.Location = new Point(145, 100);
            nombre_text.Name = "nombre_text";
            nombre_text.Size = new Size(127, 23);
            nombre_text.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(57, 98);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 14;
            label5.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Leelawadee", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(38, 37);
            label2.Name = "label2";
            label2.Size = new Size(290, 29);
            label2.TabIndex = 15;
            label2.Text = "REGISTRO DE SUPLIDOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(57, 184);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 16;
            label4.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(57, 142);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 18;
            label1.Text = "Telefono";
            // 
            // SuplidorCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_degradado_lineas_dinamicas_23_2149005728;
            ClientSize = new Size(356, 301);
            Controls.Add(guardar_btn);
            Controls.Add(telefono_text);
            Controls.Add(direccion_text);
            Controls.Add(nombre_text);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "SuplidorCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuplidorCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardar_btn;
        private TextBox telefono_text;
        private TextBox direccion_text;
        private TextBox nombre_text;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label1;
    }
}