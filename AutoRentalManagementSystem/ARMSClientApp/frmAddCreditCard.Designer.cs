namespace ARMSClientApp
{
    partial class frmAddCreditCard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblMerchantName = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblHouseStreetAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStateCode = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtHouseStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.txtMerchantName = new System.Windows.Forms.TextBox();
            this.txtCardOwner = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCardData = new System.Windows.Forms.GroupBox();
            this.txtActivationStatus = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.lblActivationStatus = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.grpCardData.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(129, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Credit Card Information:";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.Location = new System.Drawing.Point(27, 74);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(103, 17);
            this.lblCardNumber.TabIndex = 1;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(24, 113);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(90, 17);
            this.lblOwnerName.TabIndex = 2;
            this.lblOwnerName.Text = "Owner Name";
            // 
            // lblMerchantName
            // 
            this.lblMerchantName.AutoSize = true;
            this.lblMerchantName.Location = new System.Drawing.Point(24, 151);
            this.lblMerchantName.Name = "lblMerchantName";
            this.lblMerchantName.Size = new System.Drawing.Size(104, 17);
            this.lblMerchantName.TabIndex = 3;
            this.lblMerchantName.Text = "MerchantName";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(44, 190);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(61, 17);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "ExpDate";
            // 
            // lblHouseStreetAddress
            // 
            this.lblHouseStreetAddress.AutoSize = true;
            this.lblHouseStreetAddress.Location = new System.Drawing.Point(44, 229);
            this.lblHouseStreetAddress.Name = "lblHouseStreetAddress";
            this.lblHouseStreetAddress.Size = new System.Drawing.Size(139, 17);
            this.lblHouseStreetAddress.TabIndex = 5;
            this.lblHouseStreetAddress.Text = "HouseStreetAddress";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(76, 279);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City";
            // 
            // lblStateCode
            // 
            this.lblStateCode.AutoSize = true;
            this.lblStateCode.Location = new System.Drawing.Point(76, 320);
            this.lblStateCode.Name = "lblStateCode";
            this.lblStateCode.Size = new System.Drawing.Size(74, 17);
            this.lblStateCode.TabIndex = 8;
            this.lblStateCode.Text = "StateCode";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(69, 362);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(61, 17);
            this.lblZipCode.TabIndex = 9;
            this.lblZipCode.Text = "ZipCode";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(73, 414);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(197, 71);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(261, 22);
            this.txtCardNumber.TabIndex = 11;
            // 
            // txtHouseStreetAddress
            // 
            this.txtHouseStreetAddress.Location = new System.Drawing.Point(197, 226);
            this.txtHouseStreetAddress.Name = "txtHouseStreetAddress";
            this.txtHouseStreetAddress.Size = new System.Drawing.Size(261, 22);
            this.txtHouseStreetAddress.TabIndex = 12;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(197, 274);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(261, 22);
            this.txtCity.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(197, 317);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(261, 22);
            this.txtState.TabIndex = 15;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(197, 362);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(261, 22);
            this.txtZipCode.TabIndex = 16;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(197, 411);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(261, 22);
            this.txtCountry.TabIndex = 17;
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(197, 187);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(261, 22);
            this.txtExpDate.TabIndex = 18;
            // 
            // txtMerchantName
            // 
            this.txtMerchantName.Location = new System.Drawing.Point(197, 151);
            this.txtMerchantName.Name = "txtMerchantName";
            this.txtMerchantName.Size = new System.Drawing.Size(261, 22);
            this.txtMerchantName.TabIndex = 19;
            // 
            // txtCardOwner
            // 
            this.txtCardOwner.Location = new System.Drawing.Point(197, 113);
            this.txtCardOwner.Name = "txtCardOwner";
            this.txtCardOwner.Size = new System.Drawing.Size(261, 22);
            this.txtCardOwner.TabIndex = 20;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Info;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(88, 21);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(157, 49);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(280, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 49);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCardData
            // 
            this.grpCardData.Controls.Add(this.txtActivationStatus);
            this.grpCardData.Controls.Add(this.txtCreditLimit);
            this.grpCardData.Controls.Add(this.lblActivationStatus);
            this.grpCardData.Controls.Add(this.lblCreditLimit);
            this.grpCardData.Controls.Add(this.lblTitle);
            this.grpCardData.Controls.Add(this.lblCardNumber);
            this.grpCardData.Controls.Add(this.txtCardNumber);
            this.grpCardData.Controls.Add(this.txtCountry);
            this.grpCardData.Controls.Add(this.txtExpDate);
            this.grpCardData.Controls.Add(this.txtZipCode);
            this.grpCardData.Controls.Add(this.txtMerchantName);
            this.grpCardData.Controls.Add(this.txtState);
            this.grpCardData.Controls.Add(this.txtCardOwner);
            this.grpCardData.Controls.Add(this.txtCity);
            this.grpCardData.Controls.Add(this.lblOwnerName);
            this.grpCardData.Controls.Add(this.lblMerchantName);
            this.grpCardData.Controls.Add(this.txtHouseStreetAddress);
            this.grpCardData.Controls.Add(this.lblExpDate);
            this.grpCardData.Controls.Add(this.lblHouseStreetAddress);
            this.grpCardData.Controls.Add(this.lblCity);
            this.grpCardData.Controls.Add(this.lblStateCode);
            this.grpCardData.Controls.Add(this.lblZipCode);
            this.grpCardData.Controls.Add(this.lblCountry);
            this.grpCardData.Location = new System.Drawing.Point(78, 33);
            this.grpCardData.Name = "grpCardData";
            this.grpCardData.Size = new System.Drawing.Size(493, 544);
            this.grpCardData.TabIndex = 23;
            this.grpCardData.TabStop = false;
            this.grpCardData.Text = "Card Data";
            // 
            // txtActivationStatus
            // 
            this.txtActivationStatus.Location = new System.Drawing.Point(197, 499);
            this.txtActivationStatus.Name = "txtActivationStatus";
            this.txtActivationStatus.Size = new System.Drawing.Size(261, 22);
            this.txtActivationStatus.TabIndex = 24;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(197, 458);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(261, 22);
            this.txtCreditLimit.TabIndex = 23;
            // 
            // lblActivationStatus
            // 
            this.lblActivationStatus.AutoSize = true;
            this.lblActivationStatus.Location = new System.Drawing.Point(61, 499);
            this.lblActivationStatus.Name = "lblActivationStatus";
            this.lblActivationStatus.Size = new System.Drawing.Size(109, 17);
            this.lblActivationStatus.TabIndex = 22;
            this.lblActivationStatus.Text = "ActivationStatus";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Location = new System.Drawing.Point(61, 458);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(78, 17);
            this.lblCreditLimit.TabIndex = 21;
            this.lblCreditLimit.Text = "Credit Limit";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnApply);
            this.grpButton.Controls.Add(this.btnCancel);
            this.grpButton.Location = new System.Drawing.Point(78, 583);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(493, 100);
            this.grpButton.TabIndex = 24;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "Button";
            // 
            // frmAddCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 717);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpCardData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddCreditCard";
            this.Text = "Add Credit Card Screen";
            this.grpCardData.ResumeLayout(false);
            this.grpCardData.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblMerchantName;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblHouseStreetAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStateCode;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtHouseStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtMerchantName;
        private System.Windows.Forms.TextBox txtCardOwner;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCardData;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.TextBox txtActivationStatus;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.Label lblActivationStatus;
        private System.Windows.Forms.Label lblCreditLimit;
    }
}