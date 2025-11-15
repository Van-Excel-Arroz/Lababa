namespace Lababa.Frontend.UserControls
{
    partial class WeightServicePrintDetail
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
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblLineTotal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblServiceName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 15);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Location = new System.Drawing.Point(279, 1);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(43, 13);
            this.lblLineTotal.TabIndex = 2;
            this.lblLineTotal.Text = "P10000";
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(92, 1);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(35, 13);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "(5 kg)";
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(3, 1);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(83, 13);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Weight Service";
            // 
            // WeightServicePrintDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WeightServicePrintDetail";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Size = new System.Drawing.Size(365, 15);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblLineTotal;
    }
}
