namespace experiments.Views
{
    partial class ViewLaserSettings
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
            this.ComplitePowerLaserButton = new System.Windows.Forms.Button();
            this.PowerLaserLabel = new System.Windows.Forms.Label();
            this.PowerLaserTextBox = new System.Windows.Forms.TextBox();
            this.UnitPowerLaserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComplitePowerLaserButton
            // 
            this.ComplitePowerLaserButton.Location = new System.Drawing.Point(191, 65);
            this.ComplitePowerLaserButton.Name = "ComplitePowerLaserButton";
            this.ComplitePowerLaserButton.Size = new System.Drawing.Size(75, 23);
            this.ComplitePowerLaserButton.TabIndex = 0;
            this.ComplitePowerLaserButton.Text = "Применить";
            this.ComplitePowerLaserButton.UseVisualStyleBackColor = true;
            this.ComplitePowerLaserButton.Click += new System.EventHandler(this.ComplitePowerLaserButton_Click);
            // 
            // PowerLaserLabel
            // 
            this.PowerLaserLabel.AutoSize = true;
            this.PowerLaserLabel.Location = new System.Drawing.Point(12, 26);
            this.PowerLaserLabel.Name = "PowerLaserLabel";
            this.PowerLaserLabel.Size = new System.Drawing.Size(99, 13);
            this.PowerLaserLabel.TabIndex = 1;
            this.PowerLaserLabel.Text = "Мощность лазера";
            // 
            // PowerLaserTextBox
            // 
            this.PowerLaserTextBox.Location = new System.Drawing.Point(127, 23);
            this.PowerLaserTextBox.Name = "PowerLaserTextBox";
            this.PowerLaserTextBox.Size = new System.Drawing.Size(100, 20);
            this.PowerLaserTextBox.TabIndex = 2;
            // 
            // UnitPowerLaserLabel
            // 
            this.UnitPowerLaserLabel.AutoSize = true;
            this.UnitPowerLaserLabel.Location = new System.Drawing.Point(233, 30);
            this.UnitPowerLaserLabel.Name = "UnitPowerLaserLabel";
            this.UnitPowerLaserLabel.Size = new System.Drawing.Size(33, 13);
            this.UnitPowerLaserLabel.TabIndex = 3;
            this.UnitPowerLaserLabel.Text = "МДж";
            // 
            // ViewLaserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 100);
            this.Controls.Add(this.UnitPowerLaserLabel);
            this.Controls.Add(this.PowerLaserTextBox);
            this.Controls.Add(this.PowerLaserLabel);
            this.Controls.Add(this.ComplitePowerLaserButton);
            this.Name = "ViewLaserSettings";
            this.Text = "Laser Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComplitePowerLaserButton;
        private System.Windows.Forms.Label PowerLaserLabel;
        private System.Windows.Forms.TextBox PowerLaserTextBox;
        private System.Windows.Forms.Label UnitPowerLaserLabel;
    }
}