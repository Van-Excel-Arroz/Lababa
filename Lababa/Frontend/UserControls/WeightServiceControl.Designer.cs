namespace Lababa.Frontend.UserControls
{
    partial class WeightServiceControl
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
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWeightServiceCatalog = new System.Windows.Forms.ComboBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.pbxRemove = new System.Windows.Forms.PictureBox();
            this.tlpContainer.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.tlpDetails, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.ForeColor = System.Drawing.Color.Black;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(400, 65);
            this.tlpContainer.TabIndex = 0;
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 4;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.88235F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.11765F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpDetails.Controls.Add(this.label2, 2, 0);
            this.tlpDetails.Controls.Add(this.lblWeightUnit, 1, 0);
            this.tlpDetails.Controls.Add(this.label1, 0, 0);
            this.tlpDetails.Controls.Add(this.cmbWeightServiceCatalog, 0, 1);
            this.tlpDetails.Controls.Add(this.nudWeight, 1, 1);
            this.tlpDetails.Controls.Add(this.txtPricePerUnit, 2, 1);
            this.tlpDetails.Controls.Add(this.pbxRemove, 3, 1);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(4, 4);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tlpDetails.RowCount = 2;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.65693F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.34306F));
            this.tlpDetails.Size = new System.Drawing.Size(392, 57);
            this.tlpDetails.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(270, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price/Unit";
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.ForeColor = System.Drawing.Color.DimGray;
            this.lblWeightUnit.Location = new System.Drawing.Point(176, 5);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(79, 13);
            this.lblWeightUnit.TabIndex = 1;
            this.lblWeightUnit.Text = "Kilograms (kg)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wash Type";
            // 
            // cmbWeightServiceCatalog
            // 
            this.cmbWeightServiceCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWeightServiceCatalog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeightServiceCatalog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeightServiceCatalog.FormattingEnabled = true;
            this.cmbWeightServiceCatalog.Location = new System.Drawing.Point(8, 21);
            this.cmbWeightServiceCatalog.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.cmbWeightServiceCatalog.Name = "cmbWeightServiceCatalog";
            this.cmbWeightServiceCatalog.Size = new System.Drawing.Size(155, 25);
            this.cmbWeightServiceCatalog.TabIndex = 3;
            this.cmbWeightServiceCatalog.SelectedValueChanged += new System.EventHandler(this.cmbWeightServiceCatalog_SelectedValueChanged);
            // 
            // nudWeight
            // 
            this.nudWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWeight.Location = new System.Drawing.Point(176, 21);
            this.nudWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(81, 25);
            this.nudWeight.TabIndex = 4;
            this.nudWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.ValueChanged += new System.EventHandler(this.nudWeight_ValueChanged);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPricePerUnit.Enabled = false;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPricePerUnit.Location = new System.Drawing.Point(270, 21);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(78, 25);
            this.txtPricePerUnit.TabIndex = 5;
            this.txtPricePerUnit.Text = "31";
            // 
            // pbxRemove
            // 
            this.pbxRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxRemove.Image = global::Lababa.Properties.Resources.trash_2;
            this.pbxRemove.Location = new System.Drawing.Point(359, 21);
            this.pbxRemove.Name = "pbxRemove";
            this.pbxRemove.Size = new System.Drawing.Size(20, 25);
            this.pbxRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRemove.TabIndex = 6;
            this.pbxRemove.TabStop = false;
            this.pbxRemove.Click += new System.EventHandler(this.pbxRemove_Click);
            // 
            // WeightServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WeightServiceControl";
            this.Size = new System.Drawing.Size(400, 65);
            this.tlpContainer.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRemove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWeightServiceCatalog;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.PictureBox pbxRemove;
    }
}
