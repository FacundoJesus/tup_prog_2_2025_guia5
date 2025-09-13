namespace Ejercicio1
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
            btnChar = new Button();
            btnRegex = new Button();
            lsbChar = new ListBox();
            lsbRegex = new ListBox();
            SuspendLayout();
            // 
            // btnChar
            // 
            btnChar.Location = new Point(12, 12);
            btnChar.Name = "btnChar";
            btnChar.Size = new Size(383, 57);
            btnChar.TabIndex = 0;
            btnChar.Text = "Probar ejemplos Char";
            btnChar.UseVisualStyleBackColor = true;
            btnChar.Click += btnChar_Click;
            // 
            // btnRegex
            // 
            btnRegex.Location = new Point(401, 12);
            btnRegex.Name = "btnRegex";
            btnRegex.Size = new Size(386, 57);
            btnRegex.TabIndex = 1;
            btnRegex.Text = "Probar ejemplos Regex";
            btnRegex.UseVisualStyleBackColor = true;
            btnRegex.Click += btnRegex_Click;
            // 
            // lsbChar
            // 
            lsbChar.FormattingEnabled = true;
            lsbChar.ItemHeight = 15;
            lsbChar.Location = new Point(12, 75);
            lsbChar.Name = "lsbChar";
            lsbChar.Size = new Size(383, 454);
            lsbChar.TabIndex = 2;
            // 
            // lsbRegex
            // 
            lsbRegex.FormattingEnabled = true;
            lsbRegex.ItemHeight = 15;
            lsbRegex.Location = new Point(404, 75);
            lsbRegex.Name = "lsbRegex";
            lsbRegex.Size = new Size(383, 454);
            lsbRegex.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 548);
            Controls.Add(lsbRegex);
            Controls.Add(lsbChar);
            Controls.Add(btnRegex);
            Controls.Add(btnChar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnChar;
        private Button btnRegex;
        private ListBox lsbChar;
        private ListBox lsbRegex;
    }
}
