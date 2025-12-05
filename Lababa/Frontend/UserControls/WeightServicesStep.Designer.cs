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
            tlpContainer = new TableLayoutPanel();
            dgvWeightServiceCatalog = new DataGridView();
            colWeightServiceName = new DataGridViewTextBoxColumn();
            colPricePerUnit = new DataGridViewTextBoxColumn();
            colRemoveImage = new DataGridViewImageColumn();
            tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeightServiceCatalog).BeginInit();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpContainer.Controls.Add(dgvWeightServiceCatalog, 0, 0);
            tlpContainer.Dock = DockStyle.Fill;
            tlpContainer.Location = new Point(0, 0);
            tlpContainer.Margin = new Padding(4, 3, 4, 3);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RowCount = 1;
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 456F));
            tlpContainer.Size = new Size(482, 367);
            tlpContainer.TabIndex = 0;
            // 
            // dgvWeightServiceCatalog
            // 
            dgvWeightServiceCatalog.AllowUserToResizeRows = false;
            dgvWeightServiceCatalog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeightServiceCatalog.Columns.AddRange(new DataGridViewColumn[] { colWeightServiceName, colPricePerUnit, colRemoveImage });
            dgvWeightServiceCatalog.Dock = DockStyle.Fill;
            dgvWeightServiceCatalog.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvWeightServiceCatalog.Location = new Point(4, 3);
            dgvWeightServiceCatalog.Margin = new Padding(4, 3, 4, 3);
            dgvWeightServiceCatalog.Name = "dgvWeightServiceCatalog";
            dgvWeightServiceCatalog.Size = new Size(474, 361);
            dgvWeightServiceCatalog.TabIndex = 1;
            dgvWeightServiceCatalog.CellContentClick += dgvWeightServices_CellContentClick;
            dgvWeightServiceCatalog.CellFormatting += dgvWeightServices_CellFormatting;
            dgvWeightServiceCatalog.CellMouseEnter += dgvWeightServices_CellMouseEnter;
            dgvWeightServiceCatalog.CellMouseLeave += dgvWeightServices_CellMouseLeave;
            // 
            // colWeightServiceName
            // 
            colWeightServiceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colWeightServiceName.DataPropertyName = "ServiceName";
            colWeightServiceName.FillWeight = 22.72728F;
            colWeightServiceName.HeaderText = "Service Name";
            colWeightServiceName.Name = "colWeightServiceName";
            // 
            // colPricePerUnit
            // 
            colPricePerUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colPricePerUnit.DataPropertyName = "PricePerUnit";
            colPricePerUnit.FillWeight = 177.2727F;
            colPricePerUnit.HeaderText = "Price/Unit";
            colPricePerUnit.Name = "colPricePerUnit";
            colPricePerUnit.Width = 85;
            // 
            // colRemoveImage
            // 
            colRemoveImage.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colRemoveImage.HeaderText = "Remove";
            colRemoveImage.Image = Properties.Resources.trash_2;
            colRemoveImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colRemoveImage.Name = "colRemoveImage";
            colRemoveImage.Width = 56;
            // 
            // WeightServicesStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(tlpContainer);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WeightServicesStep";
            Size = new Size(482, 367);
            Load += WeightServicesStep_Load;
            tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWeightServiceCatalog).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.DataGridView dgvWeightServiceCatalog;
        private DataGridViewTextBoxColumn colWeightServiceName;
        private DataGridViewTextBoxColumn colPricePerUnit;
        private DataGridViewImageColumn colRemoveImage;
    }
}
