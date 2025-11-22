namespace Lababa.Frontend.UserControls
{
    partial class ItemServicesStep
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
            dgvItemServiceCatalog = new System.Windows.Forms.DataGridView();
            colWeightServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRemoveImage = new System.Windows.Forms.DataGridViewImageColumn();
            tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemServiceCatalog).BeginInit();
            SuspendLayout();
            // 
            // tlpContainer
            // 
            tlpContainer.ColumnCount = 1;
            tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpContainer.Controls.Add(dgvItemServiceCatalog, 0, 0);
            tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpContainer.Location = new System.Drawing.Point(0, 0);
            tlpContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpContainer.Name = "tlpContainer";
            tlpContainer.RowCount = 1;
            tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 456F));
            tlpContainer.Size = new System.Drawing.Size(493, 367);
            tlpContainer.TabIndex = 1;
            // 
            // dgvItemServiceCatalog
            // 
            dgvItemServiceCatalog.AllowUserToResizeRows = false;
            dgvItemServiceCatalog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvItemServiceCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemServiceCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colWeightServiceName, colPricePerUnit, colRemoveImage });
            dgvItemServiceCatalog.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvItemServiceCatalog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            dgvItemServiceCatalog.Location = new System.Drawing.Point(4, 3);
            dgvItemServiceCatalog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvItemServiceCatalog.Name = "dgvItemServiceCatalog";
            dgvItemServiceCatalog.Size = new System.Drawing.Size(485, 361);
            dgvItemServiceCatalog.TabIndex = 1;
            dgvItemServiceCatalog.CellContentClick += dgvWeightServices_CellContentClick;
            dgvItemServiceCatalog.CellFormatting += dgvWeightServices_CellFormatting;
            dgvItemServiceCatalog.CellMouseEnter += dgvWeightServices_CellMouseEnter;
            dgvItemServiceCatalog.CellMouseLeave += dgvWeightServices_CellMouseLeave;
            // 
            // colWeightServiceName
            // 
            colWeightServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colWeightServiceName.DataPropertyName = "ItemName";
            colWeightServiceName.FillWeight = 22.72728F;
            colWeightServiceName.HeaderText = "Item Name";
            colWeightServiceName.Name = "colWeightServiceName";
            // 
            // colPricePerUnit
            // 
            colPricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colPricePerUnit.DataPropertyName = "PricePerPiece";
            colPricePerUnit.FillWeight = 177.2727F;
            colPricePerUnit.HeaderText = "Price/Piece";
            colPricePerUnit.Name = "colPricePerUnit";
            colPricePerUnit.Width = 91;
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
            // ItemServicesStep
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(tlpContainer);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ItemServicesStep";
            Size = new System.Drawing.Size(493, 367);
            Load += WeightServicesStep_Load;
            tlpContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItemServiceCatalog).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.DataGridView dgvItemServiceCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePerUnit;
        private System.Windows.Forms.DataGridViewImageColumn colRemoveImage;
    }
}
