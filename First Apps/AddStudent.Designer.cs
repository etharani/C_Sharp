namespace First_Apps
{
    partial class AddStudent
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
            this.la1 = new System.Windows.Forms.Label();
            this.la2 = new System.Windows.Forms.Label();
            this.la3 = new System.Windows.Forms.Label();
            this.la4 = new System.Windows.Forms.Label();
            this.la5 = new System.Windows.Forms.Label();
            this.la6 = new System.Windows.Forms.Label();
            this.texid = new System.Windows.Forms.TextBox();
            this.texfname = new System.Windows.Forms.TextBox();
            this.texlname = new System.Windows.Forms.TextBox();
            this.texmark1 = new System.Windows.Forms.TextBox();
            this.texmark2 = new System.Windows.Forms.TextBox();
            this.texmark3 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.Location = new System.Drawing.Point(31, 25);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(20, 16);
            this.la1.TabIndex = 0;
            this.la1.Text = "ID";
            // 
            // la2
            // 
            this.la2.AutoSize = true;
            this.la2.Location = new System.Drawing.Point(31, 77);
            this.la2.Name = "la2";
            this.la2.Size = new System.Drawing.Size(72, 16);
            this.la2.TabIndex = 1;
            this.la2.Text = "First Name";
            // 
            // la3
            // 
            this.la3.AutoSize = true;
            this.la3.Location = new System.Drawing.Point(31, 126);
            this.la3.Name = "la3";
            this.la3.Size = new System.Drawing.Size(72, 16);
            this.la3.TabIndex = 2;
            this.la3.Text = "Last Name";
            // 
            // la4
            // 
            this.la4.AutoSize = true;
            this.la4.Location = new System.Drawing.Point(31, 171);
            this.la4.Name = "la4";
            this.la4.Size = new System.Drawing.Size(48, 16);
            this.la4.TabIndex = 3;
            this.la4.Text = "Mark-1";
            // 
            // la5
            // 
            this.la5.AutoSize = true;
            this.la5.Location = new System.Drawing.Point(31, 217);
            this.la5.Name = "la5";
            this.la5.Size = new System.Drawing.Size(48, 16);
            this.la5.TabIndex = 4;
            this.la5.Text = "Mark-2";
            // 
            // la6
            // 
            this.la6.AutoSize = true;
            this.la6.Location = new System.Drawing.Point(31, 267);
            this.la6.Name = "la6";
            this.la6.Size = new System.Drawing.Size(48, 16);
            this.la6.TabIndex = 5;
            this.la6.Text = "Mark-3";
            // 
            // texid
            // 
            this.texid.Location = new System.Drawing.Point(153, 19);
            this.texid.Name = "texid";
            this.texid.Size = new System.Drawing.Size(271, 22);
            this.texid.TabIndex = 6;
            // 
            // texfname
            // 
            this.texfname.Location = new System.Drawing.Point(153, 71);
            this.texfname.Name = "texfname";
            this.texfname.Size = new System.Drawing.Size(271, 22);
            this.texfname.TabIndex = 7;
            // 
            // texlname
            // 
            this.texlname.Location = new System.Drawing.Point(153, 120);
            this.texlname.Name = "texlname";
            this.texlname.Size = new System.Drawing.Size(271, 22);
            this.texlname.TabIndex = 8;
            // 
            // texmark1
            // 
            this.texmark1.Location = new System.Drawing.Point(153, 165);
            this.texmark1.Name = "texmark1";
            this.texmark1.Size = new System.Drawing.Size(271, 22);
            this.texmark1.TabIndex = 9;
            // 
            // texmark2
            // 
            this.texmark2.Location = new System.Drawing.Point(153, 211);
            this.texmark2.Name = "texmark2";
            this.texmark2.Size = new System.Drawing.Size(271, 22);
            this.texmark2.TabIndex = 10;
            // 
            // texmark3
            // 
            this.texmark3.Location = new System.Drawing.Point(153, 261);
            this.texmark3.Name = "texmark3";
            this.texmark3.Size = new System.Drawing.Size(271, 22);
            this.texmark3.TabIndex = 11;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(34, 306);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(99, 31);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "Get Student";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(167, 306);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(92, 31);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "Calc Total";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(291, 306);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(133, 31);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "Calc Average";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 359);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.texmark3);
            this.Controls.Add(this.texmark2);
            this.Controls.Add(this.texmark1);
            this.Controls.Add(this.texlname);
            this.Controls.Add(this.texfname);
            this.Controls.Add(this.texid);
            this.Controls.Add(this.la6);
            this.Controls.Add(this.la5);
            this.Controls.Add(this.la4);
            this.Controls.Add(this.la3);
            this.Controls.Add(this.la2);
            this.Controls.Add(this.la1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Label la2;
        private System.Windows.Forms.Label la3;
        private System.Windows.Forms.Label la4;
        private System.Windows.Forms.Label la5;
        private System.Windows.Forms.Label la6;
        private System.Windows.Forms.TextBox texid;
        private System.Windows.Forms.TextBox texfname;
        private System.Windows.Forms.TextBox texlname;
        private System.Windows.Forms.TextBox texmark1;
        private System.Windows.Forms.TextBox texmark2;
        private System.Windows.Forms.TextBox texmark3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}