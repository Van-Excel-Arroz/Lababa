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
            tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            txtShopName = new LabeledTextBox();
            txtAddress = new LabeledTextBox();
            txtPhoneNumber = new LabeledTextBox();
            txtReceiptMessage = new LabeledTextBox();
            tlpDefaultWeightUnit = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            rdoKilograms = new System.Windows.Forms.RadioButton();
            rdoPounds = new System.Windows.Forms.RadioButton();
            tlpCurrencySymbol = new System.Windows.Forms.TableLayoutPanel();
            cmbCurrcencySymbol = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            tlpDetails.SuspendLayout();
            tlpDefaultWeightUnit.SuspendLayout();
            tlpCurrencySymbol.SuspendLayout();
            tlpContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tlpDetails
            // 
            tlpDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tlpDetails.ColumnCount = 1;
            tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpDetails.Controls.Add(txtShopName, 0, 0);
            tlpDetails.Controls.Add(txtAddress, 0, 1);
            tlpDetails.Controls.Add(txtPhoneNumber, 0, 2);
            tlpDetails.Controls.Add(txtReceiptMessage, 0, 3);
            tlpDetails.Controls.Add(tlpDefaultWeightUnit, 0, 4);
            tlpDetails.Controls.Add(tlpCurrencySymbol, 0, 5);
            tlpDetails.Location = new System.Drawing.Point(4, 3);
            tlpDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpDetails.Name = "tlpDetails";
            tlpDetails.Padding = new System.Windows.Forms.Padding(12);
            tlpDetails.RowCount = 6;
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpDetails.Size = new System.Drawing.Size(415, 365);
            tlpDetails.TabIndex = 0;
            // 
            // txtShopName
            // 
            txtShopName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtShopName.LabelText = "Shop Name";
            txtShopName.Location = new System.Drawing.Point(17, 15);
            txtShopName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new System.Drawing.Size(381, 54);
            txtShopName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAddress.LabelText = "Address (Optional)";
            txtAddress.Location = new System.Drawing.Point(17, 75);
            txtAddress.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(381, 54);
            txtAddress.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            txtPhoneNumber.LabelText = "Phone Number (Optional)";
            txtPhoneNumber.Location = new System.Drawing.Point(17, 135);
            txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(381, 54);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtReceiptMessage
            // 
            txtReceiptMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            txtReceiptMessage.LabelText = "Receipt Message";
            txtReceiptMessage.Location = new System.Drawing.Point(17, 195);
            txtReceiptMessage.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            txtReceiptMessage.Name = "txtReceiptMessage";
            txtReceiptMessage.Size = new System.Drawing.Size(381, 61);
            txtReceiptMessage.TabIndex = 4;
            // 
            // tlpDefaultWeightUnit
            // 
            tlpDefaultWeightUnit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            tlpDefaultWeightUnit.ColumnCount = 3;
            tlpDefaultWeightUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpDefaultWeightUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpDefaultWeightUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpDefaultWeightUnit.Controls.Add(label1, 0, 0);
            tlpDefaultWeightUnit.Controls.Add(rdoKilograms, 1, 0);
            tlpDefaultWeightUnit.Controls.Add(rdoPounds, 2, 0);
            tlpDefaultWeightUnit.Location = new System.Drawing.Point(16, 270);
            tlpDefaultWeightUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpDefaultWeightUnit.Name = "tlpDefaultWeightUnit";
            tlpDefaultWeightUnit.RowCount = 1;
            tlpDefaultWeightUnit.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDefaultWeightUnit.Size = new System.Drawing.Size(355, 27);
            tlpDefaultWeightUnit.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(4, 7);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 13);
            label1.TabIndex = 2;
            label1.Text = "Default Weight Unit: ";
            // 
            // rdoKilograms
            // 
            rdoKilograms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            rdoKilograms.AutoSize = true;
            rdoKilograms.Checked = true;
            rdoKilograms.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rdoKilograms.Location = new System.Drawing.Point(126, 5);
            rdoKilograms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoKilograms.Name = "rdoKilograms";
            rdoKilograms.Size = new System.Drawing.Size(90, 17);
            rdoKilograms.TabIndex = 3;
            rdoKilograms.TabStop = true;
            rdoKilograms.Text = "Kilograms (kg)";
            rdoKilograms.UseVisualStyleBackColor = true;
            // 
            // rdoPounds
            // 
            rdoPounds.Anchor = System.Windows.Forms.AnchorStyles.Left;
            rdoPounds.AutoSize = true;
            rdoPounds.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rdoPounds.Location = new System.Drawing.Point(224, 5);
            rdoPounds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rdoPounds.Name = "rdoPounds";
            rdoPounds.Size = new System.Drawing.Size(80, 17);
            rdoPounds.TabIndex = 4;
            rdoPounds.Text = "Pounds (lbs)";
            rdoPounds.UseVisualStyleBackColor = true;
            // 
            // tlpCurrencySymbol
            // 
            tlpCurrencySymbol.ColumnCount = 2;
            tlpCurrencySymbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpCurrencySymbol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCurrencySymbol.Controls.Add(cmbCurrcencySymbol, 1, 0);
            tlpCurrencySymbol.Controls.Add(label2, 0, 0);
            tlpCurrencySymbol.Location = new System.Drawing.Point(16, 312);
            tlpCurrencySymbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpCurrencySymbol.Name = "tlpCurrencySymbol";
            tlpCurrencySymbol.RowCount = 1;
            tlpCurrencySymbol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpCurrencySymbol.Size = new System.Drawing.Size(246, 35);
            tlpCurrencySymbol.TabIndex = 5;
            // 
            // cmbCurrcencySymbol
            // 
            cmbCurrcencySymbol.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbCurrcencySymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCurrcencySymbol.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbCurrcencySymbol.FormattingEnabled = true;
            cmbCurrcencySymbol.Items.AddRange(new object[] { "$", "€", "£", "¥", "₹", "₱" });
            cmbCurrcencySymbol.Location = new System.Drawing.Point(111, 6);
            cmbCurrcencySymbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbCurrcencySymbol.Name = "cmbCurrcencySymbol";
            cmbCurrcencySymbol.Size = new System.Drawing.Size(131, 22);
            cmbCurrcencySymbol.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(4, 11);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 13);
            label2.TabIndex = 1;
            label2.Text = "Currency Symbol: ";
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpContainer.Controls.Add(tlpDetails, 0, 0);
            tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpContainer.Location = new System.Drawing.Point(0, 0);
            tlpContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RowCount = 1;
            tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlpContainer.Size = new System.Drawing.Size(423, 402);
            tlpContainer.TabIndex = 1;
            // 
            // ShopInformationStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(tlpContainer);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ShopInformationStep";
            Size = new System.Drawing.Size(423, 402);
            Load += ShopInformationStep_Load;
            tlpDetails.ResumeLayout(false);
            tlpDefaultWeightUnit.ResumeLayout(false);
            tlpDefaultWeightUnit.PerformLayout();
            tlpCurrencySymbol.ResumeLayout(false);
            tlpCurrencySymbol.PerformLayout();
            tlpContainer.ResumeLayout(false);
            ResumeLayout(false);

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
