namespace First_Apps
{
    partial class FullName2
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
            this.exit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(613, 64);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(159, 45);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(435, 64);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(154, 45);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(254, 64);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(154, 45);
            this.show.TabIndex = 2;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // FullName2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.exit);
            this.Name = "FullName2";
            this.Text = "FullName2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FullName2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button show;
    }
}