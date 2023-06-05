namespace fianlProject
{
    partial class contactPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(389, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Page";
            // 
            // messageTxt
            // 
            this.messageTxt.Location = new System.Drawing.Point(280, 424);
            this.messageTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(502, 104);
            this.messageTxt.TabIndex = 4;
            this.messageTxt.Text = "Leave a message...";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(279, 204);
            this.nameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(502, 26);
            this.nameText.TabIndex = 5;
            this.nameText.Text = "Your name...";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(279, 312);
            this.emailText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(504, 26);
            this.emailText.TabIndex = 6;
            this.emailText.Text = "Your email...";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.submitBtn.Location = new System.Drawing.Point(280, 616);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(214, 84);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.backBtn.Location = new System.Drawing.Point(568, 616);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(214, 84);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // contactPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 808);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.messageTxt);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "contactPage";
            this.Text = "contactPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
    }
}