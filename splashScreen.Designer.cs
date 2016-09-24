namespace COMP1004_F2016_Lab2
{
    partial class splashScreen
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
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to splash screen";
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 3000;
            this.splashScreenTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.label1);
            this.Name = "splashScreen";
            this.Text = "splashScreen";
            this.Load += new System.EventHandler(this.splashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer splashScreenTimer;
    }
}