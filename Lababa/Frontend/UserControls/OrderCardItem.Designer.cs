namespace Lababa.Frontend.UserControls
{
    partial class OrderCardItem
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
            this.components = new System.ComponentModel.Container();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.cmsRightClickOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.changeStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPending = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReady = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompleted = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancelled = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefunded = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.paidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePaymentStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpContainer.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.cmsRightClickOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.tlpDetails, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(221, 88);
            this.tlpContainer.TabIndex = 0;
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 2;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.54922F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.45078F));
            this.tlpDetails.Controls.Add(this.lblTotalAmount, 1, 2);
            this.tlpDetails.Controls.Add(this.lblDueDate, 0, 2);
            this.tlpDetails.Controls.Add(this.lblCustomerName, 0, 1);
            this.tlpDetails.Controls.Add(this.lblPaymentStatus, 1, 0);
            this.tlpDetails.Controls.Add(this.lblOrderNumber, 0, 0);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(4, 4);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tlpDetails.RowCount = 3;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.25F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.40741F));
            this.tlpDetails.Size = new System.Drawing.Size(213, 80);
            this.tlpDetails.TabIndex = 0;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(153, 60);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(47, 13);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "₱67,000";
            // 
            // lblDueDate
            // 
            this.lblDueDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(13, 60);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(39, 13);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "Sep 23";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCustomerName.AutoEllipsis = true;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(13, 37);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(73, 15);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Pedro Garcia";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(215)))), ((int)(((byte)(213)))));
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPaymentStatus.Location = new System.Drawing.Point(128, 8);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Padding = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.lblPaymentStatus.Size = new System.Drawing.Size(72, 19);
            this.lblPaymentStatus.TabIndex = 1;
            this.lblPaymentStatus.Text = "Refunded";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(13, 7);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(77, 21);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Ord-0001";
            // 
            // cmsRightClickOptions
            // 
            this.cmsRightClickOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiViewDetails,
            this.changeStatusToolStripMenuItem,
            this.paymentStatusToolStripMenuItem,
            this.tsmiPrint,
            this.tsmiDelete});
            this.cmsRightClickOptions.Name = "cmsRightClickOptions";
            this.cmsRightClickOptions.Size = new System.Drawing.Size(157, 114);
            // 
            // tsmiViewDetails
            // 
            this.tsmiViewDetails.Name = "tsmiViewDetails";
            this.tsmiViewDetails.Size = new System.Drawing.Size(156, 22);
            this.tsmiViewDetails.Text = "View Details";
            this.tsmiViewDetails.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // changeStatusToolStripMenuItem
            // 
            this.changeStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPending,
            this.tsmiInProgress,
            this.tsmiReady,
            this.tsmiCompleted,
            this.tsmiCancelled});
            this.changeStatusToolStripMenuItem.Name = "changeStatusToolStripMenuItem";
            this.changeStatusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.changeStatusToolStripMenuItem.Text = "Order Status";
            // 
            // tsmiPending
            // 
            this.tsmiPending.Name = "tsmiPending";
            this.tsmiPending.Size = new System.Drawing.Size(180, 22);
            this.tsmiPending.Text = "Pending";
            // 
            // tsmiInProgress
            // 
            this.tsmiInProgress.Name = "tsmiInProgress";
            this.tsmiInProgress.Size = new System.Drawing.Size(180, 22);
            this.tsmiInProgress.Text = "In Progress";
            // 
            // tsmiReady
            // 
            this.tsmiReady.Name = "tsmiReady";
            this.tsmiReady.Size = new System.Drawing.Size(180, 22);
            this.tsmiReady.Text = "Ready";
            // 
            // tsmiCompleted
            // 
            this.tsmiCompleted.Name = "tsmiCompleted";
            this.tsmiCompleted.Size = new System.Drawing.Size(180, 22);
            this.tsmiCompleted.Text = "Completed";
            // 
            // tsmiCancelled
            // 
            this.tsmiCancelled.Name = "tsmiCancelled";
            this.tsmiCancelled.Size = new System.Drawing.Size(180, 22);
            this.tsmiCancelled.Text = "Cancelled";
            // 
            // paymentStatusToolStripMenuItem
            // 
            this.paymentStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPaid,
            this.tsmiUnpaid,
            this.tsmiRefunded});
            this.paymentStatusToolStripMenuItem.Name = "paymentStatusToolStripMenuItem";
            this.paymentStatusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paymentStatusToolStripMenuItem.Text = "Payment Status";
            // 
            // tsmiPaid
            // 
            this.tsmiPaid.Name = "tsmiPaid";
            this.tsmiPaid.Size = new System.Drawing.Size(180, 22);
            this.tsmiPaid.Text = "Paid";
            this.tsmiPaid.Click += new System.EventHandler(this.tsmiPaid_Click);
            // 
            // tsmiUnpaid
            // 
            this.tsmiUnpaid.Name = "tsmiUnpaid";
            this.tsmiUnpaid.Size = new System.Drawing.Size(180, 22);
            this.tsmiUnpaid.Text = "Unpaid";
            this.tsmiUnpaid.Click += new System.EventHandler(this.tsmiUnpaid_Click);
            // 
            // tsmiRefunded
            // 
            this.tsmiRefunded.Name = "tsmiRefunded";
            this.tsmiRefunded.Size = new System.Drawing.Size(180, 22);
            this.tsmiRefunded.Text = "Refunded";
            this.tsmiRefunded.Click += new System.EventHandler(this.tsmiRefunded_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Image = global::Lababa.Properties.Resources.print_2;
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(156, 22);
            this.tsmiPrint.Text = "Print";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::Lababa.Properties.Resources.trash_2;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // paidToolStripMenuItem
            // 
            this.paidToolStripMenuItem.Checked = true;
            this.paidToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.paidToolStripMenuItem.Name = "paidToolStripMenuItem";
            this.paidToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.paidToolStripMenuItem.Text = "Paid";
            // 
            // unpaidToolStripMenuItem
            // 
            this.unpaidToolStripMenuItem.Name = "unpaidToolStripMenuItem";
            this.unpaidToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.unpaidToolStripMenuItem.Text = "Unpaid";
            // 
            // refundedToolStripMenuItem
            // 
            this.refundedToolStripMenuItem.Name = "refundedToolStripMenuItem";
            this.refundedToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.refundedToolStripMenuItem.Text = "Refunded";
            // 
            // changePaymentStatusToolStripMenuItem
            // 
            this.changePaymentStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paidToolStripMenuItem,
            this.unpaidToolStripMenuItem,
            this.refundedToolStripMenuItem});
            this.changePaymentStatusToolStripMenuItem.Name = "changePaymentStatusToolStripMenuItem";
            this.changePaymentStatusToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.changePaymentStatusToolStripMenuItem.Text = "Payment Status";
            // 
            // OrderCardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmsRightClickOptions;
            this.Controls.Add(this.tlpContainer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderCardItem";
            this.Size = new System.Drawing.Size(221, 88);
            this.Load += new System.EventHandler(this.OrderCardItem_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OrderCardItem_MouseDoubleClick);
            this.tlpContainer.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.cmsRightClickOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ContextMenuStrip cmsRightClickOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewDetails;
        private System.Windows.Forms.ToolStripMenuItem changeStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPending;
        private System.Windows.Forms.ToolStripMenuItem tsmiInProgress;
        private System.Windows.Forms.ToolStripMenuItem tsmiReady;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompleted;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancelled;
        private System.Windows.Forms.ToolStripMenuItem paymentStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaid;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnpaid;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefunded;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem paidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refundedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePaymentStatusToolStripMenuItem;
    }
}
