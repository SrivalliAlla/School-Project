namespace fianlProject
{
    partial class createAccount
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(354, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Account";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(238, 202);
            this.nameText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(502, 26);
            this.nameText.TabIndex = 6;
            this.nameText.Text = "Name...";
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(236, 426);
            this.emailText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(504, 26);
            this.emailText.TabIndex = 7;
            this.emailText.Text = "Email...";
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(236, 311);
            this.numberTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(504, 26);
            this.numberTxt.TabIndex = 8;
            this.numberTxt.Text = "Phone number...";
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("SimSun", 15F);
            this.createButton.Location = new System.Drawing.Point(212, 609);
            this.createButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(214, 84);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.backBtn.Location = new System.Drawing.Point(525, 609);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(214, 84);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 837);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "createAccount";
            this.Text = "createAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button backBtn;
    }
}