namespace fianlProject
{
    partial class returnPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.howManyAnswer = new System.Windows.Forms.TextBox();
            this.usersEmail = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.itemToBuy = new System.Windows.Forms.ComboBox();
            this.hugeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(396, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Return Page";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F);
            this.label1.Location = new System.Drawing.Point(125, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "What would you like to return?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 15F);
            this.label3.Location = new System.Drawing.Point(125, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "How many?";
            // 
            // howManyAnswer
            // 
            this.howManyAnswer.Location = new System.Drawing.Point(374, 262);
            this.howManyAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.howManyAnswer.Name = "howManyAnswer";
            this.howManyAnswer.Size = new System.Drawing.Size(230, 26);
            this.howManyAnswer.TabIndex = 20;
            // 
            // usersEmail
            // 
            this.usersEmail.Location = new System.Drawing.Point(130, 339);
            this.usersEmail.Margin = new System.Windows.Forms.Padding(2);
            this.usersEmail.Name = "usersEmail";
            this.usersEmail.Size = new System.Drawing.Size(504, 26);
            this.usersEmail.TabIndex = 21;
            this.usersEmail.Text = "Please Enter Your Email...";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.submitBtn.Location = new System.Drawing.Point(212, 776);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(214, 84);
            this.submitBtn.TabIndex = 22;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("SimSun", 15F);
            this.backButton.Location = new System.Drawing.Point(512, 776);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 84);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // itemToBuy
            // 
            this.itemToBuy.FormattingEnabled = true;
            this.itemToBuy.Items.AddRange(new object[] {
            "Coke",
            "Diet Coke",
            "Sprite",
            "Iced Tea",
            "Dr. Pepper",
            "7-Up",
            "Bottle Water",
            "Ice Cream"});
            this.itemToBuy.Location = new System.Drawing.Point(605, 215);
            this.itemToBuy.Name = "itemToBuy";
            this.itemToBuy.Size = new System.Drawing.Size(121, 28);
            this.itemToBuy.TabIndex = 47;
            // 
            // hugeTextBox
            // 
            this.hugeTextBox.Location = new System.Drawing.Point(130, 426);
            this.hugeTextBox.Multiline = true;
            this.hugeTextBox.Name = "hugeTextBox";
            this.hugeTextBox.Size = new System.Drawing.Size(604, 220);
            this.hugeTextBox.TabIndex = 48;
            // 
            // returnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 891);
            this.Controls.Add(this.hugeTextBox);
            this.Controls.Add(this.itemToBuy);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.usersEmail);
            this.Controls.Add(this.howManyAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "returnPage";
            this.Text = "returnPage";
            this.Load += new System.EventHandler(this.returnPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox howManyAnswer;
        private System.Windows.Forms.TextBox usersEmail;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox itemToBuy;
        private System.Windows.Forms.TextBox hugeTextBox;
    }
}