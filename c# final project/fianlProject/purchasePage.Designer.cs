namespace fianlProject
{
    partial class purchasePage
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.howManyTxt = new System.Windows.Forms.TextBox();
            this.finishButton = new System.Windows.Forms.Button();
            this.usersEmail = new System.Windows.Forms.TextBox();
            this.itemToBuy = new System.Windows.Forms.ComboBox();
            this.hugeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.backBtn.Location = new System.Drawing.Point(539, 610);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(214, 84);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(371, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Purchase Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F);
            this.label1.Location = new System.Drawing.Point(100, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "What would you like to buy?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 15F);
            this.label3.Location = new System.Drawing.Point(100, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "How many?";
            // 
            // howManyTxt
            // 
            this.howManyTxt.Location = new System.Drawing.Point(272, 239);
            this.howManyTxt.Margin = new System.Windows.Forms.Padding(2);
            this.howManyTxt.Name = "howManyTxt";
            this.howManyTxt.Size = new System.Drawing.Size(230, 26);
            this.howManyTxt.TabIndex = 17;
            // 
            // finishButton
            // 
            this.finishButton.Font = new System.Drawing.Font("SimSun", 15F);
            this.finishButton.Location = new System.Drawing.Point(236, 610);
            this.finishButton.Margin = new System.Windows.Forms.Padding(2);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(214, 84);
            this.finishButton.TabIndex = 19;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // usersEmail
            // 
            this.usersEmail.Location = new System.Drawing.Point(105, 306);
            this.usersEmail.Margin = new System.Windows.Forms.Padding(2);
            this.usersEmail.Name = "usersEmail";
            this.usersEmail.Size = new System.Drawing.Size(504, 26);
            this.usersEmail.TabIndex = 20;
            this.usersEmail.Text = "Please Enter Your Email...";
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
            this.itemToBuy.Location = new System.Drawing.Point(539, 132);
            this.itemToBuy.Name = "itemToBuy";
            this.itemToBuy.Size = new System.Drawing.Size(121, 28);
            this.itemToBuy.TabIndex = 46;
            // 
            // hugeTextBox
            // 
            this.hugeTextBox.Location = new System.Drawing.Point(181, 364);
            this.hugeTextBox.Multiline = true;
            this.hugeTextBox.Name = "hugeTextBox";
            this.hugeTextBox.Size = new System.Drawing.Size(604, 220);
            this.hugeTextBox.TabIndex = 47;
            // 
            // purchasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 808);
            this.Controls.Add(this.hugeTextBox);
            this.Controls.Add(this.itemToBuy);
            this.Controls.Add(this.usersEmail);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.howManyTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "purchasePage";
            this.Text = "purchasePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox howManyTxt;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TextBox usersEmail;
        private System.Windows.Forms.ComboBox itemToBuy;
        private System.Windows.Forms.TextBox hugeTextBox;
    }
}