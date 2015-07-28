namespace GPS_Test
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.latTB = new System.Windows.Forms.TextBox();
            this.longTB = new System.Windows.Forms.TextBox();
            this.coordinateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.getMapButton = new System.Windows.Forms.Button();
            this.mapPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPB)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(548, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "Ready";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // latTB
            // 
            this.latTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latTB.Location = new System.Drawing.Point(75, 13);
            this.latTB.Name = "latTB";
            this.latTB.Size = new System.Drawing.Size(395, 20);
            this.latTB.TabIndex = 1;
            // 
            // longTB
            // 
            this.longTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longTB.Location = new System.Drawing.Point(75, 39);
            this.longTB.Name = "longTB";
            this.longTB.Size = new System.Drawing.Size(395, 20);
            this.longTB.TabIndex = 2;
            // 
            // coordinateLabel
            // 
            this.coordinateLabel.AutoSize = true;
            this.coordinateLabel.Location = new System.Drawing.Point(10, 62);
            this.coordinateLabel.Name = "coordinateLabel";
            this.coordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.coordinateLabel.TabIndex = 3;
            this.coordinateLabel.Text = "Accuracy";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(10, 79);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(43, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Country";
            // 
            // getMapButton
            // 
            this.getMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getMapButton.Location = new System.Drawing.Point(476, 13);
            this.getMapButton.Name = "getMapButton";
            this.getMapButton.Size = new System.Drawing.Size(75, 46);
            this.getMapButton.TabIndex = 6;
            this.getMapButton.Text = "Show on Map";
            this.getMapButton.UseVisualStyleBackColor = true;
            this.getMapButton.Click += new System.EventHandler(this.getMapButton_Click);
            // 
            // mapPB
            // 
            this.mapPB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapPB.Location = new System.Drawing.Point(12, 95);
            this.mapPB.Name = "mapPB";
            this.mapPB.Size = new System.Drawing.Size(539, 279);
            this.mapPB.TabIndex = 8;
            this.mapPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Longitude:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapPB);
            this.Controls.Add(this.getMapButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.coordinateLabel);
            this.Controls.Add(this.longTB);
            this.Controls.Add(this.latTB);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "GPS Test";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TextBox latTB;
        private System.Windows.Forms.TextBox longTB;
        private System.Windows.Forms.Label coordinateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button getMapButton;
        private System.Windows.Forms.PictureBox mapPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

