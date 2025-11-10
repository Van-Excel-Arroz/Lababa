namespace Lababa.Frontend.UserControls
{
    partial class ReceiptSettingsStep
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
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.labeledTextBox1 = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.labeledTextBox2 = new Lababa.Frontend.UserControls.LabeledTextBox();
            this.tlpDetails.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDetails
            // 
            this.tlpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDetails.ColumnCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.labeledTextBox1, 0, 0);
            this.tlpDetails.Controls.Add(this.labeledTextBox2, 0, 1);
            this.tlpDetails.Location = new System.Drawing.Point(3, 3);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.Padding = new System.Windows.Forms.Padding(10);
            this.tlpDetails.RowCount = 2;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDetails.Size = new System.Drawing.Size(441, 122);
            this.tlpDetails.TabIndex = 0;
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Controls.Add(this.tlpDetails, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpContainer.Size = new System.Drawing.Size(447, 550);
            this.tlpContainer.TabIndex = 1;
            // 
            // labeledTextBox1
            // 
            this.labeledTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeledTextBox1.LabelText = "Receipt Header Message";
            this.labeledTextBox1.Location = new System.Drawing.Point(13, 13);
            this.labeledTextBox1.Name = "labeledTextBox1";
            this.labeledTextBox1.Size = new System.Drawing.Size(415, 49);
            this.labeledTextBox1.TabIndex = 0;
            // 
            // labeledTextBox2
            // 
            this.labeledTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeledTextBox2.LabelText = "Receipt Footer Message";
            this.labeledTextBox2.Location = new System.Drawing.Point(13, 68);
            this.labeledTextBox2.Name = "labeledTextBox2";
            this.labeledTextBox2.Size = new System.Drawing.Size(415, 49);
            this.labeledTextBox2.TabIndex = 1;
            // 
            // ReceiptSettingsStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "ReceiptSettingsStep";
            this.Size = new System.Drawing.Size(447, 550);
            this.tlpDetails.ResumeLayout(false);
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private LabeledTextBox labeledTextBox1;
        private LabeledTextBox labeledTextBox2;
    }
}
