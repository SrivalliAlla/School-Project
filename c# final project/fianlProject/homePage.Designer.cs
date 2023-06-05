namespace fianlProject
{
    partial class homePage
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.contactBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.createAccountBttn = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(244, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Convenience Store";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.inventoryBtn.Location = new System.Drawing.Point(301, 601);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(461, 102);
            this.inventoryBtn.TabIndex = 4;
            this.inventoryBtn.Text = "Total Inventory Page";
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // contactBtn
            // 
            this.contactBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.contactBtn.Location = new System.Drawing.Point(301, 770);
            this.contactBtn.Margin = new System.Windows.Forms.Padding(2);
            this.contactBtn.Name = "contactBtn";
            this.contactBtn.Size = new System.Drawing.Size(461, 102);
            this.contactBtn.TabIndex = 5;
            this.contactBtn.Text = "Contact Page";
            this.contactBtn.UseVisualStyleBackColor = true;
            this.contactBtn.Click += new System.EventHandler(this.contactBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.purchaseBtn.Location = new System.Drawing.Point(301, 256);
            this.purchaseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(461, 102);
            this.purchaseBtn.TabIndex = 6;
            this.purchaseBtn.Text = "Purchase Page";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // createAccountBttn
            // 
            this.createAccountBttn.Font = new System.Drawing.Font("SimSun", 15F);
            this.createAccountBttn.Location = new System.Drawing.Point(301, 110);
            this.createAccountBttn.Margin = new System.Windows.Forms.Padding(2);
            this.createAccountBttn.Name = "createAccountBttn";
            this.createAccountBttn.Size = new System.Drawing.Size(461, 102);
            this.createAccountBttn.TabIndex = 7;
            this.createAccountBttn.Text = "Create Account Page";
            this.createAccountBttn.UseVisualStyleBackColor = true;
            this.createAccountBttn.Click += new System.EventHandler(this.createAccountBttn_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("SimSun", 15F);
            this.returnButton.Location = new System.Drawing.Point(301, 418);
            this.returnButton.Margin = new System.Windows.Forms.Padding(2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(461, 102);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Return Page ";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 930);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.createAccountBttn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.contactBtn);
            this.Controls.Add(this.inventoryBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homePage";
            this.Text = "homePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button contactBtn;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button createAccountBttn;
        private System.Windows.Forms.Button returnButton;
    }
}

