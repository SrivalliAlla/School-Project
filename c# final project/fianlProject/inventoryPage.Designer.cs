namespace fianlProject
{
    partial class inventoryPage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.itemToBuy = new System.Windows.Forms.ComboBox();
            this.textBoz = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(332, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Inventory Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 15F);
            this.label1.Location = new System.Drawing.Point(69, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "What would you like to check?";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.submitBtn.Location = new System.Drawing.Point(140, 433);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(214, 84);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("SimSun", 15F);
            this.backBtn.Location = new System.Drawing.Point(510, 433);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(214, 84);
            this.backBtn.TabIndex = 12;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.itemToBuy.Location = new System.Drawing.Point(543, 142);
            this.itemToBuy.Name = "itemToBuy";
            this.itemToBuy.Size = new System.Drawing.Size(121, 28);
            this.itemToBuy.TabIndex = 47;
            // 
            // textBoz
            // 
            this.textBoz.Location = new System.Drawing.Point(240, 207);
            this.textBoz.Multiline = true;
            this.textBoz.Name = "textBoz";
            this.textBoz.Size = new System.Drawing.Size(388, 152);
            this.textBoz.TabIndex = 48;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // inventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 648);
            this.Controls.Add(this.textBoz);
            this.Controls.Add(this.itemToBuy);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "inventoryPage";
            this.Text = "inventoryPage";
            this.Load += new System.EventHandler(this.inventoryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox itemToBuy;
        private System.Windows.Forms.TextBox textBoz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}