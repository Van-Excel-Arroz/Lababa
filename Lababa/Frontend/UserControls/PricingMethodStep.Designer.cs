namespace Lababa.Frontend.UserControls
{
    partial class PricingMethodStep
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
            this.dgvWeightServices = new System.Windows.Forms.DataGridView();
            this.colWeightServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePerWeightUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinWeightPerLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeightServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.dgvWeightServices, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tlpContainer.Size = new System.Drawing.Size(550, 318);
            this.tlpContainer.TabIndex = 0;
            // 
            // dgvWeightServices
            // 
            this.dgvWeightServices.AllowUserToResizeRows = false;
            this.dgvWeightServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeightServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWeightServiceName,
            this.colPricePerWeightUnit,
            this.colMinWeightPerLoad,
            this.colRemoveImage});
            this.dgvWeightServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeightServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvWeightServices.Location = new System.Drawing.Point(3, 3);
            this.dgvWeightServices.Name = "dgvWeightServices";
            this.dgvWeightServices.Size = new System.Drawing.Size(544, 312);
            this.dgvWeightServices.TabIndex = 1;
            // 
            // colWeightServiceName
            // 
            this.colWeightServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWeightServiceName.HeaderText = "Service Name";
            this.colWeightServiceName.Name = "colWeightServiceName";
            // 
            // colPricePerWeightUnit
            // 
            this.colPricePerWeightUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPricePerWeightUnit.HeaderText = "Price/Unit";
            this.colPricePerWeightUnit.Name = "colPricePerWeightUnit";
            // 
            // colMinWeightPerLoad
            // 
            this.colMinWeightPerLoad.HeaderText = "Min Weight";
            this.colMinWeightPerLoad.Name = "colMinWeightPerLoad";
            // 
            // colRemoveImage
            // 
            this.colRemoveImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRemoveImage.HeaderText = "Remove";
            this.colRemoveImage.Image = global::Lababa.Properties.Resources.trash_2;
            this.colRemoveImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colRemoveImage.Name = "colRemoveImage";
            this.colRemoveImage.Width = 53;
            // 
            // PricingMethodStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "PricingMethodStep";
            this.Size = new System.Drawing.Size(550, 318);
            this.tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeightServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.DataGridView dgvWeightServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerWeightUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinWeightPerLoad;
        private System.Windows.Forms.DataGridViewImageColumn colRemoveImage;
    }
}
