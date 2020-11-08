namespace experiments.Views
{
    partial class ViewCommonSettings
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
            this.PathSaveResultLable = new System.Windows.Forms.Label();
            this.PathSaveResultTextBox = new System.Windows.Forms.TextBox();
            this.CompliteSaveCommonSettingsButton = new System.Windows.Forms.Button();
            this.ChangeSavePathResultButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // PathSaveResultLable
            // 
            this.PathSaveResultLable.AutoSize = true;
            this.PathSaveResultLable.Location = new System.Drawing.Point(24, 27);
            this.PathSaveResultLable.Name = "PathSaveResultLable";
            this.PathSaveResultLable.Size = new System.Drawing.Size(174, 13);
            this.PathSaveResultLable.TabIndex = 0;
            this.PathSaveResultLable.Text = "Путь куда сохранять результаты";
            // 
            // PathSaveResultTextBox
            // 
            this.PathSaveResultTextBox.Location = new System.Drawing.Point(227, 24);
            this.PathSaveResultTextBox.Name = "PathSaveResultTextBox";
            this.PathSaveResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.PathSaveResultTextBox.TabIndex = 1;
            // 
            // CompliteSaveCommonSettingsButton
            // 
            this.CompliteSaveCommonSettingsButton.Location = new System.Drawing.Point(356, 72);
            this.CompliteSaveCommonSettingsButton.Name = "CompliteSaveCommonSettingsButton";
            this.CompliteSaveCommonSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.CompliteSaveCommonSettingsButton.TabIndex = 2;
            this.CompliteSaveCommonSettingsButton.Text = "Применить";
            this.CompliteSaveCommonSettingsButton.UseVisualStyleBackColor = true;
            this.CompliteSaveCommonSettingsButton.Click += new System.EventHandler(this.CompliteSaveCommonSettingsButton_Click);
            // 
            // ChangeSavePathResultButton
            // 
            this.ChangeSavePathResultButton.Location = new System.Drawing.Point(356, 24);
            this.ChangeSavePathResultButton.Name = "ChangeSavePathResultButton";
            this.ChangeSavePathResultButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeSavePathResultButton.TabIndex = 3;
            this.ChangeSavePathResultButton.Text = "Изменить";
            this.ChangeSavePathResultButton.UseVisualStyleBackColor = true;
            this.ChangeSavePathResultButton.Click += new System.EventHandler(this.ChangeSavePathResultButton_Click);
            // 
            // ViewCommonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 107);
            this.Controls.Add(this.ChangeSavePathResultButton);
            this.Controls.Add(this.CompliteSaveCommonSettingsButton);
            this.Controls.Add(this.PathSaveResultTextBox);
            this.Controls.Add(this.PathSaveResultLable);
            this.Name = "ViewCommonSettings";
            this.Text = "Common Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathSaveResultLable;
        private System.Windows.Forms.TextBox PathSaveResultTextBox;
        private System.Windows.Forms.Button CompliteSaveCommonSettingsButton;
        private System.Windows.Forms.Button ChangeSavePathResultButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}