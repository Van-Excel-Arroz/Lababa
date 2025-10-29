namespace Lababa.Frontend.UserControls
{
    partial class WelcomeStepControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeStepControl));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnGetStarted = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDetails.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(14, 2);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(308, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Lababa";
            // 
            // tlpDetails
            // 
            this.tlpDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpDetails.ColumnCount = 1;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.Controls.Add(this.lblWelcome, 0, 0);
            this.tlpDetails.Controls.Add(this.lblDescription, 0, 1);
            this.tlpDetails.Controls.Add(this.btnGetStarted, 0, 2);
            this.tlpDetails.Location = new System.Drawing.Point(57, 70);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 3;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpDetails.Size = new System.Drawing.Size(336, 159);
            this.tlpDetails.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(28, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(279, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Let\'s set up your shop in just a few quick steps";
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGetStarted.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStarted.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetStarted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetStarted.ImageKey = "arrow-right.png";
            this.btnGetStarted.ImageList = this.imageList1;
            this.btnGetStarted.Location = new System.Drawing.Point(18, 121);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetStarted.Size = new System.Drawing.Size(300, 35);
            this.btnGetStarted.TabIndex = 2;
            this.btnGetStarted.Text = "Get Started  ";
            this.btnGetStarted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetStarted.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow-right.png");
            // 
            // tlpContainer
            // 
            this.tlpContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.tlpDetails, 0, 0);
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContainer.Size = new System.Drawing.Size(450, 300);
            this.tlpContainer.TabIndex = 0;
            // 
            // WelcomeStepControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpContainer);
            this.Name = "WelcomeStepControl";
            this.Size = new System.Drawing.Size(450, 300);
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnGetStarted;
        private System.Windows.Forms.ImageList imageList1;
    }
}
