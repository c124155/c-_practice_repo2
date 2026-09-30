namespace ikra
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
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.lbltotalamount = new System.Windows.Forms.TextBox();
            this.lbldiscount = new System.Windows.Forms.TextBox();
            this.lblservestax = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtroomtype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(440, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter guest name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(440, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "total amount";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(444, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "discount(5%)";
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(440, 395);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(155, 48);
            this.label.TabIndex = 3;
            this.label.Text = "service tax(10%)";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(444, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "enter price night";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(440, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "enter number of nights";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(440, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 35);
            this.label7.TabIndex = 6;
            this.label7.Text = "enter room type";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncalculate.Location = new System.Drawing.Point(606, 314);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(226, 55);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "calculate booking";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(732, 136);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(146, 26);
            this.txtguestname.TabIndex = 8;
            this.txtguestname.TextChanged += new System.EventHandler(this.xtguestname_TextChanged);
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.Location = new System.Drawing.Point(704, 500);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(174, 26);
            this.lbltotalamount.TabIndex = 9;
            // 
            // lbldiscount
            // 
            this.lbldiscount.Location = new System.Drawing.Point(704, 447);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(174, 26);
            this.lbldiscount.TabIndex = 10;
            // 
            // lblservestax
            // 
            this.lblservestax.Location = new System.Drawing.Point(704, 395);
            this.lblservestax.Name = "lblservestax";
            this.lblservestax.Size = new System.Drawing.Size(174, 26);
            this.lblservestax.TabIndex = 11;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(732, 260);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(146, 26);
            this.txtprice.TabIndex = 12;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(732, 212);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(146, 26);
            this.txtnights.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(501, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 53);
            this.label8.TabIndex = 15;
            this.label8.Text = "hotel room boking calculator";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtroomtype
            // 
            this.txtroomtype.FormattingEnabled = true;
            this.txtroomtype.Items.AddRange(new object[] {
            "deluxe",
            "standard",
            "suite"});
            this.txtroomtype.Location = new System.Drawing.Point(732, 168);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(146, 28);
            this.txtroomtype.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 575);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblservestax);
            this.Controls.Add(this.lbldiscount);
            this.Controls.Add(this.lbltotalamount);
            this.Controls.Add(this.txtguestname);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox lbltotalamount;
        private System.Windows.Forms.TextBox lbldiscount;
        private System.Windows.Forms.TextBox lblservestax;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtroomtype;
    }
}

