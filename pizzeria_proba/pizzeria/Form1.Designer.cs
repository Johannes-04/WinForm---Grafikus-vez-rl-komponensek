namespace pizzeria_proba
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
            this.lblKicsi = new System.Windows.Forms.Label();
            this.lblNagy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDb1 = new System.Windows.Forms.TextBox();
            this.txtDb2 = new System.Windows.Forms.TextBox();
            this.txtFizetendo = new System.Windows.Forms.TextBox();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.rdBtn1Kicsi = new System.Windows.Forms.RadioButton();
            this.rdBtn1Nagy = new System.Windows.Forms.RadioButton();
            this.rdBtn2Kicsi = new System.Windows.Forms.RadioButton();
            this.rdBtn2Nagy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKicsi
            // 
            this.lblKicsi.AutoSize = true;
            this.lblKicsi.Location = new System.Drawing.Point(173, 40);
            this.lblKicsi.Name = "lblKicsi";
            this.lblKicsi.Size = new System.Drawing.Size(24, 13);
            this.lblKicsi.TabIndex = 0;
            this.lblKicsi.Text = " cm";
            // 
            // lblNagy
            // 
            this.lblNagy.AutoSize = true;
            this.lblNagy.Location = new System.Drawing.Point(261, 40);
            this.lblNagy.Name = "lblNagy";
            this.lblNagy.Size = new System.Drawing.Size(24, 13);
            this.lblNagy.TabIndex = 1;
            this.lblNagy.Text = " cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(200, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fizezendő:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(43, 166);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "darab";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "darab";
            // 
            // txtDb1
            // 
            this.txtDb1.Location = new System.Drawing.Point(404, 82);
            this.txtDb1.Name = "txtDb1";
            this.txtDb1.Size = new System.Drawing.Size(100, 20);
            this.txtDb1.TabIndex = 7;
            // 
            // txtDb2
            // 
            this.txtDb2.Location = new System.Drawing.Point(404, 164);
            this.txtDb2.Name = "txtDb2";
            this.txtDb2.Size = new System.Drawing.Size(100, 20);
            this.txtDb2.TabIndex = 8;
            // 
            // txtFizetendo
            // 
            this.txtFizetendo.Location = new System.Drawing.Point(297, 254);
            this.txtFizetendo.Name = "txtFizetendo";
            this.txtFizetendo.Size = new System.Drawing.Size(100, 20);
            this.txtFizetendo.TabIndex = 9;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(43, 251);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 10;
            this.btnSzamol.Text = "Szamol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(43, 303);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 11;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(129, 303);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(268, 23);
            this.btnAdatBe.TabIndex = 12;
            this.btnAdatBe.Text = "Adatbevitel";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(404, 303);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 13;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // rdBtn1Kicsi
            // 
            this.rdBtn1Kicsi.AutoSize = true;
            this.rdBtn1Kicsi.Location = new System.Drawing.Point(6, 19);
            this.rdBtn1Kicsi.Name = "rdBtn1Kicsi";
            this.rdBtn1Kicsi.Size = new System.Drawing.Size(37, 17);
            this.rdBtn1Kicsi.TabIndex = 14;
            this.rdBtn1Kicsi.TabStop = true;
            this.rdBtn1Kicsi.Text = " Ft";
            this.rdBtn1Kicsi.UseVisualStyleBackColor = true;
            // 
            // rdBtn1Nagy
            // 
            this.rdBtn1Nagy.AutoSize = true;
            this.rdBtn1Nagy.Location = new System.Drawing.Point(97, 19);
            this.rdBtn1Nagy.Name = "rdBtn1Nagy";
            this.rdBtn1Nagy.Size = new System.Drawing.Size(37, 17);
            this.rdBtn1Nagy.TabIndex = 15;
            this.rdBtn1Nagy.TabStop = true;
            this.rdBtn1Nagy.Text = " Ft";
            this.rdBtn1Nagy.UseVisualStyleBackColor = true;
            // 
            // rdBtn2Kicsi
            // 
            this.rdBtn2Kicsi.AutoSize = true;
            this.rdBtn2Kicsi.Location = new System.Drawing.Point(7, 21);
            this.rdBtn2Kicsi.Name = "rdBtn2Kicsi";
            this.rdBtn2Kicsi.Size = new System.Drawing.Size(37, 17);
            this.rdBtn2Kicsi.TabIndex = 16;
            this.rdBtn2Kicsi.TabStop = true;
            this.rdBtn2Kicsi.Text = " Ft";
            this.rdBtn2Kicsi.UseVisualStyleBackColor = true;
            // 
            // rdBtn2Nagy
            // 
            this.rdBtn2Nagy.AutoSize = true;
            this.rdBtn2Nagy.Location = new System.Drawing.Point(94, 21);
            this.rdBtn2Nagy.Name = "rdBtn2Nagy";
            this.rdBtn2Nagy.Size = new System.Drawing.Size(37, 17);
            this.rdBtn2Nagy.TabIndex = 17;
            this.rdBtn2Nagy.TabStop = true;
            this.rdBtn2Nagy.Text = " Ft";
            this.rdBtn2Nagy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtn1Kicsi);
            this.groupBox1.Controls.Add(this.rdBtn1Nagy);
            this.groupBox1.Location = new System.Drawing.Point(154, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válasszon";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtn2Nagy);
            this.panel1.Controls.Add(this.rdBtn2Kicsi);
            this.panel1.Location = new System.Drawing.Point(154, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 56);
            this.panel1.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.txtFizetendo);
            this.Controls.Add(this.txtDb2);
            this.Controls.Add(this.txtDb1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNagy);
            this.Controls.Add(this.lblKicsi);
            this.Name = "Form1";
            this.Text = "Pizzéria próba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKicsi;
        private System.Windows.Forms.Label lblNagy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDb1;
        private System.Windows.Forms.TextBox txtDb2;
        private System.Windows.Forms.TextBox txtFizetendo;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnAdatBe;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.RadioButton rdBtn1Kicsi;
        private System.Windows.Forms.RadioButton rdBtn1Nagy;
        private System.Windows.Forms.RadioButton rdBtn2Kicsi;
        private System.Windows.Forms.RadioButton rdBtn2Nagy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

