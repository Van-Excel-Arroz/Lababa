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
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.txtShopName = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.txtAddress = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.txtPhoneNumber = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.txtReceiptMessage = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.tlpCurrencySymbol = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurrcencySymbol = new System.Windows.Forms.ComboBox();
            this.tlpDefaultWeightUnit = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoKilograms = new System.Windows.Forms.RadioButton();
            this.rdoPounds = new System.Windows.Forms.RadioButton();
            this.tlpDetails.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.tlpCurrencySymbol.SuspendLayout();
            this.tlpDefaultWeightUnit.SuspendLayout();
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
            this.tlpDetails.Controls.Add(this.txtReceiptMessage, 0, 3);
            this.tlpDetails.Controls.Add(this.tlpDefaultWeightUnit, 0, 4);
            this.tlpDetails.Controls.Add(this.tlpCurrencySymbol, 0, 5);
            this.tlpDetails.Location = new System.Drawing.Point(3, 3);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(10);
            this.tlpDetails.RowCount = 6;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDetails.Size = new System.Drawing.Size(530, 316);
            this.tlpDetails.TabIndex = 0;
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
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainer.Size = new System.Drawing.Size(536, 348);
            this.tlpContainer.TabIndex = 1;
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
            // txtReceiptMessage
            // 
            this.txtReceiptMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiptMessage.LabelText = "Receipt Message";
            this.txtReceiptMessage.Location = new System.Drawing.Point(13, 172);
            this.txtReceiptMessage.Name = "txtReceiptMessage";
            this.txtReceiptMessage.Size = new System.Drawing.Size(504, 52);
            this.txtReceiptMessage.TabIndex = 4;
            // 
            // tlpCurrencySymbol
            // 
            this.tlpCurrencySymbol.ColumnCount = 2;
            this.tlpCurrencySymbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrencySymbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrencySymbol.Controls.Add(this.cmbCurrcencySymbol, 1, 0);
            this.tlpCurrencySymbol.Controls.Add(this.label2, 0, 0);
            this.tlpCurrencySymbol.Location = new System.Drawing.Point(13, 273);
            this.tlpCurrencySymbol.Name = "tlpCurrencySymbol";
            this.tlpCurrencySymbol.RowCount = 1;
            this.tlpCurrencySymbol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrencySymbol.Size = new System.Drawing.Size(211, 30);
            this.tlpCurrencySymbol.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency Symbol: ";
            // 
            // cmbCurrcencySymbol
            // 
            this.cmbCurrcencySymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurrcencySymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrcencySymbol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrcencySymbol.FormattingEnabled = true;
            this.cmbCurrcencySymbol.Items.AddRange(new object[] {
            "$",
            "€",
            "£",
            "¥",
            "₹",
            "₱"});
            this.cmbCurrcencySymbol.Location = new System.Drawing.Point(108, 4);
            this.cmbCurrcencySymbol.Name = "cmbCurrcencySymbol";
            this.cmbCurrcencySymbol.Size = new System.Drawing.Size(100, 22);
            this.cmbCurrcencySymbol.TabIndex = 2;
            // 
            // tlpDefaultWeightUnit
            // 
            this.tlpDefaultWeightUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpDefaultWeightUnit.ColumnCount = 3;
            this.tlpDefaultWeightUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDefaultWeightUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDefaultWeightUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDefaultWeightUnit.Controls.Add(this.label1, 0, 0);
            this.tlpDefaultWeightUnit.Controls.Add(this.rdoKilograms, 1, 0);
            this.tlpDefaultWeightUnit.Controls.Add(this.rdoPounds, 2, 0);
            this.tlpDefaultWeightUnit.Location = new System.Drawing.Point(13, 237);
            this.tlpDefaultWeightUnit.Name = "tlpDefaultWeightUnit";
            this.tlpDefaultWeightUnit.RowCount = 1;
            this.tlpDefaultWeightUnit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDefaultWeightUnit.Size = new System.Drawing.Size(304, 23);
            this.tlpDefaultWeightUnit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Weight Unit: ";
            // 
            // rdoKilograms
            // 
            this.rdoKilograms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoKilograms.AutoSize = true;
            this.rdoKilograms.Checked = true;
            this.rdoKilograms.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKilograms.Location = new System.Drawing.Point(123, 3);
            this.rdoKilograms.Name = "rdoKilograms";
            this.rdoKilograms.Size = new System.Drawing.Size(90, 17);
            this.rdoKilograms.TabIndex = 3;
            this.rdoKilograms.TabStop = true;
            this.rdoKilograms.Text = "Kilograms (kg)";
            this.rdoKilograms.UseVisualStyleBackColor = true;
            // 
            // rdoPounds
            // 
            this.rdoPounds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoPounds.AutoSize = true;
            this.rdoPounds.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPounds.Location = new System.Drawing.Point(219, 3);
            this.rdoPounds.Name = "rdoPounds";
            this.rdoPounds.Size = new System.Drawing.Size(80, 17);
            this.rdoPounds.TabIndex = 4;
            this.rdoPounds.Text = "Pounds (lbs)";
            this.rdoPounds.UseVisualStyleBackColor = true;
            // 
            // ShopInformationStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "ShopInformationStep";
            this.Size = new System.Drawing.Size(536, 348);
            this.Load += new System.EventHandler(this.ShopInformationStep_Load);
            this.tlpDetails.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.tlpCurrencySymbol.ResumeLayout(false);
            this.tlpCurrencySymbol.PerformLayout();
            this.tlpDefaultWeightUnit.ResumeLayout(false);
            this.tlpDefaultWeightUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private LabeledTextBox txtShopName;
        private LabeledTextBox txtAddress;
        private LabeledTextBox txtPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private LabeledTextBox txtReceiptMessage;
        private System.Windows.Forms.TableLayoutPanel tlpCurrencySymbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurrcencySymbol;
        private System.Windows.Forms.TableLayoutPanel tlpDefaultWeightUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoKilograms;
        private System.Windows.Forms.RadioButton rdoPounds;
    }
}
