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
            this.ltbShopName = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.ltbAddress = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.ltbPhoneNumber = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetails.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.ltbShopName, 0, 0);
            this.tlpDetails.Controls.Add(this.ltbAddress, 0, 1);
            this.tlpDetails.Controls.Add(this.ltbPhoneNumber, 0, 2);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(3, 3);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.tlpDetails.RowCount = 3;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.Size = new System.Drawing.Size(444, 168);
            this.tlpDetails.TabIndex = 0;
            // 
            // ltbShopName
            // 
            this.ltbShopName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbShopName.LabelText = "Shop Name";
            this.ltbShopName.Location = new System.Drawing.Point(3, 13);
            this.ltbShopName.Name = "ltbShopName";
            this.ltbShopName.Size = new System.Drawing.Size(428, 47);
            this.ltbShopName.TabIndex = 1;
            // 
            // ltbAddress
            // 
            this.ltbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbAddress.LabelText = "Address";
            this.ltbAddress.Location = new System.Drawing.Point(3, 66);
            this.ltbAddress.Name = "ltbAddress";
            this.ltbAddress.Size = new System.Drawing.Size(428, 47);
            this.ltbAddress.TabIndex = 2;
            // 
            // ltbPhoneNumber
            // 
            this.ltbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbPhoneNumber.LabelText = "Phone Number";
            this.ltbPhoneNumber.Location = new System.Drawing.Point(3, 119);
            this.ltbPhoneNumber.Name = "ltbPhoneNumber";
            this.ltbPhoneNumber.Size = new System.Drawing.Size(428, 47);
            this.ltbPhoneNumber.TabIndex = 3;
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
            this.tlpContainer.Size = new System.Drawing.Size(450, 174);
            this.tlpContainer.TabIndex = 1;
            // 
            // ShopInformationStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "ShopInformationStep";
            this.Size = new System.Drawing.Size(450, 174);
            this.tlpDetails.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private LabeledTextBox ltbShopName;
        private LabeledTextBox ltbAddress;
        private LabeledTextBox ltbPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
    }
}
