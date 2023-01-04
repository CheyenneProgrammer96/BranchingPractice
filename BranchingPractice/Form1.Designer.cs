namespace BranchingPractice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDisplayGreeting = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDisplayGreeting
            // 
            this.BtnDisplayGreeting.Location = new System.Drawing.Point(136, 275);
            this.BtnDisplayGreeting.Name = "BtnDisplayGreeting";
            this.BtnDisplayGreeting.Size = new System.Drawing.Size(168, 126);
            this.BtnDisplayGreeting.TabIndex = 0;
            this.BtnDisplayGreeting.Text = "Display Greeting";
            this.BtnDisplayGreeting.UseVisualStyleBackColor = true;
            this.BtnDisplayGreeting.Click += new System.EventHandler(this.BtnDisplayGreeting_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 39);
            this.txtName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 535);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BtnDisplayGreeting);
            this.Name = "Form1";
            this.Text = "Branching Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnDisplayGreeting;
        private TextBox txtName;
    }
}