namespace ARMSClientApp
{
    partial class frmCreditCardSearch
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
            this.grpCardSearch = new System.Windows.Forms.GroupBox();
            this.grpCardData = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblMerchantName = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblHouseStreetAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStateCode = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtMerchantName = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtHouseStreetAddress = new System.Windows.Forms.TextBox();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCardSearch.SuspendLayout();
            this.grpCardData.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCardSearch
            // 
            this.grpCardSearch.Controls.Add(this.btnSearch);
            this.grpCardSearch.Controls.Add(this.txtCardNumber);
            this.grpCardSearch.Controls.Add(this.lblCardNumber);
            this.grpCardSearch.Controls.Add(this.lblTitle);
            this.grpCardSearch.Location = new System.Drawing.Point(92, 40);
            this.grpCardSearch.Name = "grpCardSearch";
            this.grpCardSearch.Size = new System.Drawing.Size(591, 106);
            this.grpCardSearch.TabIndex = 0;
            this.grpCardSearch.TabStop = false;
            this.grpCardSearch.Text = "Card Search";
            // 
            // grpCardData
            // 
            this.grpCardData.Controls.Add(this.txtActivationStatus);
            this.grpCardData.Controls.Add(this.txtCreditLimit);
            this.grpCardData.Controls.Add(this.txtCountry);
            this.grpCardData.Controls.Add(this.txtZipCode);
            this.grpCardData.Controls.Add(this.txtStateCode);
            this.grpCardData.Controls.Add(this.txtHouseStreetAddress);
            this.grpCardData.Controls.Add(this.txtCity);
            this.grpCardData.Controls.Add(this.txtExpDate);
            this.grpCardData.Controls.Add(this.txtMerchantName);
            this.grpCardData.Controls.Add(this.txtOwnerName);
            this.grpCardData.Controls.Add(this.txtCardNo);
            this.grpCardData.Controls.Add(this.lblActivationStatus);
            this.grpCardData.Controls.Add(this.lblCreditLimit);
            this.grpCardData.Controls.Add(this.lblCountry);
            this.grpCardData.Controls.Add(this.lblZipCode);
            this.grpCardData.Controls.Add(this.lblStateCode);
            this.grpCardData.Controls.Add(this.lblCity);
            this.grpCardData.Controls.Add(this.lblHouseStreetAddress);
            this.grpCardData.Controls.Add(this.lblExpDate);
            this.grpCardData.Controls.Add(this.lblMerchantName);
            this.grpCardData.Controls.Add(this.lblOwnerName);
            this.grpCardData.Controls.Add(this.lblCardNo);
            this.grpCardData.Location = new System.Drawing.Point(92, 152);
            this.grpCardData.Name = "grpCardData";
            this.grpCardData.Size = new System.Drawing.Size(591, 466);
            this.grpCardData.TabIndex = 1;
            this.grpCardData.TabStop = false;
            this.grpCardData.Text = "Card Data";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnCancel);
            this.grpButton.Controls.Add(this.btnApply);
            this.grpButton.Location = new System.Drawing.Point(92, 624);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(591, 100);
            this.grpButton.TabIndex = 2;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "Button";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(135, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Credit Card Number and Search:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(26, 61);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(98, 17);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "CardNumber";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(138, 61);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(275, 22);
            this.txtCardNumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(456, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 46);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(65, 42);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(98, 17);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "CardNumber";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(65, 78);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(86, 17);
            this.lblOwnerName.TabIndex = 1;
            this.lblOwnerName.Text = "OwnerName";
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.Location = new System.Drawing.Point(65, 122);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(104, 17);
            this.lblMerchantName.TabIndex = 2;
            this.lblMerchantName.Text = "MerchantName";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(65, 160);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(61, 17);
            this.lblExpDate.TabIndex = 3;
            this.lblExpDate.Text = "ExpDate";
            // 
            // lblHouseStreetAddress
            // 
            this.lblHouseStreetAddress.AutoSize = true;
            this.lblHouseStreetAddress.Location = new System.Drawing.Point(26, 200);
            this.lblHouseStreetAddress.Name = "lblHouseStreetAddress";
            this.lblHouseStreetAddress.Size = new System.Drawing.Size(139, 17);
            this.lblHouseStreetAddress.TabIndex = 4;
            this.lblHouseStreetAddress.Text = "HouseStreetAddress";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(65, 242);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblStateCode
            // 
            this.lblStateCode.AutoSize = true;
            this.lblStateCode.Location = new System.Drawing.Point(65, 279);
            this.lblStateCode.Name = "lblStateCode";
            this.lblStateCode.Size = new System.Drawing.Size(74, 17);
            this.lblStateCode.TabIndex = 6;
            this.lblStateCode.Text = "StateCode";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(65, 312);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(61, 17);
            this.lblZipCode.TabIndex = 7;
            this.lblZipCode.Text = "ZipCode";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(65, 348);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Location = new System.Drawing.Point(65, 391);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(74, 17);
            this.lblCreditLimit.TabIndex = 9;
            this.lblCreditLimit.Text = "CreditLimit";
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(65, 432);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(109, 17);
            this.lblActivationStatus.TabIndex = 10;
            this.lblActivationStatus.Text = "ActivationStatus";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(185, 42);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(274, 22);
            this.txtCardNo.TabIndex = 11;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(185, 78);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(274, 22);
            this.txtOwnerName.TabIndex = 12;
            // 
            // txtMerchantName
            // 
            this.txtMerchantName.Location = new System.Drawing.Point(185, 122);
            this.txtMerchantName.Name = "txtMerchantName";
            this.txtMerchantName.Size = new System.Drawing.Size(274, 22);
            this.txtMerchantName.TabIndex = 13;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(185, 160);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(274, 22);
            this.txtExpDate.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(185, 237);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(274, 22);
            this.txtCity.TabIndex = 15;
            // 
            // txtHouseStreetAddress
            // 
            this.txtHouseStreetAddress.Location = new System.Drawing.Point(185, 200);
            this.txtHouseStreetAddress.Name = "txtHouseStreetAddress";
            this.txtHouseStreetAddress.Size = new System.Drawing.Size(274, 22);
            this.txtHouseStreetAddress.TabIndex = 16;
            // 
            // txtStateCode
            // 
            this.txtStateCode.Location = new System.Drawing.Point(185, 274);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(274, 22);
            this.txtStateCode.TabIndex = 17;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(185, 309);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(274, 22);
            this.txtZipCode.TabIndex = 18;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(185, 348);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(274, 22);
            this.txtCountry.TabIndex = 19;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(185, 388);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(274, 22);
            this.txtCreditLimit.TabIndex = 20;
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.Location = new System.Drawing.Point(185, 429);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.Size = new System.Drawing.Size(274, 22);
            this.txtActivationStatus.TabIndex = 21;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Info;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(122, 33);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(144, 45);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(306, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreditCardSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 754);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpCardData);
            this.Controls.Add(this.grpCardSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCreditCardSearch";
            this.Text = "Credit Card Search Screen";
            this.grpCardSearch.ResumeLayout(false);
            this.grpCardSearch.PerformLayout();
            this.grpCardData.ResumeLayout(false);
            this.grpCardData.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCardSearch;
        private System.Windows.Forms.GroupBox grpCardData;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblStateCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblHouseStreetAddress;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.TextBox txtHouseStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtMerchantName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}