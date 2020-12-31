namespace ARMSClientApp
{
    partial class frmEditCreditCard
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
            this.grpCardData = new System.Windows.Forms.GroupBox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
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
            this.txtHouseStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCardData.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCardData
            // 
            this.grpCardData.Controls.Add(this.btnSearch);
            this.grpCardData.Controls.Add(this.txtCardNumber);
            this.grpCardData.Controls.Add(this.lblCardNumber);
            this.grpCardData.Controls.Add(this.lblTitle);
            this.grpCardData.Location = new System.Drawing.Point(88, 27);
            this.grpCardData.Name = "grpCardData";
            this.grpCardData.Size = new System.Drawing.Size(524, 115);
            this.grpCardData.TabIndex = 0;
            this.grpCardData.TabStop = false;
            this.grpCardData.Text = "Card Data";
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.txtActivationStatus);
            this.grpData.Controls.Add(this.txtCreditLimit);
            this.grpData.Controls.Add(this.txtCountry);
            this.grpData.Controls.Add(this.txtZipCode);
            this.grpData.Controls.Add(this.txtStateCode);
            this.grpData.Controls.Add(this.txtCity);
            this.grpData.Controls.Add(this.txtHouseStreetAddress);
            this.grpData.Controls.Add(this.txtExpDate);
            this.grpData.Controls.Add(this.txtMerchantName);
            this.grpData.Controls.Add(this.txtOwnerName);
            this.grpData.Controls.Add(this.txtCardNo);
            this.grpData.Controls.Add(this.lblActivationStatus);
            this.grpData.Controls.Add(this.lblCreditLimit);
            this.grpData.Controls.Add(this.lblCountry);
            this.grpData.Controls.Add(this.lblZipCode);
            this.grpData.Controls.Add(this.lblStateCode);
            this.grpData.Controls.Add(this.lblCity);
            this.grpData.Controls.Add(this.lblHouseStreetAddress);
            this.grpData.Controls.Add(this.lblExpDate);
            this.grpData.Controls.Add(this.lblMerchantName);
            this.grpData.Controls.Add(this.lblOwnerName);
            this.grpData.Controls.Add(this.lblCardNo);
            this.grpData.Controls.Add(this.lblTitle2);
            this.grpData.Location = new System.Drawing.Point(88, 148);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(524, 474);
            this.grpData.TabIndex = 1;
            this.grpData.TabStop = false;
            this.grpData.Text = "Card Data";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnCancel);
            this.grpButton.Controls.Add(this.btnApply);
            this.grpButton.Location = new System.Drawing.Point(88, 628);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(524, 100);
            this.grpButton.TabIndex = 2;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "Button";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(159, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Credit Card Info:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(10, 59);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(103, 17);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(129, 59);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(236, 22);
            this.txtCardNumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(390, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.Location = new System.Drawing.Point(140, 18);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(225, 17);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Enter Credit Card Information:";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNo.Location = new System.Drawing.Point(54, 53);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(103, 17);
            this.lblCardNo.TabIndex = 1;
            this.lblCardNo.Text = "Card Number";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(54, 91);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(86, 17);
            this.lblOwnerName.TabIndex = 2;
            this.lblOwnerName.Text = "OwnerName";
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.Location = new System.Drawing.Point(54, 130);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(108, 17);
            this.lblMerchantName.TabIndex = 3;
            this.lblMerchantName.Text = "Merchant Name";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(54, 165);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(61, 17);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "ExpDate";
            // 
            // lblHouseStreetAddress
            // 
            this.lblHouseStreetAddress.AutoSize = true;
            this.lblHouseStreetAddress.Location = new System.Drawing.Point(54, 205);
            this.lblHouseStreetAddress.Name = "lblHouseStreetAddress";
            this.lblHouseStreetAddress.Size = new System.Drawing.Size(139, 17);
            this.lblHouseStreetAddress.TabIndex = 5;
            this.lblHouseStreetAddress.Text = "HouseStreetAddress";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(54, 240);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblStateCode
            // 
            this.lblStateCode.AutoSize = true;
            this.lblStateCode.Location = new System.Drawing.Point(54, 276);
            this.lblStateCode.Name = "lblStateCode";
            this.lblStateCode.Size = new System.Drawing.Size(74, 17);
            this.lblStateCode.TabIndex = 7;
            this.lblStateCode.Text = "StateCode";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(54, 315);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(61, 17);
            this.lblZipCode.TabIndex = 8;
            this.lblZipCode.Text = "ZipCode";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(54, 351);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Location = new System.Drawing.Point(54, 384);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(74, 17);
            this.lblCreditLimit.TabIndex = 10;
            this.lblCreditLimit.Text = "CreditLimit";
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(54, 422);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(109, 17);
            this.lblActivationStatus.TabIndex = 11;
            this.lblActivationStatus.Text = "ActivationStatus";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(199, 50);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(257, 22);
            this.txtCardNo.TabIndex = 12;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(199, 88);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(257, 22);
            this.txtOwnerName.TabIndex = 13;
            // 
            // txtMerchantName
            // 
            this.txtMerchantName.Location = new System.Drawing.Point(199, 130);
            this.txtMerchantName.Name = "txtMerchantName";
            this.txtMerchantName.Size = new System.Drawing.Size(257, 22);
            this.txtMerchantName.TabIndex = 14;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(199, 165);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(257, 22);
            this.txtExpDate.TabIndex = 15;
            // 
            // txtHouseStreetAddress
            // 
            this.txtHouseStreetAddress.Location = new System.Drawing.Point(199, 205);
            this.txtHouseStreetAddress.Name = "txtHouseStreetAddress";
            this.txtHouseStreetAddress.Size = new System.Drawing.Size(257, 22);
            this.txtHouseStreetAddress.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(199, 240);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(257, 22);
            this.txtCity.TabIndex = 17;
            // 
            // txtStateCode
            // 
            this.txtStateCode.Location = new System.Drawing.Point(199, 276);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(257, 22);
            this.txtStateCode.TabIndex = 18;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(199, 310);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(257, 22);
            this.txtZipCode.TabIndex = 19;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(199, 348);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(257, 22);
            this.txtCountry.TabIndex = 20;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(199, 384);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(257, 22);
            this.txtCreditLimit.TabIndex = 21;
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.Location = new System.Drawing.Point(199, 422);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.Size = new System.Drawing.Size(257, 22);
            this.txtActivationStatus.TabIndex = 22;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Info;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(102, 31);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(131, 47);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(271, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 47);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 740);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpCardData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditCreditCard";
            this.Text = "Edit Credit Card Screen";
            this.grpCardData.ResumeLayout(false);
            this.grpCardData.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCardData;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtHouseStreetAddress;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtMerchantName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtCardNo;
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
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}