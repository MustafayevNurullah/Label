namespace WindowsFormsApp5
{
    partial class Form1
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
            this.QacanLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QacanLabel
            // 
            this.QacanLabel.AutoSize = true;
            this.QacanLabel.Location = new System.Drawing.Point(110, 93);
            this.QacanLabel.Name = "QacanLabel";
            this.QacanLabel.Size = new System.Drawing.Size(65, 13);
            this.QacanLabel.TabIndex = 0;
            this.QacanLabel.Text = "QacanLabel";
            this.QacanLabel.MouseHover += new System.EventHandler(this.QacanLabel_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.QacanLabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QacanLabel;
    }
}

