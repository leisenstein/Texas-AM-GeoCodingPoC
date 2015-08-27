namespace Texas_AM_GeoCodingPoC
{
    partial class Main
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
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtAddr2 = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.lblAddr2 = new System.Windows.Forms.Label();
            this.lblCityStateZip = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnNormalizeAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(100, 41);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(251, 20);
            this.txtAdd1.TabIndex = 0;
            // 
            // txtAddr2
            // 
            this.txtAddr2.Location = new System.Drawing.Point(100, 67);
            this.txtAddr2.Name = "txtAddr2";
            this.txtAddr2.Size = new System.Drawing.Size(251, 20);
            this.txtAddr2.TabIndex = 1;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(281, 93);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(70, 20);
            this.txtZip.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(233, 93);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(42, 20);
            this.txtState.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(100, 93);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(127, 20);
            this.txtCity.TabIndex = 2;
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Location = new System.Drawing.Point(12, 48);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(54, 13);
            this.lblAddr1.TabIndex = 99;
            this.lblAddr1.Text = "Address 1";
            // 
            // lblAddr2
            // 
            this.lblAddr2.AutoSize = true;
            this.lblAddr2.Location = new System.Drawing.Point(12, 74);
            this.lblAddr2.Name = "lblAddr2";
            this.lblAddr2.Size = new System.Drawing.Size(54, 13);
            this.lblAddr2.TabIndex = 99;
            this.lblAddr2.Text = "Address 2";
            // 
            // lblCityStateZip
            // 
            this.lblCityStateZip.AutoSize = true;
            this.lblCityStateZip.Location = new System.Drawing.Point(13, 100);
            this.lblCityStateZip.Name = "lblCityStateZip";
            this.lblCityStateZip.Size = new System.Drawing.Size(73, 13);
            this.lblCityStateZip.TabIndex = 99;
            this.lblCityStateZip.Text = "City, State Zip";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(419, 41);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(635, 311);
            this.txtResult.TabIndex = 6;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(188, 142);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Geocode";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnNormalizeAddress
            // 
            this.btnNormalizeAddress.Location = new System.Drawing.Point(276, 142);
            this.btnNormalizeAddress.Name = "btnNormalizeAddress";
            this.btnNormalizeAddress.Size = new System.Drawing.Size(75, 23);
            this.btnNormalizeAddress.TabIndex = 100;
            this.btnNormalizeAddress.Text = "Normalize";
            this.btnNormalizeAddress.UseVisualStyleBackColor = true;
            this.btnNormalizeAddress.Click += new System.EventHandler(this.btnNormalizeAddress_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 364);
            this.Controls.Add(this.btnNormalizeAddress);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblCityStateZip);
            this.Controls.Add(this.lblAddr2);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtAddr2);
            this.Controls.Add(this.txtAdd1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtAddr2;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.Label lblAddr2;
        private System.Windows.Forms.Label lblCityStateZip;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnNormalizeAddress;
    }
}

