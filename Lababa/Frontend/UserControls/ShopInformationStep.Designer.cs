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
            this.label1 = new System.Windows.Forms.Label();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ltbShopName = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.ltbAddress = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.ltbPhoneNumber = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.btnBackNext = new Lababa.Frontend.UserControls.BackNextButtons();
            this.tlpDetails.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.label1, 0, 0);
            this.tlpDetails.Controls.Add(this.ltbShopName, 0, 1);
            this.tlpDetails.Controls.Add(this.ltbAddress, 0, 2);
            this.tlpDetails.Controls.Add(this.ltbPhoneNumber, 0, 3);
            this.tlpDetails.Controls.Add(this.btnBackNext, 0, 4);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(4, 4);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.tlpDetails.RowCount = 5;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.Size = new System.Drawing.Size(442, 292);
            this.tlpDetails.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(224, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 of 4: Shop Information";
            // 
            // tlpContainer
            // 
            this.tlpContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.tlpDetails, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(450, 300);
            this.tlpContainer.TabIndex = 1;
            // 
            // ltbShopName
            // 
            this.ltbShopName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbShopName.LabelText = "Shop Name";
            this.ltbShopName.Location = new System.Drawing.Point(13, 54);
            this.ltbShopName.Name = "ltbShopName";
            this.ltbShopName.Size = new System.Drawing.Size(416, 47);
            this.ltbShopName.TabIndex = 1;
            // 
            // ltbAddress
            // 
            this.ltbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbAddress.LabelText = "Address";
            this.ltbAddress.Location = new System.Drawing.Point(13, 107);
            this.ltbAddress.Name = "ltbAddress";
            this.ltbAddress.Size = new System.Drawing.Size(416, 47);
            this.ltbAddress.TabIndex = 2;
            // 
            // ltbPhoneNumber
            // 
            this.ltbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbPhoneNumber.LabelText = "Phone Number";
            this.ltbPhoneNumber.Location = new System.Drawing.Point(13, 160);
            this.ltbPhoneNumber.Name = "ltbPhoneNumber";
            this.ltbPhoneNumber.Size = new System.Drawing.Size(416, 47);
            this.ltbPhoneNumber.TabIndex = 3;
            // 
            // btnBackNext
            // 
            this.btnBackNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackNext.Location = new System.Drawing.Point(13, 224);
            this.btnBackNext.Name = "btnBackNext";
            this.btnBackNext.Size = new System.Drawing.Size(416, 54);
            this.btnBackNext.TabIndex = 4;
            // 
            // ShopInformationStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "ShopInformationStep";
            this.Size = new System.Drawing.Size(450, 300);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Label label1;
        private LabeledTextBox ltbShopName;
        private LabeledTextBox ltbAddress;
        private LabeledTextBox ltbPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private BackNextButtons btnBackNext;
    }
}
