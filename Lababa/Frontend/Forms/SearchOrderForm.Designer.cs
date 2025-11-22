namespace Lababa.Frontend.Forms
{
    partial class SearchOrderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tlpDetails;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrderForm));
            lblResult = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tlpSearchFilters = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            label7 = new System.Windows.Forms.Label();
            cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            cmbOrderStatus = new System.Windows.Forms.ComboBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            txtOrderNumber = new System.Windows.Forms.TextBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            txtCustomerNameOrPhone = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            dtpToDate = new System.Windows.Forms.DateTimePicker();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            dtpFromDate = new System.Windows.Forms.DateTimePicker();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            btnClear = new System.Windows.Forms.Button();
            btnFilter = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            dgvOrders = new System.Windows.Forms.DataGridView();
            colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colView = new System.Windows.Forms.DataGridViewImageColumn();
            colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            pnlContainer = new System.Windows.Forms.Panel();
            tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            tlpDetails.SuspendLayout();
            tlpSearchFilters.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            pnlContainer.SuspendLayout();
            SuspendLayout();
            // 
            // tlpDetails
            // 
            tlpDetails.ColumnCount = 1;
            tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpDetails.Controls.Add(lblResult, 0, 3);
            tlpDetails.Controls.Add(label1, 0, 0);
            tlpDetails.Controls.Add(tlpSearchFilters, 0, 1);
            tlpDetails.Controls.Add(panel1, 0, 2);
            tlpDetails.Controls.Add(dgvOrders, 0, 4);
            tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpDetails.Location = new System.Drawing.Point(20, 10);
            tlpDetails.Name = "tlpDetails";
            tlpDetails.RowCount = 5;
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            tlpDetails.Size = new System.Drawing.Size(789, 696);
            tlpDetails.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblResult.AutoSize = true;
            lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblResult.Location = new System.Drawing.Point(3, 286);
            lblResult.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(85, 21);
            lblResult.TabIndex = 7;
            lblResult.Text = "Results (5)";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            label1.Size = new System.Drawing.Size(147, 40);
            label1.TabIndex = 2;
            label1.Text = "Search Orders";
            // 
            // tlpSearchFilters
            // 
            tlpSearchFilters.BackColor = System.Drawing.Color.WhiteSmoke;
            tlpSearchFilters.ColumnCount = 2;
            tlpSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpSearchFilters.Controls.Add(tableLayoutPanel6, 1, 2);
            tlpSearchFilters.Controls.Add(tableLayoutPanel5, 0, 2);
            tlpSearchFilters.Controls.Add(tableLayoutPanel4, 1, 1);
            tlpSearchFilters.Controls.Add(tableLayoutPanel3, 0, 1);
            tlpSearchFilters.Controls.Add(tableLayoutPanel2, 1, 0);
            tlpSearchFilters.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpSearchFilters.Controls.Add(tableLayoutPanel7, 0, 3);
            tlpSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpSearchFilters.Location = new System.Drawing.Point(20, 43);
            tlpSearchFilters.Margin = new System.Windows.Forms.Padding(20, 3, 20, 10);
            tlpSearchFilters.Name = "tlpSearchFilters";
            tlpSearchFilters.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            tlpSearchFilters.RowCount = 4;
            tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpSearchFilters.Size = new System.Drawing.Size(749, 222);
            tlpSearchFilters.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(cmbPaymentStatus, 0, 1);
            tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel6.Location = new System.Drawing.Point(377, 118);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new System.Drawing.Size(359, 49);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.SystemColors.ControlText;
            label7.Location = new System.Drawing.Point(8, 5);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 13);
            label7.TabIndex = 0;
            label7.Text = "Payment Status";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new System.Drawing.Point(8, 21);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new System.Drawing.Size(343, 21);
            cmbPaymentStatus.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(cmbOrderStatus, 0, 1);
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel5.Location = new System.Drawing.Point(13, 118);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new System.Drawing.Size(358, 49);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.SystemColors.ControlText;
            label6.Location = new System.Drawing.Point(8, 5);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(66, 13);
            label6.TabIndex = 0;
            label6.Text = "Order Status";
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Location = new System.Drawing.Point(8, 21);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new System.Drawing.Size(342, 21);
            cmbOrderStatus.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(txtOrderNumber, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel4.Location = new System.Drawing.Point(377, 63);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new System.Drawing.Size(359, 49);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(8, 5);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(102, 13);
            label5.TabIndex = 0;
            label5.Text = "Order ID (ORD-XXX)";
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOrderNumber.Location = new System.Drawing.Point(8, 21);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new System.Drawing.Size(343, 22);
            txtOrderNumber.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(txtCustomerNameOrPhone, 0, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(13, 63);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(358, 49);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(8, 5);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 13);
            label4.TabIndex = 0;
            label4.Text = "Customer Name/Phone";
            // 
            // txtCustomerNameOrPhone
            // 
            txtCustomerNameOrPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCustomerNameOrPhone.Location = new System.Drawing.Point(8, 21);
            txtCustomerNameOrPhone.Name = "txtCustomerNameOrPhone";
            txtCustomerNameOrPhone.Size = new System.Drawing.Size(342, 22);
            txtCustomerNameOrPhone.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(dtpToDate, 0, 1);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(377, 8);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(359, 49);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ControlText;
            label3.Location = new System.Drawing.Point(8, 5);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 13);
            label3.TabIndex = 0;
            label3.Text = "To Date";
            // 
            // dtpToDate
            // 
            dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            dtpToDate.Location = new System.Drawing.Point(8, 21);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new System.Drawing.Size(343, 22);
            dtpToDate.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFromDate, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(13, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(358, 49);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(8, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 13);
            label2.TabIndex = 0;
            label2.Text = "From Date";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            dtpFromDate.Location = new System.Drawing.Point(8, 21);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new System.Drawing.Size(342, 22);
            dtpFromDate.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.75419F));
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.24581F));
            tableLayoutPanel7.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel7.Controls.Add(btnFilter, 1, 0);
            tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel7.Location = new System.Drawing.Point(13, 173);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new System.Drawing.Size(358, 41);
            tableLayoutPanel7.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnClear.BackColor = System.Drawing.Color.White;
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.ForeColor = System.Drawing.Color.DimGray;
            btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClear.ImageKey = "plus.png";
            btnClear.Location = new System.Drawing.Point(10, 4);
            btnClear.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(110, 30);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnFilter
            // 
            btnFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnFilter.BackColor = System.Drawing.Color.DodgerBlue;
            btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFilter.ForeColor = System.Drawing.Color.White;
            btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnFilter.ImageKey = "plus.png";
            btnFilter.Location = new System.Drawing.Point(137, 4);
            btnFilter.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(110, 30);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 278);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(783, 1);
            panel1.TabIndex = 4;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colOrderId, colCustomerName, colPhoneNumber, colOrderStatus, colPaymentStatus, colTotal, colDateCreated, colView, colDelete });
            dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvOrders.Location = new System.Drawing.Point(20, 320);
            dgvOrders.Margin = new System.Windows.Forms.Padding(20, 3, 20, 10);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.Size = new System.Drawing.Size(749, 366);
            dgvOrders.TabIndex = 8;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick;
            // 
            // colOrderId
            // 
            colOrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            colOrderId.DataPropertyName = "OrderId";
            colOrderId.HeaderText = "Order ID";
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            colOrderId.Width = 70;
            // 
            // colCustomerName
            // 
            colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colCustomerName.DataPropertyName = "Customer";
            colCustomerName.HeaderText = "Customer";
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colPhoneNumber.DataPropertyName = "Phone";
            colPhoneNumber.HeaderText = "Phone";
            colPhoneNumber.Name = "colPhoneNumber";
            colPhoneNumber.ReadOnly = true;
            // 
            // colOrderStatus
            // 
            colOrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colOrderStatus.DataPropertyName = "OrderStatus";
            colOrderStatus.FillWeight = 70F;
            colOrderStatus.HeaderText = "Order Status";
            colOrderStatus.Name = "colOrderStatus";
            colOrderStatus.ReadOnly = true;
            // 
            // colPaymentStatus
            // 
            colPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colPaymentStatus.DataPropertyName = "PaymentStatus";
            colPaymentStatus.FillWeight = 70F;
            colPaymentStatus.HeaderText = "Payment Status";
            colPaymentStatus.Name = "colPaymentStatus";
            colPaymentStatus.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colTotal.DataPropertyName = "Total";
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colDateCreated
            // 
            colDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colDateCreated.DataPropertyName = "DateCreated";
            dataGridViewCellStyle1.Format = "f";
            dataGridViewCellStyle1.NullValue = null;
            colDateCreated.DefaultCellStyle = dataGridViewCellStyle1;
            colDateCreated.HeaderText = "Date Created";
            colDateCreated.Name = "colDateCreated";
            colDateCreated.ReadOnly = true;
            // 
            // colView
            // 
            colView.HeaderText = "View";
            colView.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            colView.Width = 50;
            // 
            // colDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            colDelete.HeaderText = "Delete";
            colDelete.Image = Properties.Resources.trash_2;
            colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            colDelete.Width = 50;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(tlpDetails);
            pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContainer.Location = new System.Drawing.Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            pnlContainer.Size = new System.Drawing.Size(829, 716);
            pnlContainer.TabIndex = 0;
            // 
            // SearchOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(829, 716);
            Controls.Add(pnlContainer);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SearchOrderForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Search Order";
            tlpDetails.ResumeLayout(false);
            tlpDetails.PerformLayout();
            tlpSearchFilters.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            pnlContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpSearchFilters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerNameOrPhone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateCreated;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnClear;
    }
}