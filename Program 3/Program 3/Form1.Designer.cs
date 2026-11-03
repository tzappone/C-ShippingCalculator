namespace Program_3
{
    partial class Form1
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.providerLbl = new System.Windows.Forms.Label();
            this.providerCombo = new System.Windows.Forms.ComboBox();
            this.businessLbl = new System.Windows.Forms.Label();
            this.businessCombo = new System.Windows.Forms.ComboBox();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.shippingProviderLbl = new System.Windows.Forms.Label();
            this.userProviderLbl = new System.Windows.Forms.Label();
            this.initialPriceLbl = new System.Windows.Forms.Label();
            this.userPriceLbl = new System.Windows.Forms.Label();
            this.companyDiscountLbl = new System.Windows.Forms.Label();
            this.userCompanyDiscountLbl = new System.Windows.Forms.Label();
            this.lengthDiscountLbl = new System.Windows.Forms.Label();
            this.userLengthLbl = new System.Windows.Forms.Label();
            this.finalLbl = new System.Windows.Forms.Label();
            this.finalPriceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(348, 56);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(377, 32);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Shipping Contract Calculator";
            // 
            // providerLbl
            // 
            this.providerLbl.AutoSize = true;
            this.providerLbl.Location = new System.Drawing.Point(108, 141);
            this.providerLbl.Name = "providerLbl";
            this.providerLbl.Size = new System.Drawing.Size(128, 32);
            this.providerLbl.TabIndex = 1;
            this.providerLbl.Text = "Provider:";
            // 
            // providerCombo
            // 
            this.providerCombo.FormattingEnabled = true;
            this.providerCombo.Items.AddRange(new object[] {
            "USPS",
            "DHL",
            "FedEx",
            "UPS"});
            this.providerCombo.Location = new System.Drawing.Point(409, 141);
            this.providerCombo.Name = "providerCombo";
            this.providerCombo.Size = new System.Drawing.Size(400, 39);
            this.providerCombo.TabIndex = 2;
            // 
            // businessLbl
            // 
            this.businessLbl.AutoSize = true;
            this.businessLbl.Location = new System.Drawing.Point(114, 264);
            this.businessLbl.Name = "businessLbl";
            this.businessLbl.Size = new System.Drawing.Size(138, 32);
            this.businessLbl.TabIndex = 3;
            this.businessLbl.Text = "Business:";
            // 
            // businessCombo
            // 
            this.businessCombo.FormattingEnabled = true;
            this.businessCombo.Items.AddRange(new object[] {
            "John\'s Books",
            "Office Supplies",
            "J.B. Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear"});
            this.businessCombo.Location = new System.Drawing.Point(409, 255);
            this.businessCombo.Name = "businessCombo";
            this.businessCombo.Size = new System.Drawing.Size(400, 39);
            this.businessCombo.TabIndex = 4;
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(114, 344);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(224, 32);
            this.lengthLbl.TabIndex = 5;
            this.lengthLbl.Text = "Contract Length:";
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(409, 344);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(400, 38);
            this.lengthTxt.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(374, 435);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(189, 57);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // shippingProviderLbl
            // 
            this.shippingProviderLbl.AutoSize = true;
            this.shippingProviderLbl.Location = new System.Drawing.Point(114, 551);
            this.shippingProviderLbl.Name = "shippingProviderLbl";
            this.shippingProviderLbl.Size = new System.Drawing.Size(248, 32);
            this.shippingProviderLbl.TabIndex = 8;
            this.shippingProviderLbl.Text = "Shipping Provider:";
            // 
            // userProviderLbl
            // 
            this.userProviderLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userProviderLbl.Location = new System.Drawing.Point(442, 537);
            this.userProviderLbl.Name = "userProviderLbl";
            this.userProviderLbl.Size = new System.Drawing.Size(367, 61);
            this.userProviderLbl.TabIndex = 9;
            // 
            // initialPriceLbl
            // 
            this.initialPriceLbl.AutoSize = true;
            this.initialPriceLbl.Location = new System.Drawing.Point(114, 647);
            this.initialPriceLbl.Name = "initialPriceLbl";
            this.initialPriceLbl.Size = new System.Drawing.Size(276, 32);
            this.initialPriceLbl.TabIndex = 10;
            this.initialPriceLbl.Text = "Initial Contract Price:";
            // 
            // userPriceLbl
            // 
            this.userPriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPriceLbl.Location = new System.Drawing.Point(442, 647);
            this.userPriceLbl.Name = "userPriceLbl";
            this.userPriceLbl.Size = new System.Drawing.Size(368, 53);
            this.userPriceLbl.TabIndex = 11;
            // 
            // companyDiscountLbl
            // 
            this.companyDiscountLbl.AutoSize = true;
            this.companyDiscountLbl.Location = new System.Drawing.Point(120, 740);
            this.companyDiscountLbl.Name = "companyDiscountLbl";
            this.companyDiscountLbl.Size = new System.Drawing.Size(261, 32);
            this.companyDiscountLbl.TabIndex = 12;
            this.companyDiscountLbl.Text = "Company Discount:";
            // 
            // userCompanyDiscountLbl
            // 
            this.userCompanyDiscountLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userCompanyDiscountLbl.Location = new System.Drawing.Point(442, 740);
            this.userCompanyDiscountLbl.Name = "userCompanyDiscountLbl";
            this.userCompanyDiscountLbl.Size = new System.Drawing.Size(368, 53);
            this.userCompanyDiscountLbl.TabIndex = 13;
            // 
            // lengthDiscountLbl
            // 
            this.lengthDiscountLbl.AutoSize = true;
            this.lengthDiscountLbl.Location = new System.Drawing.Point(120, 828);
            this.lengthDiscountLbl.Name = "lengthDiscountLbl";
            this.lengthDiscountLbl.Size = new System.Drawing.Size(228, 32);
            this.lengthDiscountLbl.TabIndex = 14;
            this.lengthDiscountLbl.Text = "Length Discount:";
            // 
            // userLengthLbl
            // 
            this.userLengthLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userLengthLbl.Location = new System.Drawing.Point(442, 828);
            this.userLengthLbl.Name = "userLengthLbl";
            this.userLengthLbl.Size = new System.Drawing.Size(368, 51);
            this.userLengthLbl.TabIndex = 15;
            // 
            // finalLbl
            // 
            this.finalLbl.AutoSize = true;
            this.finalLbl.Location = new System.Drawing.Point(120, 913);
            this.finalLbl.Name = "finalLbl";
            this.finalLbl.Size = new System.Drawing.Size(157, 32);
            this.finalLbl.TabIndex = 16;
            this.finalLbl.Text = "Final Price:";
            // 
            // finalPriceLbl
            // 
            this.finalPriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalPriceLbl.Location = new System.Drawing.Point(433, 913);
            this.finalPriceLbl.Name = "finalPriceLbl";
            this.finalPriceLbl.Size = new System.Drawing.Size(377, 53);
            this.finalPriceLbl.TabIndex = 17;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 1166);
            this.Controls.Add(this.finalPriceLbl);
            this.Controls.Add(this.finalLbl);
            this.Controls.Add(this.userLengthLbl);
            this.Controls.Add(this.lengthDiscountLbl);
            this.Controls.Add(this.userCompanyDiscountLbl);
            this.Controls.Add(this.companyDiscountLbl);
            this.Controls.Add(this.userPriceLbl);
            this.Controls.Add(this.initialPriceLbl);
            this.Controls.Add(this.userProviderLbl);
            this.Controls.Add(this.shippingProviderLbl);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.businessCombo);
            this.Controls.Add(this.businessLbl);
            this.Controls.Add(this.providerCombo);
            this.Controls.Add(this.providerLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "Program 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label providerLbl;
        private System.Windows.Forms.ComboBox providerCombo;
        private System.Windows.Forms.Label businessLbl;
        private System.Windows.Forms.ComboBox businessCombo;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label shippingProviderLbl;
        private System.Windows.Forms.Label userProviderLbl;
        private System.Windows.Forms.Label initialPriceLbl;
        private System.Windows.Forms.Label userPriceLbl;
        private System.Windows.Forms.Label companyDiscountLbl;
        private System.Windows.Forms.Label userCompanyDiscountLbl;
        private System.Windows.Forms.Label lengthDiscountLbl;
        private System.Windows.Forms.Label userLengthLbl;
        private System.Windows.Forms.Label finalLbl;
        private System.Windows.Forms.Label finalPriceLbl;
    }
}

