namespace COMP1004_F2016_Lab2
{
    partial class initialForm
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
            this.LabelText = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Location = new System.Drawing.Point(96, 46);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(0, 13);
            this.LabelText.TabIndex = 0;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Location = new System.Drawing.Point(12, 209);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(75, 23);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Submit";
            this.MessageLabel.UseVisualStyleBackColor = true;
            this.MessageLabel.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(167, 208);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // initialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.LabelText);
            this.Name = "initialForm";
            this.Text = "initialForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.initialForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Button MessageLabel;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
    }
}

