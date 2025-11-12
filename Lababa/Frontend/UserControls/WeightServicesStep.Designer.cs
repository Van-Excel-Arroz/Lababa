namespace Lababa.Frontend.UserControls
{
    partial class WeightServicesStep
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
            this.dgvWeightServiceCatalog = new System.Windows.Forms.DataGridView();
            this.colWeightServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinWeightPerLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemoveImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeightServiceCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.dgvWeightServiceCatalog, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tlpContainer.Size = new System.Drawing.Size(550, 318);
            this.tlpContainer.TabIndex = 0;
            // 
            // dgvWeightServiceCatalog
            // 
            this.dgvWeightServiceCatalog.AllowUserToResizeRows = false;
            this.dgvWeightServiceCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeightServiceCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWeightServiceName,
            this.colPricePerUnit,
            this.colMinWeightPerLoad,
            this.colRemoveImage});
            this.dgvWeightServiceCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeightServiceCatalog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvWeightServiceCatalog.Location = new System.Drawing.Point(3, 3);
            this.dgvWeightServiceCatalog.Name = "dgvWeightServiceCatalog";
            this.dgvWeightServiceCatalog.Size = new System.Drawing.Size(544, 312);
            this.dgvWeightServiceCatalog.TabIndex = 1;
            this.dgvWeightServiceCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeightServices_CellContentClick);
            this.dgvWeightServiceCatalog.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWeightServices_CellFormatting);
            this.dgvWeightServiceCatalog.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeightServices_CellMouseEnter);
            this.dgvWeightServiceCatalog.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeightServices_CellMouseLeave);
            // 
            // colWeightServiceName
            // 
            this.colWeightServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWeightServiceName.DataPropertyName = "ServiceName";
            this.colWeightServiceName.FillWeight = 22.72728F;
            this.colWeightServiceName.HeaderText = "Service Name";
            this.colWeightServiceName.Name = "colWeightServiceName";
            // 
            // colPricePerUnit
            // 
            this.colPricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPricePerUnit.DataPropertyName = "PricePerUnit";
            this.colPricePerUnit.FillWeight = 177.2727F;
            this.colPricePerUnit.HeaderText = "Price/Unit";
            this.colPricePerUnit.Name = "colPricePerUnit";
            this.colPricePerUnit.Width = 80;
            // 
            // colMinWeightPerLoad
            // 
            this.colMinWeightPerLoad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMinWeightPerLoad.DataPropertyName = "MinWeightPerLoad";
            this.colMinWeightPerLoad.HeaderText = "Min Weight";
            this.colMinWeightPerLoad.Name = "colMinWeightPerLoad";
            this.colMinWeightPerLoad.Width = 86;
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
            // WeightServicesStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "WeightServicesStep";
            this.Size = new System.Drawing.Size(550, 318);
            this.Load += new System.EventHandler(this.WeightServicesStep_Load);
            this.tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeightServiceCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.DataGridView dgvWeightServiceCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinWeightPerLoad;
        private System.Windows.Forms.DataGridViewImageColumn colRemoveImage;
    }
}
