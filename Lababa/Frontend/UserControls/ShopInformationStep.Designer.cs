namespace Lababa.Frontend.UserControls
{
    partial class ShopInformationStep
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.txtShopName = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.txtAddress = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.txtPhoneNumber = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetails.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDetails
            // 
            this.tlpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDetails.ColumnCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.txtShopName, 0, 0);
            this.tlpDetails.Controls.Add(this.txtAddress, 0, 1);
            this.tlpDetails.Controls.Add(this.txtPhoneNumber, 0, 2);
            this.tlpDetails.Location = new System.Drawing.Point(3, 3);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(10);
            this.tlpDetails.RowCount = 3;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.Size = new System.Drawing.Size(530, 168);
            this.tlpDetails.TabIndex = 0;
            // 
            // txtShopName
            // 
            this.txtShopName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShopName.LabelText = "Shop Name";
            this.txtShopName.Location = new System.Drawing.Point(13, 13);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(504, 47);
            this.txtShopName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.LabelText = "Address";
            this.txtAddress.Location = new System.Drawing.Point(13, 66);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(504, 47);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.LabelText = "Phone Number";
            this.txtPhoneNumber.Location = new System.Drawing.Point(13, 119);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(504, 47);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.tlpDetails, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(536, 550);
            this.tlpContainer.TabIndex = 1;
            // 
            // ShopInformationStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "ShopInformationStep";
            this.Size = new System.Drawing.Size(536, 550);
            this.tlpDetails.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private LabeledTextBox txtShopName;
        private LabeledTextBox txtAddress;
        private LabeledTextBox txtPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
    }
}
