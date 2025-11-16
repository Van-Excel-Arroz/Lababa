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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchOrderForm));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpSearchFilters = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerNameOrPhone = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlContainer.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.tlpSearchFilters.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.tlpDetails);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlContainer.Size = new System.Drawing.Size(829, 716);
            this.pnlContainer.TabIndex = 0;
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.lblResult, 0, 3);
            this.tlpDetails.Controls.Add(this.label1, 0, 0);
            this.tlpDetails.Controls.Add(this.tlpSearchFilters, 0, 1);
            this.tlpDetails.Controls.Add(this.panel1, 0, 2);
            this.tlpDetails.Controls.Add(this.dgvOrders, 0, 4);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Location = new System.Drawing.Point(20, 10);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 5;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tlpDetails.Size = new System.Drawing.Size(789, 696);
            this.tlpDetails.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(3, 286);
            this.lblResult.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 21);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Results (5)";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(147, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Orders";
            // 
            // tlpSearchFilters
            // 
            this.tlpSearchFilters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpSearchFilters.ColumnCount = 2;
            this.tlpSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSearchFilters.Controls.Add(this.btnAddCustomer, 0, 3);
            this.tlpSearchFilters.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tlpSearchFilters.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tlpSearchFilters.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tlpSearchFilters.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlpSearchFilters.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tlpSearchFilters.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSearchFilters.Location = new System.Drawing.Point(20, 43);
            this.tlpSearchFilters.Margin = new System.Windows.Forms.Padding(20, 3, 20, 10);
            this.tlpSearchFilters.Name = "tlpSearchFilters";
            this.tlpSearchFilters.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.tlpSearchFilters.RowCount = 4;
            this.tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpSearchFilters.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSearchFilters.Size = new System.Drawing.Size(749, 222);
            this.tlpSearchFilters.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCustomer.ImageKey = "plus.png";
            this.btnAddCustomer.Location = new System.Drawing.Point(20, 177);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(10, 0, 3, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(110, 30);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Search";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cmbPaymentStatus, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(377, 118);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(359, 49);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment Status";
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(8, 21);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(343, 21);
            this.cmbPaymentStatus.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmbOrderStatus, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(13, 118);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(358, 49);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(8, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Order Status";
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Location = new System.Drawing.Point(8, 21);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(342, 21);
            this.cmbOrderStatus.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(377, 63);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(359, 49);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order ID (ORD-XXX)";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 22);
            this.textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomerNameOrPhone, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(358, 49);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Customer Name/Phone";
            // 
            // txtCustomerNameOrPhone
            // 
            this.txtCustomerNameOrPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerNameOrPhone.Location = new System.Drawing.Point(8, 21);
            this.txtCustomerNameOrPhone.Name = "txtCustomerNameOrPhone";
            this.txtCustomerNameOrPhone.Size = new System.Drawing.Size(342, 22);
            this.txtCustomerNameOrPhone.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpToDate, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(377, 8);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 49);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Location = new System.Drawing.Point(8, 21);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(343, 22);
            this.dtpToDate.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFromDate, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.93103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.06897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 49);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Location = new System.Drawing.Point(8, 21);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(342, 22);
            this.dtpFromDate.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 1);
            this.panel1.TabIndex = 4;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colCustomerName,
            this.colPhoneNumber,
            this.colOrderStatus,
            this.colPaymentStatus,
            this.colTotal,
            this.colDateCreated,
            this.colView,
            this.colDelete});
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(20, 320);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(20, 3, 20, 10);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(749, 366);
            this.dgvOrders.TabIndex = 8;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // colOrderId
            // 
            this.colOrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colOrderId.DataPropertyName = "OrderId";
            this.colOrderId.HeaderText = "Order ID";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            this.colOrderId.Width = 76;
            // 
            // colCustomerName
            // 
            this.colCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustomerName.DataPropertyName = "Customer";
            this.colCustomerName.HeaderText = "Customer";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNumber.DataPropertyName = "Phone";
            this.colPhoneNumber.HeaderText = "Phone";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOrderStatus.DataPropertyName = "OrderStatus";
            this.colOrderStatus.FillWeight = 70F;
            this.colOrderStatus.HeaderText = "Order Status";
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.ReadOnly = true;
            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colPaymentStatus.FillWeight = 70F;
            this.colPaymentStatus.HeaderText = "Payment Status";
            this.colPaymentStatus.Name = "colPaymentStatus";
            this.colPaymentStatus.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colDateCreated
            // 
            this.colDateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDateCreated.DataPropertyName = "DateCreated";
            dataGridViewCellStyle3.Format = "f";
            dataGridViewCellStyle3.NullValue = null;
            this.colDateCreated.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDateCreated.HeaderText = "Date Created";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.ReadOnly = true;
            // 
            // colView
            // 
            this.colView.HeaderText = "View";
            this.colView.Image = global::Lababa.Properties.Resources.view;
            this.colView.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colView.Width = 50;
            // 
            // colDelete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.HeaderText = "Delete";
            this.colDelete.Image = global::Lababa.Properties.Resources.trash_2;
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.Width = 50;
            // 
            // SearchOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 716);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Order";
            this.pnlContainer.ResumeLayout(false);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.tlpSearchFilters.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Button btnAddCustomer;
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
    }
}