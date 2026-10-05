namespace overtime
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
            this.grosspayble = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hoursworkedtextbox = new System.Windows.Forms.TextBox();
            this.hourlypayratetextbox = new System.Windows.Forms.TextBox();
            this.calculategutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "hours worked:";
            // 
            // grosspayble
            // 
            this.grosspayble.Location = new System.Drawing.Point(424, 247);
            this.grosspayble.Name = "grosspayble";
            this.grosspayble.Size = new System.Drawing.Size(238, 43);
            this.grosspayble.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "houly pay rate:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "gross pay:";
            // 
            // hoursworkedtextbox
            // 
            this.hoursworkedtextbox.Location = new System.Drawing.Point(459, 113);
            this.hoursworkedtextbox.Name = "hoursworkedtextbox";
            this.hoursworkedtextbox.Size = new System.Drawing.Size(203, 26);
            this.hoursworkedtextbox.TabIndex = 4;
            // 
            // hourlypayratetextbox
            // 
            this.hourlypayratetextbox.Location = new System.Drawing.Point(459, 155);
            this.hourlypayratetextbox.Name = "hourlypayratetextbox";
            this.hourlypayratetextbox.Size = new System.Drawing.Size(203, 26);
            this.hourlypayratetextbox.TabIndex = 5;
            // 
            // calculategutton
            // 
            this.calculategutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculategutton.Location = new System.Drawing.Point(170, 375);
            this.calculategutton.Name = "calculategutton";
            this.calculategutton.Size = new System.Drawing.Size(119, 53);
            this.calculategutton.TabIndex = 6;
            this.calculategutton.Text = "galgulate gross pay";
            this.calculategutton.UseVisualStyleBackColor = true;
            this.calculategutton.Click += new System.EventHandler(this.calculategutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(530, 375);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(119, 53);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(341, 375);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(119, 53);
            this.clearbutton.TabIndex = 8;
            this.clearbutton.Text = "clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.calculategutton);
            this.Controls.Add(this.hourlypayratetextbox);
            this.Controls.Add(this.hoursworkedtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grosspayble);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label grosspayble;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hoursworkedtextbox;
        private System.Windows.Forms.TextBox hourlypayratetextbox;
        private System.Windows.Forms.Button calculategutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

