namespace diakkezelo_b
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstEredmeny = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.lblDiak = new System.Windows.Forms.Label();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstEredmeny
            // 
            this.lstEredmeny.FormattingEnabled = true;
            this.lstEredmeny.Location = new System.Drawing.Point(287, 147);
            this.lstEredmeny.Name = "lstEredmeny";
            this.lstEredmeny.Size = new System.Drawing.Size(293, 199);
            this.lstEredmeny.TabIndex = 1;
            this.lstEredmeny.SelectedIndexChanged += new System.EventHandler(this.lstKivalasztottak_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(374, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Születési év";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(103, 351);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 6;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Location = new System.Drawing.Point(293, 373);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(0, 13);
            this.lblDiak.TabIndex = 8;
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(43, 68);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(183, 277);
            this.lstDiakok.TabIndex = 9;
            // 
            // pnlEvek
            // 
            this.pnlEvek.AutoScroll = true;
            this.pnlEvek.BackColor = System.Drawing.Color.Bisque;
            this.pnlEvek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvek.Location = new System.Drawing.Point(287, 68);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(293, 54);
            this.pnlEvek.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "A keresés eredménye:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(601, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEredmeny);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstEredmeny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Label lblDiak;
        private System.Windows.Forms.ListBox lstDiakok;
        private System.Windows.Forms.Panel pnlEvek;
        private System.Windows.Forms.Label label3;
    }
}

