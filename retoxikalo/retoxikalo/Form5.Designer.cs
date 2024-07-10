namespace retoxikalo
{
    partial class SugoForm
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
            this.rchTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTextBox
            // 
            this.rchTextBox.Location = new System.Drawing.Point(12, 12);
            this.rchTextBox.Name = "rchTextBox";
            this.rchTextBox.Size = new System.Drawing.Size(424, 305);
            this.rchTextBox.TabIndex = 0;
            this.rchTextBox.Text = "";
            // 
            // SugoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 329);
            this.Controls.Add(this.rchTextBox);
            this.Name = "SugoForm";
            this.Text = "Súgó";
            this.Load += new System.EventHandler(this.SugoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTextBox;
    }
}