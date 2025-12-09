namespace Lababa.Frontend.UserControls
{
    partial class SettingsControl
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
            tlpContents = new TableLayoutPanel();
            label1 = new Label();
            flpDetails = new FlowLayoutPanel();
            label4 = new Label();
            shopInformationStep = new ShopInformationStep();
            panel1 = new Panel();
            label5 = new Label();
            weightServicesStep = new WeightServicesStep();
            label6 = new Label();
            itemServicesStep = new ItemServicesStep();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnResetData = new Button();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnCancel = new Button();
            btnSaveChanges = new Button();
            tlpContents.SuspendLayout();
            flpDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpContents
            // 
            tlpContents.BackColor = Color.FromArgb(249, 250, 252);
            tlpContents.ColumnCount = 1;
            tlpContents.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpContents.Controls.Add(label1, 0, 0);
            tlpContents.Controls.Add(flpDetails, 0, 1);
            tlpContents.Dock = DockStyle.Fill;
            tlpContents.Location = new Point(25, 10);
            tlpContents.Name = "tlpContents";
            tlpContents.RowCount = 2;
            tlpContents.RowStyles.Add(new RowStyle());
            tlpContents.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpContents.Size = new Size(777, 598);
            tlpContents.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            // 
            // flpDetails
            // 
            flpDetails.Anchor = AnchorStyles.None;
            flpDetails.AutoScroll = true;
            flpDetails.Controls.Add(label4);
            flpDetails.Controls.Add(shopInformationStep);
            flpDetails.Controls.Add(panel1);
            flpDetails.Controls.Add(label5);
            flpDetails.Controls.Add(weightServicesStep);
            flpDetails.Controls.Add(label6);
            flpDetails.Controls.Add(itemServicesStep);
            flpDetails.Controls.Add(panel2);
            flpDetails.Controls.Add(tableLayoutPanel1);
            flpDetails.Controls.Add(panel3);
            flpDetails.Controls.Add(btnCancel);
            flpDetails.Controls.Add(btnSaveChanges);
            flpDetails.Location = new Point(57, 40);
            flpDetails.Name = "flpDetails";
            flpDetails.Padding = new Padding(10, 0, 10, 0);
            flpDetails.Size = new Size(662, 555);
            flpDetails.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 4;
            label4.Text = "Shop Information";
            // 
            // shopInformationStep
            // 
            shopInformationStep.BackColor = Color.FromArgb(249, 250, 252);
            shopInformationStep.Location = new Point(14, 24);
            shopInformationStep.Margin = new Padding(4, 3, 4, 3);
            shopInformationStep.Name = "shopInformationStep";
            shopInformationStep.Size = new Size(618, 372);
            shopInformationStep.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(13, 402);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 1);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 406);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 10);
            label5.Size = new Size(128, 41);
            label5.TabIndex = 6;
            label5.Text = "Weight Services";
            // 
            // weightServicesStep
            // 
            weightServicesStep.AutoScroll = true;
            weightServicesStep.BackColor = Color.White;
            weightServicesStep.Location = new Point(14, 450);
            weightServicesStep.Margin = new Padding(4, 3, 4, 3);
            weightServicesStep.Name = "weightServicesStep";
            weightServicesStep.Size = new Size(618, 318);
            weightServicesStep.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 771);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 10, 0, 10);
            label6.Size = new Size(109, 41);
            label6.TabIndex = 8;
            label6.Text = "Item Services";
            // 
            // itemServicesStep
            // 
            itemServicesStep.BackColor = Color.White;
            itemServicesStep.Location = new Point(14, 815);
            itemServicesStep.Margin = new Padding(4, 3, 4, 3);
            itemServicesStep.Name = "itemServicesStep";
            itemServicesStep.Size = new Size(618, 318);
            itemServicesStep.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(13, 1139);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 1);
            panel2.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnResetData, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(13, 1146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(614, 105);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // btnResetData
            // 
            btnResetData.Anchor = AnchorStyles.Left;
            btnResetData.BackColor = Color.Red;
            btnResetData.Cursor = Cursors.Hand;
            btnResetData.FlatStyle = FlatStyle.Flat;
            btnResetData.ForeColor = Color.White;
            btnResetData.ImageAlign = ContentAlignment.MiddleRight;
            btnResetData.ImageKey = "plus.png";
            btnResetData.Location = new Point(3, 67);
            btnResetData.Name = "btnResetData";
            btnResetData.Size = new Size(110, 30);
            btnResetData.TabIndex = 17;
            btnResetData.Text = "Reset All Data";
            btnResetData.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResetData.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuText;
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(347, 19);
            label3.TabIndex = 10;
            label3.Text = "Reset all data and return to setup wizard. This action cannot be undone.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 10);
            label2.Size = new Size(104, 41);
            label2.TabIndex = 9;
            label2.Text = "Danger Zone";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(13, 1257);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 1);
            panel3.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left;
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.DimGray;
            btnCancel.ImageAlign = ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "plus.png";
            btnCancel.Location = new Point(13, 1264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 30);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Left;
            btnSaveChanges.BackColor = Color.DodgerBlue;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.ImageAlign = ContentAlignment.MiddleRight;
            btnSaveChanges.ImageKey = "plus.png";
            btnSaveChanges.Location = new Point(169, 1264);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(150, 30);
            btnSaveChanges.TabIndex = 19;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 252);
            Controls.Add(tlpContents);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(10);
            Name = "SettingsControl";
            Padding = new Padding(25, 10, 25, 25);
            Size = new Size(827, 633);
            tlpContents.ResumeLayout(false);
            tlpContents.PerformLayout();
            flpDetails.ResumeLayout(false);
            flpDetails.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private WeightServicesStep weightServicesStep;
        private System.Windows.Forms.Label label6;
        private ItemServicesStep itemServicesStep;
        private ShopInformationStep shopInformationStep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}
