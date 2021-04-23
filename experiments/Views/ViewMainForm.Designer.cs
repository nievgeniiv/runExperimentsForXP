namespace experiments
{
    partial class ViewMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CommonSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsLaserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsStepMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConcentrationLabel = new System.Windows.Forms.Label();
            this.ConcentrationTextBox = new System.Windows.Forms.TextBox();
            this.TypeExperimentsLabel = new System.Windows.Forms.Label();
            this.ForwardTypeExperimentsButton = new System.Windows.Forms.Button();
            this.BackTypeExperimentsButton = new System.Windows.Forms.Button();
            this.RunExperimentsButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ручноеУправлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.SettingsToolStripMenuItem, this.AboutProgramToolStripMenuItem, this.ручноеУправлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.SaveAsToolStripMenuItem, this.openFolder});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // openFolder
            // 
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(156, 22);
            this.openFolder.Text = "Открыть папку";
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.CommonSettingsToolStripMenuItem, this.SettingsLaserToolStripMenuItem, this.SettingsStepMotorToolStripMenuItem, this.SettingsCameraToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            // 
            // CommonSettingsToolStripMenuItem
            // 
            this.CommonSettingsToolStripMenuItem.Name = "CommonSettingsToolStripMenuItem";
            this.CommonSettingsToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.CommonSettingsToolStripMenuItem.Text = "Общие настроки";
            this.CommonSettingsToolStripMenuItem.Click += new System.EventHandler(this.CommonSettingsToolStripMenuItem_Click);
            // 
            // SettingsLaserToolStripMenuItem
            // 
            this.SettingsLaserToolStripMenuItem.Name = "SettingsLaserToolStripMenuItem";
            this.SettingsLaserToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.SettingsLaserToolStripMenuItem.Text = "Настройки лазера";
            this.SettingsLaserToolStripMenuItem.Click += new System.EventHandler(this.SettingsLaserToolStripMenuItem_Click);
            // 
            // SettingsStepMotorToolStripMenuItem
            // 
            this.SettingsStepMotorToolStripMenuItem.Name = "SettingsStepMotorToolStripMenuItem";
            this.SettingsStepMotorToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.SettingsStepMotorToolStripMenuItem.Text = "Настройки шаговых двигателей";
            this.SettingsStepMotorToolStripMenuItem.Click += new System.EventHandler(this.SettingsStepMotorToolStripMenuItem_Click);
            // 
            // SettingsCameraToolStripMenuItem
            // 
            this.SettingsCameraToolStripMenuItem.Name = "SettingsCameraToolStripMenuItem";
            this.SettingsCameraToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.SettingsCameraToolStripMenuItem.Text = "Настройки камеры";
            this.SettingsCameraToolStripMenuItem.Click += new System.EventHandler(this.SettingsCameraToolStripMenuItem_Click);
            // 
            // AboutProgramToolStripMenuItem
            // 
            this.AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            this.AboutProgramToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutProgramToolStripMenuItem.Text = "О программе";
            this.AboutProgramToolStripMenuItem.Click += new System.EventHandler(this.AboutProgramToolStripMenuItem_Click);
            // 
            // ConcentrationLabel
            // 
            this.ConcentrationLabel.AutoSize = true;
            this.ConcentrationLabel.Location = new System.Drawing.Point(12, 39);
            this.ConcentrationLabel.Name = "ConcentrationLabel";
            this.ConcentrationLabel.Size = new System.Drawing.Size(181, 13);
            this.ConcentrationLabel.TabIndex = 1;
            this.ConcentrationLabel.Text = "Введите концентрацию вещества:";
            // 
            // ConcentrationTextBox
            // 
            this.ConcentrationTextBox.Location = new System.Drawing.Point(199, 36);
            this.ConcentrationTextBox.Name = "ConcentrationTextBox";
            this.ConcentrationTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConcentrationTextBox.TabIndex = 2;
            // 
            // TypeExperimentsLabel
            // 
            this.TypeExperimentsLabel.AutoSize = true;
            this.TypeExperimentsLabel.Location = new System.Drawing.Point(12, 74);
            this.TypeExperimentsLabel.Name = "TypeExperimentsLabel";
            this.TypeExperimentsLabel.Size = new System.Drawing.Size(105, 13);
            this.TypeExperimentsLabel.TabIndex = 3;
            this.TypeExperimentsLabel.Text = "Тип эксперимента:";
            // 
            // ForwardTypeExperimentsButton
            // 
            this.ForwardTypeExperimentsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.ForwardTypeExperimentsButton.Location = new System.Drawing.Point(123, 69);
            this.ForwardTypeExperimentsButton.Name = "ForwardTypeExperimentsButton";
            this.ForwardTypeExperimentsButton.Size = new System.Drawing.Size(92, 23);
            this.ForwardTypeExperimentsButton.TabIndex = 4;
            this.ForwardTypeExperimentsButton.Text = "Пропускание";
            this.ForwardTypeExperimentsButton.UseVisualStyleBackColor = false;
            this.ForwardTypeExperimentsButton.Click += new System.EventHandler(this.ForwardTypeExperimentsButton_Click);
            // 
            // BackTypeExperimentsButton
            // 
            this.BackTypeExperimentsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.BackTypeExperimentsButton.Location = new System.Drawing.Point(224, 69);
            this.BackTypeExperimentsButton.Name = "BackTypeExperimentsButton";
            this.BackTypeExperimentsButton.Size = new System.Drawing.Size(198, 23);
            this.BackTypeExperimentsButton.TabIndex = 5;
            this.BackTypeExperimentsButton.Text = "Обратно рассеянное излучение";
            this.BackTypeExperimentsButton.UseVisualStyleBackColor = false;
            this.BackTypeExperimentsButton.Click += new System.EventHandler(this.BackTypeExperimentsButton_Click);
            // 
            // RunExperimentsButton
            // 
            this.RunExperimentsButton.Location = new System.Drawing.Point(756, 69);
            this.RunExperimentsButton.Name = "RunExperimentsButton";
            this.RunExperimentsButton.Size = new System.Drawing.Size(170, 23);
            this.RunExperimentsButton.TabIndex = 6;
            this.RunExperimentsButton.Text = "Запустить эксперимент";
            this.RunExperimentsButton.UseVisualStyleBackColor = true;
            this.RunExperimentsButton.Click += new System.EventHandler(this.RunExperimentsButton_Click);
            // 
            // ручноеУправлениеToolStripMenuItem
            // 
            this.ручноеУправлениеToolStripMenuItem.Name = "ручноеУправлениеToolStripMenuItem";
            this.ручноеУправлениеToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.ручноеУправлениеToolStripMenuItem.Text = "Ручное управление";
            this.ручноеУправлениеToolStripMenuItem.Click += new System.EventHandler(this.ручноеУправлениеToolStripMenuItem_Click);
            // 
            // ViewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 116);
            this.Controls.Add(this.RunExperimentsButton);
            this.Controls.Add(this.BackTypeExperimentsButton);
            this.Controls.Add(this.ForwardTypeExperimentsButton);
            this.Controls.Add(this.TypeExperimentsLabel);
            this.Controls.Add(this.ConcentrationTextBox);
            this.Controls.Add(this.ConcentrationLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewMainForm";
            this.Text = "Experiments";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem ручноеУправлениеToolStripMenuItem;

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        private System.Windows.Forms.ToolStripMenuItem openFolder;

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CommonSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsStepMotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsLaserToolStripMenuItem;
        private System.Windows.Forms.Label ConcentrationLabel;
        private System.Windows.Forms.TextBox ConcentrationTextBox;
        private System.Windows.Forms.Label TypeExperimentsLabel;
        private System.Windows.Forms.Button ForwardTypeExperimentsButton;
        private System.Windows.Forms.Button BackTypeExperimentsButton;
        private System.Windows.Forms.Button RunExperimentsButton;
    }
}

