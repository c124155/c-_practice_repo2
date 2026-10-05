namespace avrage_displayed
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCLCULTEAR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcul = new System.Windows.Forms.Label();
            this.txtscorestar = new System.Windows.Forms.TextBox();
            this.txtscoreend = new System.Windows.Forms.TextBox();
            this.txtscoretwo = new System.Windows.Forms.TextBox();
            this.btncalculte = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER THREE TEST SCORES";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEST SCORE 1#";
            // 
            // lblCLCULTEAR
            // 
            this.lblCLCULTEAR.Location = new System.Drawing.Point(256, 312);
            this.lblCLCULTEAR.Name = "lblCLCULTEAR";
            this.lblCLCULTEAR.Size = new System.Drawing.Size(311, 57);
            this.lblCLCULTEAR.TabIndex = 2;
            this.lblCLCULTEAR.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "TEST SCORE 3#";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "TEST SCORE 2#";
            // 
            // calcul
            // 
            this.calcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcul.Location = new System.Drawing.Point(129, 312);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(100, 23);
            this.calcul.TabIndex = 5;
            this.calcul.Text = "AVRAGE";
            // 
            // txtscorestar
            // 
            this.txtscorestar.Location = new System.Drawing.Point(396, 147);
            this.txtscorestar.Name = "txtscorestar";
            this.txtscorestar.Size = new System.Drawing.Size(213, 26);
            this.txtscorestar.TabIndex = 6;
            // 
            // txtscoreend
            // 
            this.txtscoreend.Location = new System.Drawing.Point(396, 228);
            this.txtscoreend.Name = "txtscoreend";
            this.txtscoreend.Size = new System.Drawing.Size(213, 26);
            this.txtscoreend.TabIndex = 7;
            // 
            // txtscoretwo
            // 
            this.txtscoretwo.Location = new System.Drawing.Point(396, 182);
            this.txtscoretwo.Name = "txtscoretwo";
            this.txtscoretwo.Size = new System.Drawing.Size(213, 26);
            this.txtscoretwo.TabIndex = 8;
            // 
            // btncalculte
            // 
            this.btncalculte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculte.Location = new System.Drawing.Point(106, 437);
            this.btncalculte.Name = "btncalculte";
            this.btncalculte.Size = new System.Drawing.Size(121, 76);
            this.btncalculte.TabIndex = 9;
            this.btncalculte.Text = "calculate avrage";
            this.btncalculte.UseVisualStyleBackColor = true;
            this.btncalculte.Click += new System.EventHandler(this.btncalculte_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(287, 437);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(134, 36);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(287, 488);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(134, 36);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 551);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculte);
            this.Controls.Add(this.txtscoretwo);
            this.Controls.Add(this.txtscoreend);
            this.Controls.Add(this.txtscorestar);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCLCULTEAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCLCULTEAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label calcul;
        private System.Windows.Forms.TextBox txtscorestar;
        private System.Windows.Forms.TextBox txtscoreend;
        private System.Windows.Forms.TextBox txtscoretwo;
        private System.Windows.Forms.Button btncalculte;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

