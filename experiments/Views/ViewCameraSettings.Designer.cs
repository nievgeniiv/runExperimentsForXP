namespace experiments.Views
{
    partial class ViewCameraSettings
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
            this.SaveCameraSettingsButton = new System.Windows.Forms.Button();
            this.CountPhotoLabel = new System.Windows.Forms.Label();
            this.CountPhotoTextBox = new System.Windows.Forms.TextBox();
            this.modeHand = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SaveCameraSettingsButton
            // 
            this.SaveCameraSettingsButton.Location = new System.Drawing.Point(183, 78);
            this.SaveCameraSettingsButton.Name = "SaveCameraSettingsButton";
            this.SaveCameraSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SaveCameraSettingsButton.TabIndex = 0;
            this.SaveCameraSettingsButton.Text = "Принять";
            this.SaveCameraSettingsButton.UseVisualStyleBackColor = true;
            this.SaveCameraSettingsButton.Click += new System.EventHandler(this.SaveCameraSettingsButton_Click);
            // 
            // CountPhotoLabel
            // 
            this.CountPhotoLabel.AutoSize = true;
            this.CountPhotoLabel.Location = new System.Drawing.Point(12, 23);
            this.CountPhotoLabel.Name = "CountPhotoLabel";
            this.CountPhotoLabel.Size = new System.Drawing.Size(131, 13);
            this.CountPhotoLabel.TabIndex = 1;
            this.CountPhotoLabel.Text = "Количество фотографий";
            // 
            // CountPhotoTextBox
            // 
            this.CountPhotoTextBox.Location = new System.Drawing.Point(158, 16);
            this.CountPhotoTextBox.Name = "CountPhotoTextBox";
            this.CountPhotoTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountPhotoTextBox.TabIndex = 2;
            // 
            // modeHand
            // 
            this.modeHand.Location = new System.Drawing.Point(12, 53);
            this.modeHand.Name = "modeHand";
            this.modeHand.Size = new System.Drawing.Size(227, 24);
            this.modeHand.TabIndex = 3;
            this.modeHand.Text = "Режим внешней синхронизации";
            this.modeHand.UseVisualStyleBackColor = true;
            // 
            // ViewCameraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 113);
            this.Controls.Add(this.modeHand);
            this.Controls.Add(this.CountPhotoTextBox);
            this.Controls.Add(this.CountPhotoLabel);
            this.Controls.Add(this.SaveCameraSettingsButton);
            this.Name = "ViewCameraSettings";
            this.Text = "Camera Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox modeHand;

        #endregion

        private System.Windows.Forms.Button SaveCameraSettingsButton;
        private System.Windows.Forms.Label CountPhotoLabel;
        private System.Windows.Forms.TextBox CountPhotoTextBox;
    }
}