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
            tlpContents = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            flpDetails = new System.Windows.Forms.FlowLayoutPanel();
            label4 = new System.Windows.Forms.Label();
            shopInformationStep = new ShopInformationStep();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            weightServicesStep = new WeightServicesStep();
            label6 = new System.Windows.Forms.Label();
            itemServicesStep = new ItemServicesStep();
            panel2 = new System.Windows.Forms.Panel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            btnResetData = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnCancel = new System.Windows.Forms.Button();
            btnSaveChanges = new System.Windows.Forms.Button();
            tlpContents.SuspendLayout();
            flpDetails.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpContents
            // 
            tlpContents.BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            tlpContents.ColumnCount = 1;
            tlpContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpContents.Controls.Add(label1, 0, 0);
            tlpContents.Controls.Add(flpDetails, 0, 1);
            tlpContents.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpContents.Location = new System.Drawing.Point(25, 10);
            tlpContents.Name = "tlpContents";
            tlpContents.RowCount = 2;
            tlpContents.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpContents.Size = new System.Drawing.Size(777, 598);
            tlpContents.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(327, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 37);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            // 
            // flpDetails
            // 
            flpDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            flpDetails.Location = new System.Drawing.Point(57, 40);
            flpDetails.Name = "flpDetails";
            flpDetails.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            flpDetails.Size = new System.Drawing.Size(662, 555);
            flpDetails.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(13, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 21);
            label4.TabIndex = 4;
            label4.Text = "Shop Information";
            // 
            // shopInformationStep
            // 
            shopInformationStep.BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            shopInformationStep.Location = new System.Drawing.Point(14, 24);
            shopInformationStep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            shopInformationStep.Name = "shopInformationStep";
            shopInformationStep.Size = new System.Drawing.Size(618, 372);
            shopInformationStep.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Location = new System.Drawing.Point(13, 402);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(618, 1);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(13, 406);
            label5.Name = "label5";
            label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            label5.Size = new System.Drawing.Size(128, 41);
            label5.TabIndex = 6;
            label5.Text = "Weight Services";
            // 
            // weightServicesStep
            // 
            weightServicesStep.AutoScroll = true;
            weightServicesStep.BackColor = System.Drawing.Color.White;
            weightServicesStep.Location = new System.Drawing.Point(14, 450);
            weightServicesStep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            weightServicesStep.Name = "weightServicesStep";
            weightServicesStep.Size = new System.Drawing.Size(618, 318);
            weightServicesStep.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(13, 771);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            label6.Size = new System.Drawing.Size(109, 41);
            label6.TabIndex = 8;
            label6.Text = "Item Services";
            // 
            // itemServicesStep
            // 
            itemServicesStep.BackColor = System.Drawing.Color.White;
            itemServicesStep.Location = new System.Drawing.Point(14, 815);
            itemServicesStep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            itemServicesStep.Name = "itemServicesStep";
            itemServicesStep.Size = new System.Drawing.Size(618, 318);
            itemServicesStep.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.LightGray;
            panel2.Location = new System.Drawing.Point(13, 1139);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(618, 1);
            panel2.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnResetData, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(13, 1146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new System.Drawing.Size(614, 105);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // btnResetData
            // 
            btnResetData.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnResetData.BackColor = System.Drawing.Color.Red;
            btnResetData.Cursor = System.Windows.Forms.Cursors.Hand;
            btnResetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetData.ForeColor = System.Drawing.Color.White;
            btnResetData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnResetData.ImageKey = "plus.png";
            btnResetData.Location = new System.Drawing.Point(3, 67);
            btnResetData.Name = "btnResetData";
            btnResetData.Size = new System.Drawing.Size(110, 30);
            btnResetData.TabIndex = 17;
            btnResetData.Text = "Reset All Data";
            btnResetData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnResetData.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.MenuText;
            label3.Location = new System.Drawing.Point(3, 41);
            label3.Name = "label3";
            label3.Padding = new System.Windows.Forms.Padding(3);
            label3.Size = new System.Drawing.Size(347, 19);
            label3.TabIndex = 10;
            label3.Text = "Reset all data and return to setup wizard. This action cannot be undone.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            label2.Size = new System.Drawing.Size(104, 41);
            label2.TabIndex = 9;
            label2.Text = "Danger Zone";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.LightGray;
            panel3.Location = new System.Drawing.Point(13, 1257);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(618, 1);
            panel3.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnCancel.BackColor = System.Drawing.Color.White;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.DimGray;
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.ImageKey = "plus.png";
            btnCancel.Location = new System.Drawing.Point(13, 1264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(150, 30);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnSaveChanges.BackColor = System.Drawing.Color.DodgerBlue;
            btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveChanges.ForeColor = System.Drawing.Color.White;
            btnSaveChanges.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveChanges.ImageKey = "plus.png";
            btnSaveChanges.Location = new System.Drawing.Point(169, 1264);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new System.Drawing.Size(150, 30);
            btnSaveChanges.TabIndex = 19;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // SettingsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 250, 252);
            Controls.Add(tlpContents);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Margin = new System.Windows.Forms.Padding(10);
            Name = "SettingsControl";
            Padding = new System.Windows.Forms.Padding(25, 10, 25, 25);
            Size = new System.Drawing.Size(827, 633);
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
