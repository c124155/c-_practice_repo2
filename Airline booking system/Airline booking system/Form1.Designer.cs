namespace Airline_booking_system
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
            this.txttickets = new System.Windows.Forms.TextBox();
            this.lblbaggage = new System.Windows.Forms.Label();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.lbltickets = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbussiness = new System.Windows.Forms.RadioButton();
            this.rdnormal = new System.Windows.Forms.RadioButton();
            this.rdfirst = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbinsurance = new System.Windows.Forms.CheckBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttickets
            // 
            this.txttickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttickets.Location = new System.Drawing.Point(180, 129);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(183, 22);
            this.txttickets.TabIndex = 151;
            // 
            // lblbaggage
            // 
            this.lblbaggage.AutoSize = true;
            this.lblbaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaggage.Location = new System.Drawing.Point(36, 172);
            this.lblbaggage.Name = "lblbaggage";
            this.lblbaggage.Size = new System.Drawing.Size(138, 16);
            this.lblbaggage.TabIndex = 150;
            this.lblbaggage.Text = "Baggage Weight(kg) :";
            // 
            // txtbaggage
            // 
            this.txtbaggage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbaggage.Location = new System.Drawing.Point(180, 173);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(183, 22);
            this.txtbaggage.TabIndex = 149;
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltickets.Location = new System.Drawing.Point(36, 128);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(128, 16);
            this.lbltickets.TabIndex = 148;
            this.lbltickets.Text = "Number Of Trickets :";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(180, 40);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 22);
            this.txtname.TabIndex = 147;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(36, 83);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(106, 16);
            this.lblage.TabIndex = 146;
            this.lblage.Text = "Passenger age :";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(180, 84);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(183, 22);
            this.txtage.TabIndex = 145;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(36, 39);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(119, 16);
            this.lblname.TabIndex = 144;
            this.lblname.Text = "Passenger Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbussiness);
            this.groupBox3.Controls.Add(this.rdnormal);
            this.groupBox3.Controls.Add(this.rdfirst);
            this.groupBox3.Location = new System.Drawing.Point(39, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 61);
            this.groupBox3.TabIndex = 154;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // rdbussiness
            // 
            this.rdbussiness.AutoSize = true;
            this.rdbussiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbussiness.Location = new System.Drawing.Point(266, 24);
            this.rdbussiness.Name = "rdbussiness";
            this.rdbussiness.Size = new System.Drawing.Size(124, 20);
            this.rdbussiness.TabIndex = 151;
            this.rdbussiness.TabStop = true;
            this.rdbussiness.Text = "Bussiness Class";
            this.rdbussiness.UseVisualStyleBackColor = true;
            // 
            // rdnormal
            // 
            this.rdnormal.AutoSize = true;
            this.rdnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnormal.Location = new System.Drawing.Point(132, 24);
            this.rdnormal.Name = "rdnormal";
            this.rdnormal.Size = new System.Drawing.Size(106, 20);
            this.rdnormal.TabIndex = 143;
            this.rdnormal.TabStop = true;
            this.rdnormal.Text = "Normal Class";
            this.rdnormal.UseVisualStyleBackColor = true;
            // 
            // rdfirst
            // 
            this.rdfirst.AutoSize = true;
            this.rdfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdfirst.Location = new System.Drawing.Point(19, 24);
            this.rdfirst.Name = "rdfirst";
            this.rdfirst.Size = new System.Drawing.Size(87, 20);
            this.rdfirst.TabIndex = 142;
            this.rdfirst.TabStop = true;
            this.rdfirst.Text = "First Class";
            this.rdfirst.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbinsurance);
            this.groupBox2.Location = new System.Drawing.Point(39, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 54);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            // 
            // cbinsurance
            // 
            this.cbinsurance.AutoSize = true;
            this.cbinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinsurance.Location = new System.Drawing.Point(17, 27);
            this.cbinsurance.Name = "cbinsurance";
            this.cbinsurance.Size = new System.Drawing.Size(244, 20);
            this.cbinsurance.TabIndex = 145;
            this.cbinsurance.Text = "Add Travel Insurance ($25 Per ticket)";
            this.cbinsurance.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnexit.Location = new System.Drawing.Point(239, 370);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(115, 39);
            this.btnexit.TabIndex = 159;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(148, 370);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(72, 39);
            this.btnclear.TabIndex = 158;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.ForeColor = System.Drawing.Color.Black;
            this.btncalculate.Location = new System.Drawing.Point(40, 370);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(72, 39);
            this.btncalculate.TabIndex = 157;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(446, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 342);
            this.listBox1.TabIndex = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 509);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txttickets);
            this.Controls.Add(this.lblbaggage);
            this.Controls.Add(this.txtbaggage);
            this.Controls.Add(this.lbltickets);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.Label lblbaggage;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbussiness;
        private System.Windows.Forms.RadioButton rdnormal;
        private System.Windows.Forms.RadioButton rdfirst;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbinsurance;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ListBox listBox1;
    }
}

