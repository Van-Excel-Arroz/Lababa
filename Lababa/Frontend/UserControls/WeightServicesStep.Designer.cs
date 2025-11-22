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
            tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            dgvWeightServiceCatalog = new System.Windows.Forms.DataGridView();
            colWeightServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMinWeightPerLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRemoveImage = new System.Windows.Forms.DataGridViewImageColumn();
            tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWeightServiceCatalog).BeginInit();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpContainer.Controls.Add(dgvWeightServiceCatalog, 0, 0);
            tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpContainer.Location = new System.Drawing.Point(0, 0);
            tlpContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RowCount = 1;
            tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            tlpContainer.Size = new System.Drawing.Size(482, 367);
            tlpContainer.TabIndex = 0;
            // 
            // dgvWeightServiceCatalog
            // 
            dgvWeightServiceCatalog.AllowUserToResizeRows = false;
            dgvWeightServiceCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWeightServiceCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colWeightServiceName, colPricePerUnit, colMinWeightPerLoad, colRemoveImage });
            dgvWeightServiceCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvWeightServiceCatalog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            dgvWeightServiceCatalog.Location = new System.Drawing.Point(4, 3);
            dgvWeightServiceCatalog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvWeightServiceCatalog.Name = "dgvWeightServiceCatalog";
            dgvWeightServiceCatalog.Size = new System.Drawing.Size(474, 361);
            dgvWeightServiceCatalog.TabIndex = 1;
            dgvWeightServiceCatalog.CellContentClick += dgvWeightServices_CellContentClick;
            dgvWeightServiceCatalog.CellFormatting += dgvWeightServices_CellFormatting;
            dgvWeightServiceCatalog.CellMouseEnter += dgvWeightServices_CellMouseEnter;
            dgvWeightServiceCatalog.CellMouseLeave += dgvWeightServices_CellMouseLeave;
            // 
            // colWeightServiceName
            // 
            colWeightServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colWeightServiceName.DataPropertyName = "ServiceName";
            colWeightServiceName.FillWeight = 22.72728F;
            colWeightServiceName.HeaderText = "Service Name";
            colWeightServiceName.Name = "colWeightServiceName";
            // 
            // colPricePerUnit
            // 
            colPricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colPricePerUnit.DataPropertyName = "PricePerUnit";
            colPricePerUnit.FillWeight = 177.2727F;
            colPricePerUnit.HeaderText = "Price/Unit";
            colPricePerUnit.Name = "colPricePerUnit";
            colPricePerUnit.Width = 85;
            // 
            // colMinWeightPerLoad
            // 
            colMinWeightPerLoad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colMinWeightPerLoad.DataPropertyName = "MinWeightPerLoad";
            colMinWeightPerLoad.HeaderText = "Min Weight";
            colMinWeightPerLoad.Name = "colMinWeightPerLoad";
            colMinWeightPerLoad.Width = 94;
            // 
            // colRemoveImage
            // 
            colRemoveImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            colRemoveImage.HeaderText = "Remove";
            colRemoveImage.Image = Properties.Resources.trash_2;
            colRemoveImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            colRemoveImage.Name = "colRemoveImage";
            colRemoveImage.Width = 56;
            // 
            // WeightServicesStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.White;
            Controls.Add(tlpContainer);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "WeightServicesStep";
            Size = new System.Drawing.Size(482, 367);
            Load += WeightServicesStep_Load;
            tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWeightServiceCatalog).EndInit();
            ResumeLayout(false);

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
