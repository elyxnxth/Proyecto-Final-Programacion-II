namespace Proyecto_Final_Programacion_II
{
    partial class ProductoCreate
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
            button1 = new Button();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            descripcion_text = new TextBox();
            costo_text = new TextBox();
            precio_text = new TextBox();
            existencia_text = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(174, 255);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 13;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(43, 75);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 4;
            label5.Text = "Descripcion ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Leelawadee", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(23, 26);
            label2.Name = "label2";
            label2.Size = new Size(304, 29);
            label2.TabIndex = 5;
            label2.Text = "REGISTRO DE PRODUCTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(43, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(43, 208);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 7;
            label3.Text = "Existencia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(43, 119);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 8;
            label1.Text = "Costo";
            // 
            // descripcion_text
            // 
            descripcion_text.BorderStyle = BorderStyle.FixedSingle;
            descripcion_text.Location = new Point(153, 73);
            descripcion_text.Name = "descripcion_text";
            descripcion_text.Size = new Size(127, 23);
            descripcion_text.TabIndex = 9;
            // 
            // costo_text
            // 
            costo_text.BorderStyle = BorderStyle.FixedSingle;
            costo_text.Location = new Point(153, 117);
            costo_text.Name = "costo_text";
            costo_text.Size = new Size(127, 23);
            costo_text.TabIndex = 14;
            // 
            // precio_text
            // 
            precio_text.BorderStyle = BorderStyle.FixedSingle;
            precio_text.Location = new Point(153, 163);
            precio_text.Name = "precio_text";
            precio_text.Size = new Size(127, 23);
            precio_text.TabIndex = 15;
            // 
            // existencia_text
            // 
            existencia_text.BorderStyle = BorderStyle.FixedSingle;
            existencia_text.Location = new Point(153, 211);
            existencia_text.Name = "existencia_text";
            existencia_text.Size = new Size(127, 23);
            existencia_text.TabIndex = 15;
            // 
            // ProductoCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_degradado_lineas_dinamicas_23_2149005728;
            ClientSize = new Size(349, 314);
            Controls.Add(existencia_text);
            Controls.Add(precio_text);
            Controls.Add(costo_text);
            Controls.Add(button1);
            Controls.Add(descripcion_text);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ProductoCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductoCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox descripcion_text;
        private TextBox costo_text;
        private TextBox precio_text;
        private TextBox existencia_text;
    }
}