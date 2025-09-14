namespace Ejercicio4
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
            tbPalabra = new TextBox();
            btnBuscar = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            lbCantidad = new Label();
            SuspendLayout();
            // 
            // tbPalabra
            // 
            tbPalabra.Location = new Point(12, 12);
            tbPalabra.Name = "tbPalabra";
            tbPalabra.Size = new Size(505, 23);
            tbPalabra.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(544, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(505, 313);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 383);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 4;
            label1.Text = "Cantidad de coincidencias";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(219, 407);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(76, 24);
            lbCantidad.TabIndex = 5;
            lbCantidad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(lbCantidad);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnBuscar);
            Controls.Add(tbPalabra);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio4";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPalabra;
        private Button btnBuscar;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label lbCantidad;
    }
}
