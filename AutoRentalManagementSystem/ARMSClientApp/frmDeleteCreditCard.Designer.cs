namespace ARMSClientApp
{
    partial class frmDeleteCreditCard
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
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCardNumber = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.grpCardNumber.SuspendLayout();
            this.grpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(457, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter Card Number of Credit Card to Delete and Click Delete: ";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNumber.Location = new System.Drawing.Point(18, 69);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(89, 17);
            this.lblIDNumber.TabIndex = 1;
            this.lblIDNumber.Text = "ID Number ";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(150, 69);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(271, 22);
            this.txtIDNumber.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Info;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(455, 54);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(159, 52);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(455, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(159, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCardNumber
            // 
            this.grpCardNumber.Controls.Add(this.lblTitle);
            this.grpCardNumber.Controls.Add(this.lblIDNumber);
            this.grpCardNumber.Controls.Add(this.btnApply);
            this.grpCardNumber.Controls.Add(this.txtIDNumber);
            this.grpCardNumber.Location = new System.Drawing.Point(90, 26);
            this.grpCardNumber.Name = "grpCardNumber";
            this.grpCardNumber.Size = new System.Drawing.Size(637, 140);
            this.grpCardNumber.TabIndex = 5;
            this.grpCardNumber.TabStop = false;
            this.grpCardNumber.Text = "Card Number";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.btnCancel);
            this.grpButton.Location = new System.Drawing.Point(90, 172);
            this.grpButton.Name = "grpButton";
            this.grpButton.Size = new System.Drawing.Size(637, 100);
            this.grpButton.TabIndex = 6;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "Button";
            // 
            // frmDeleteCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpCardNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDeleteCreditCard";
            this.Text = "Delete Credit Card Screen";
            this.Load += new System.EventHandler(this.frmDeleteCreditCard_Load);
            this.grpCardNumber.ResumeLayout(false);
            this.grpCardNumber.PerformLayout();
            this.grpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCardNumber;
        private System.Windows.Forms.GroupBox grpButton;
    }
}