namespace Ejercicio3
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
            btnImportarXML = new Button();
            label1 = new Label();
            label2 = new Label();
            tbXml = new TextBox();
            lsbResumen = new ListBox();
            SuspendLayout();
            // 
            // btnImportarXML
            // 
            btnImportarXML.Location = new Point(301, 72);
            btnImportarXML.Name = "btnImportarXML";
            btnImportarXML.Size = new Size(75, 55);
            btnImportarXML.TabIndex = 0;
            btnImportarXML.Text = "Importar XML";
            btnImportarXML.UseVisualStyleBackColor = true;
            btnImportarXML.Click += btnImportarXML_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "XML";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 213);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Resumen";
            // 
            // tbXml
            // 
            tbXml.Location = new Point(12, 36);
            tbXml.Multiline = true;
            tbXml.Name = "tbXml";
            tbXml.Size = new Size(283, 161);
            tbXml.TabIndex = 3;
            // 
            // lsbResumen
            // 
            lsbResumen.FormattingEnabled = true;
            lsbResumen.ItemHeight = 15;
            lsbResumen.Location = new Point(12, 231);
            lsbResumen.Name = "lsbResumen";
            lsbResumen.Size = new Size(283, 124);
            lsbResumen.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 373);
            Controls.Add(lsbResumen);
            Controls.Add(tbXml);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnImportarXML);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImportarXML;
        private Label label1;
        private Label label2;
        private TextBox tbXml;
        private ListBox lsbResumen;
    }
}
