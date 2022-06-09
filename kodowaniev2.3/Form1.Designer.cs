namespace kodowaniev2._3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadFile = new System.Windows.Forms.Button();
            this.codeType = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(77, 25);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(212, 73);
            this.loadFile.TabIndex = 0;
            this.loadFile.Text = "Wczytaj plik";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // codeType
            // 
            this.codeType.Location = new System.Drawing.Point(76, 141);
            this.codeType.Name = "codeType";
            this.codeType.Size = new System.Drawing.Size(212, 20);
            this.codeType.TabIndex = 1;
            this.codeType.Text = "Kodowanie";
            this.codeType.TextChanged += new System.EventHandler(this.codeType_TextChanged);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(77, 200);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(212, 69);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "Zapisz plik";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 462);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.codeType);
            this.Controls.Add(this.loadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.TextBox codeType;
        private System.Windows.Forms.Button saveFile;
    }
}

