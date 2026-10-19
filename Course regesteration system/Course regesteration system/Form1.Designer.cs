namespace Course_regesteration_system
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcourses = new System.Windows.Forms.TextBox();
            this.lblcourses = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.txttransport = new System.Windows.Forms.TextBox();
            this.txttransportation = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.tblnameoutput = new System.Windows.Forms.Label();
            this.lbltransportoutput = new System.Windows.Forms.Label();
            this.lbldiscountoutput = new System.Windows.Forms.Label();
            this.tblcoursesoutput = new System.Windows.Forms.Label();
            this.lbltutionoutput = new System.Windows.Forms.Label();
            this.lblstudyoutput = new System.Windows.Forms.Label();
            this.lblfinaloutput = new System.Windows.Forms.Label();
            this.tblidoutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(208, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(207, 26);
            this.txtname.TabIndex = 1;
            // 
            // txtcourses
            // 
            this.txtcourses.Location = new System.Drawing.Point(208, 137);
            this.txtcourses.Name = "txtcourses";
            this.txtcourses.Size = new System.Drawing.Size(207, 26);
            this.txtcourses.TabIndex = 3;
            // 
            // lblcourses
            // 
            this.lblcourses.AutoSize = true;
            this.lblcourses.Location = new System.Drawing.Point(42, 140);
            this.lblcourses.Name = "lblcourses";
            this.lblcourses.Size = new System.Drawing.Size(147, 20);
            this.lblcourses.TabIndex = 2;
            this.lblcourses.Text = "Number of courses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Id:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(208, 82);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(207, 26);
            this.txtid.TabIndex = 3;
            // 
            // txtlevel
            // 
            this.txtlevel.Location = new System.Drawing.Point(208, 191);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(207, 26);
            this.txtlevel.TabIndex = 5;
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Location = new System.Drawing.Point(42, 194);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(89, 20);
            this.lbllevel.TabIndex = 4;
            this.lbllevel.Text = "Study level:";
            // 
            // txttransport
            // 
            this.txttransport.Location = new System.Drawing.Point(208, 248);
            this.txttransport.Name = "txttransport";
            this.txttransport.Size = new System.Drawing.Size(207, 26);
            this.txttransport.TabIndex = 7;
            // 
            // txttransportation
            // 
            this.txttransportation.AutoSize = true;
            this.txttransportation.Location = new System.Drawing.Point(42, 251);
            this.txttransportation.Name = "txttransportation";
            this.txttransportation.Size = new System.Drawing.Size(143, 20);
            this.txttransportation.TabIndex = 6;
            this.txttransportation.Text = "Transportation fee:";
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(46, 312);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(105, 45);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(310, 312);
            this.btnclose.Name = "btnclose";
            this.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclose.Size = new System.Drawing.Size(105, 45);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // tblnameoutput
            // 
            this.tblnameoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblnameoutput.Location = new System.Drawing.Point(456, 35);
            this.tblnameoutput.Name = "tblnameoutput";
            this.tblnameoutput.Size = new System.Drawing.Size(203, 37);
            this.tblnameoutput.TabIndex = 11;
            // 
            // lbltransportoutput
            // 
            this.lbltransportoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbltransportoutput.Location = new System.Drawing.Point(682, 35);
            this.lbltransportoutput.Name = "lbltransportoutput";
            this.lbltransportoutput.Size = new System.Drawing.Size(203, 37);
            this.lbltransportoutput.TabIndex = 12;
            // 
            // lbldiscountoutput
            // 
            this.lbldiscountoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbldiscountoutput.Location = new System.Drawing.Point(682, 105);
            this.lbldiscountoutput.Name = "lbldiscountoutput";
            this.lbldiscountoutput.Size = new System.Drawing.Size(203, 37);
            this.lbldiscountoutput.TabIndex = 14;
            // 
            // tblcoursesoutput
            // 
            this.tblcoursesoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblcoursesoutput.Location = new System.Drawing.Point(456, 180);
            this.tblcoursesoutput.Name = "tblcoursesoutput";
            this.tblcoursesoutput.Size = new System.Drawing.Size(203, 37);
            this.tblcoursesoutput.TabIndex = 13;
            // 
            // lbltutionoutput
            // 
            this.lbltutionoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbltutionoutput.Location = new System.Drawing.Point(682, 180);
            this.lbltutionoutput.Name = "lbltutionoutput";
            this.lbltutionoutput.Size = new System.Drawing.Size(203, 37);
            this.lbltutionoutput.TabIndex = 16;
            // 
            // lblstudyoutput
            // 
            this.lblstudyoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblstudyoutput.Location = new System.Drawing.Point(456, 255);
            this.lblstudyoutput.Name = "lblstudyoutput";
            this.lblstudyoutput.Size = new System.Drawing.Size(203, 37);
            this.lblstudyoutput.TabIndex = 15;
            // 
            // lblfinaloutput
            // 
            this.lblfinaloutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblfinaloutput.Location = new System.Drawing.Point(682, 255);
            this.lblfinaloutput.Name = "lblfinaloutput";
            this.lblfinaloutput.Size = new System.Drawing.Size(203, 37);
            this.lblfinaloutput.TabIndex = 18;
            // 
            // tblidoutput
            // 
            this.tblidoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblidoutput.Location = new System.Drawing.Point(456, 105);
            this.tblidoutput.Name = "tblidoutput";
            this.tblidoutput.Size = new System.Drawing.Size(203, 37);
            this.tblidoutput.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 390);
            this.Controls.Add(this.lblfinaloutput);
            this.Controls.Add(this.tblidoutput);
            this.Controls.Add(this.lbltutionoutput);
            this.Controls.Add(this.lblstudyoutput);
            this.Controls.Add(this.lbldiscountoutput);
            this.Controls.Add(this.tblcoursesoutput);
            this.Controls.Add(this.lbltransportoutput);
            this.Controls.Add(this.tblnameoutput);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txttransport);
            this.Controls.Add(this.txttransportation);
            this.Controls.Add(this.txtlevel);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcourses);
            this.Controls.Add(this.lblcourses);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcourses;
        private System.Windows.Forms.Label lblcourses;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttransport;
        private System.Windows.Forms.Label txttransportation;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblfinaloutput;
        private System.Windows.Forms.Label tblidoutput;
        private System.Windows.Forms.Label lbltutionoutput;
        private System.Windows.Forms.Label lblstudyoutput;
        private System.Windows.Forms.Label lbldiscountoutput;
        private System.Windows.Forms.Label tblcoursesoutput;
        private System.Windows.Forms.Label lbltransportoutput;
        private System.Windows.Forms.Label tblnameoutput;
    }
}

