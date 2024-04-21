namespace Proyecto_Final_Programacion_II
{
    partial class SuplidorIndex
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(533, 52);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 7;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(533, 92);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 6;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(533, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 5;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Navy;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Leelawadee", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(201, 18);
            label2.Name = "label2";
            label2.Size = new Size(158, 31);
            label2.TabIndex = 16;
            label2.Text = "SUPLIDORES";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 250);
            dataGridView1.TabIndex = 17;
            // 
            // SuplidorIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_degradado_lineas_dinamicas_23_2149005728;
            ClientSize = new Size(635, 335);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SuplidorIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuplidorIndex";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}