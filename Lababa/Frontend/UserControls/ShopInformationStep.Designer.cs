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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbShopName = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.ltbAddress = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.ltbPhoneNumber = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ltbShopName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ltbAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ltbPhoneNumber, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.6341F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1 of 4: Shop Information";
            // 
            // ltbShopName
            // 
            this.ltbShopName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbShopName.LabelText = "Shop Name";
            this.ltbShopName.Location = new System.Drawing.Point(13, 66);
            this.ltbShopName.Name = "ltbShopName";
            this.ltbShopName.Size = new System.Drawing.Size(416, 47);
            this.ltbShopName.TabIndex = 1;
            // 
            // ltbAddress
            // 
            this.ltbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbAddress.LabelText = "Address";
            this.ltbAddress.Location = new System.Drawing.Point(13, 119);
            this.ltbAddress.Name = "ltbAddress";
            this.ltbAddress.Size = new System.Drawing.Size(416, 47);
            this.ltbAddress.TabIndex = 2;
            // 
            // ltbPhoneNumber
            // 
            this.ltbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbPhoneNumber.LabelText = "Phone Number";
            this.ltbPhoneNumber.Location = new System.Drawing.Point(13, 172);
            this.ltbPhoneNumber.Name = "ltbPhoneNumber";
            this.ltbPhoneNumber.Size = new System.Drawing.Size(416, 47);
            this.ltbPhoneNumber.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ShopInformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ShopInformationControl";
            this.Size = new System.Drawing.Size(450, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private LabeledTextBox ltbShopName;
        private LabeledTextBox ltbAddress;
        private LabeledTextBox ltbPhoneNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
