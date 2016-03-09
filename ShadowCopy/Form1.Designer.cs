namespace ShadowCopy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_SourcePath = new System.Windows.Forms.TextBox();
            this.btn_SelectSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SelectTarget = new System.Windows.Forms.Button();
            this.txt_TargetPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_FileExtensions = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SourcePath
            // 
            this.txt_SourcePath.Location = new System.Drawing.Point(12, 34);
            this.txt_SourcePath.Name = "txt_SourcePath";
            this.txt_SourcePath.Size = new System.Drawing.Size(476, 20);
            this.txt_SourcePath.TabIndex = 0;
            this.txt_SourcePath.TextChanged += new System.EventHandler(this.txt_SourcePath_TextChanged);
            // 
            // btn_SelectSource
            // 
            this.btn_SelectSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F, System.Drawing.FontStyle.Bold);
            this.btn_SelectSource.Location = new System.Drawing.Point(494, 33);
            this.btn_SelectSource.Name = "btn_SelectSource";
            this.btn_SelectSource.Size = new System.Drawing.Size(29, 22);
            this.btn_SelectSource.TabIndex = 1;
            this.btn_SelectSource.Text = "...";
            this.btn_SelectSource.UseVisualStyleBackColor = true;
            this.btn_SelectSource.Click += new System.EventHandler(this.btn_SelectSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quell-Pfad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ziel-Pfad";
            // 
            // btn_SelectTarget
            // 
            this.btn_SelectTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.15F, System.Drawing.FontStyle.Bold);
            this.btn_SelectTarget.Location = new System.Drawing.Point(494, 79);
            this.btn_SelectTarget.Name = "btn_SelectTarget";
            this.btn_SelectTarget.Size = new System.Drawing.Size(29, 22);
            this.btn_SelectTarget.TabIndex = 4;
            this.btn_SelectTarget.Text = "...";
            this.btn_SelectTarget.UseVisualStyleBackColor = true;
            this.btn_SelectTarget.Click += new System.EventHandler(this.btn_SelectTarget_Click);
            // 
            // txt_TargetPath
            // 
            this.txt_TargetPath.Location = new System.Drawing.Point(12, 80);
            this.txt_TargetPath.Name = "txt_TargetPath";
            this.txt_TargetPath.Size = new System.Drawing.Size(476, 20);
            this.txt_TargetPath.TabIndex = 3;
            this.txt_TargetPath.TextChanged += new System.EventHandler(this.txt_TargetPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dateitypen";
            // 
            // txt_FileExtensions
            // 
            this.txt_FileExtensions.Location = new System.Drawing.Point(14, 136);
            this.txt_FileExtensions.Name = "txt_FileExtensions";
            this.txt_FileExtensions.Size = new System.Drawing.Size(476, 20);
            this.txt_FileExtensions.TabIndex = 6;
            this.txt_FileExtensions.Text = "pdf txt";
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(16, 174);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 8;
            this.btn_Copy.Text = "Kopieren";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 209);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_FileExtensions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SelectTarget);
            this.Controls.Add(this.txt_TargetPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SelectSource);
            this.Controls.Add(this.txt_SourcePath);
            this.Name = "Form1";
            this.Text = "ShadowCopy v0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SourcePath;
        private System.Windows.Forms.Button btn_SelectSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SelectTarget;
        private System.Windows.Forms.TextBox txt_TargetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_FileExtensions;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_Copy;
    }
}

