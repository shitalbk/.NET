namespace ARMSClientApp
{
    partial class frmCAMain
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
            this.btnCardSearch = new System.Windows.Forms.Button();
            this.btnCardRegister = new System.Windows.Forms.Button();
            this.btnCardUpdate = new System.Windows.Forms.Button();
            this.btnCardDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(107, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10);
            this.lblTitle.Size = new System.Drawing.Size(234, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Credit Card Management Screen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCardSearch
            // 
            this.btnCardSearch.Location = new System.Drawing.Point(110, 85);
            this.btnCardSearch.Name = "btnCardSearch";
            this.btnCardSearch.Size = new System.Drawing.Size(311, 63);
            this.btnCardSearch.TabIndex = 1;
            this.btnCardSearch.Text = "Credit Card Search";
            this.btnCardSearch.UseVisualStyleBackColor = true;
            this.btnCardSearch.Click += new System.EventHandler(this.btnCardSearch_Click);
            // 
            // btnCardRegister
            // 
            this.btnCardRegister.Location = new System.Drawing.Point(110, 169);
            this.btnCardRegister.Name = "btnCardRegister";
            this.btnCardRegister.Size = new System.Drawing.Size(311, 54);
            this.btnCardRegister.TabIndex = 2;
            this.btnCardRegister.Text = "Credit Card Registration";
            this.btnCardRegister.UseVisualStyleBackColor = true;
            this.btnCardRegister.Click += new System.EventHandler(this.btnCardRegister_Click);
            // 
            // btnCardUpdate
            // 
            this.btnCardUpdate.Location = new System.Drawing.Point(110, 244);
            this.btnCardUpdate.Name = "btnCardUpdate";
            this.btnCardUpdate.Size = new System.Drawing.Size(311, 52);
            this.btnCardUpdate.TabIndex = 3;
            this.btnCardUpdate.Text = "Credit Card Update";
            this.btnCardUpdate.UseVisualStyleBackColor = true;
            this.btnCardUpdate.Click += new System.EventHandler(this.btnCardUpdate_Click);
            // 
            // btnCardDelete
            // 
            this.btnCardDelete.Location = new System.Drawing.Point(110, 315);
            this.btnCardDelete.Name = "btnCardDelete";
            this.btnCardDelete.Size = new System.Drawing.Size(311, 60);
            this.btnCardDelete.TabIndex = 4;
            this.btnCardDelete.Text = "Credit Card Deletion";
            this.btnCardDelete.UseVisualStyleBackColor = true;
            this.btnCardDelete.Click += new System.EventHandler(this.btnCardDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmCAMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 525);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCardDelete);
            this.Controls.Add(this.btnCardUpdate);
            this.Controls.Add(this.btnCardRegister);
            this.Controls.Add(this.btnCardSearch);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCAMain";
            this.Text = "Credit Card Management System";
            this.Load += new System.EventHandler(this.frmCAMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCardSearch;
        private System.Windows.Forms.Button btnCardRegister;
        private System.Windows.Forms.Button btnCardUpdate;
        private System.Windows.Forms.Button btnCardDelete;
        private System.Windows.Forms.Button btnExit;
    }
}

