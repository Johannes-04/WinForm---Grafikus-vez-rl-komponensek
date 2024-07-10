namespace retoxikalo
{
    partial class ItalLapForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlValasztek = new System.Windows.Forms.Panel();
            this.btnRenel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szamlatKerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fizetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Árlista";
            // 
            // pnlValasztek
            // 
            this.pnlValasztek.AutoScroll = true;
            this.pnlValasztek.Location = new System.Drawing.Point(51, 55);
            this.pnlValasztek.Name = "pnlValasztek";
            this.pnlValasztek.Size = new System.Drawing.Size(330, 374);
            this.pnlValasztek.TabIndex = 1;
            // 
            // btnRenel
            // 
            this.btnRenel.ContextMenuStrip = this.contextMenuStrip1;
            this.btnRenel.Location = new System.Drawing.Point(170, 435);
            this.btnRenel.Name = "btnRenel";
            this.btnRenel.Size = new System.Drawing.Size(75, 23);
            this.btnRenel.TabIndex = 2;
            this.btnRenel.Text = "Rendel";
            this.btnRenel.UseVisualStyleBackColor = true;
            this.btnRenel.Click += new System.EventHandler(this.btnRenel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szamlatKerMenuItem,
            this.fizetMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // szamlatKerMenuItem
            // 
            this.szamlatKerMenuItem.Name = "szamlatKerMenuItem";
            this.szamlatKerMenuItem.Size = new System.Drawing.Size(134, 22);
            this.szamlatKerMenuItem.Text = "Számlát kér";
            this.szamlatKerMenuItem.Click += new System.EventHandler(this.szamlatKerMenuItem_Click);
            // 
            // fizetMenuItem
            // 
            this.fizetMenuItem.Name = "fizetMenuItem";
            this.fizetMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fizetMenuItem.Text = "Fizet";
            this.fizetMenuItem.Click += new System.EventHandler(this.fizetMenuItem_Click);
            // 
            // ItalLapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 514);
            this.Controls.Add(this.btnRenel);
            this.Controls.Add(this.pnlValasztek);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "ItalLapForm";
            this.Text = "ItalLap";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlValasztek;
        private System.Windows.Forms.Button btnRenel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szamlatKerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fizetMenuItem;
    }
}