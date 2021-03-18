namespace experiments.Views
{
    partial class ViewStepMotorSettings
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
            this.GetListComPortsButton = new System.Windows.Forms.Button();
            this.ListComPortsComboBox = new System.Windows.Forms.ComboBox();
            this.ConnectAndDisconnectComPortButton1 = new System.Windows.Forms.Button();
            this.TransmitterGroupBox = new System.Windows.Forms.GroupBox();
            this.TransmitterSectorBack = new System.Windows.Forms.Button();
            this.TransmitterSectorForward = new System.Windows.Forms.Button();
            this.TransmitterStepBackButton1 = new System.Windows.Forms.Button();
            this.TransmitterStepForwardButton = new System.Windows.Forms.Button();
            this.ReceiverGroupBox = new System.Windows.Forms.GroupBox();
            this.ReceiverSectorBack = new System.Windows.Forms.Button();
            this.ReceiverSectorForward = new System.Windows.Forms.Button();
            this.ReceiverStepBackButton = new System.Windows.Forms.Button();
            this.ReceiverStepForwardButton = new System.Windows.Forms.Button();
            this.CompliteStepMotorButton = new System.Windows.Forms.Button();
            this.nextGroup = new System.Windows.Forms.Button();
            this.previousGroup = new System.Windows.Forms.Button();
            this.TransmitterGroupBox.SuspendLayout();
            this.ReceiverGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetListComPortsButton
            // 
            this.GetListComPortsButton.Location = new System.Drawing.Point(24, 12);
            this.GetListComPortsButton.Name = "GetListComPortsButton";
            this.GetListComPortsButton.Size = new System.Drawing.Size(200, 23);
            this.GetListComPortsButton.TabIndex = 0;
            this.GetListComPortsButton.Text = "Получить список COM-портов";
            this.GetListComPortsButton.UseVisualStyleBackColor = true;
            this.GetListComPortsButton.Click += new System.EventHandler(this.GetListComPortsButton_Click);
            // 
            // ListComPortsComboBox
            // 
            this.ListComPortsComboBox.FormattingEnabled = true;
            this.ListComPortsComboBox.Location = new System.Drawing.Point(24, 53);
            this.ListComPortsComboBox.Name = "ListComPortsComboBox";
            this.ListComPortsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ListComPortsComboBox.TabIndex = 1;
            // 
            // ConnectAndDisconnectComPortButton1
            // 
            this.ConnectAndDisconnectComPortButton1.Location = new System.Drawing.Point(24, 89);
            this.ConnectAndDisconnectComPortButton1.Name = "ConnectAndDisconnectComPortButton1";
            this.ConnectAndDisconnectComPortButton1.Size = new System.Drawing.Size(200, 23);
            this.ConnectAndDisconnectComPortButton1.TabIndex = 2;
            this.ConnectAndDisconnectComPortButton1.Text = "Соединиться с COM-портом";
            this.ConnectAndDisconnectComPortButton1.UseVisualStyleBackColor = true;
            this.ConnectAndDisconnectComPortButton1.Click += new System.EventHandler(this.ConnectAndDisconnectComPortButton1_Click);
            // 
            // TransmitterGroupBox
            // 
            this.TransmitterGroupBox.Controls.Add(this.TransmitterSectorBack);
            this.TransmitterGroupBox.Controls.Add(this.TransmitterSectorForward);
            this.TransmitterGroupBox.Controls.Add(this.TransmitterStepBackButton1);
            this.TransmitterGroupBox.Controls.Add(this.TransmitterStepForwardButton);
            this.TransmitterGroupBox.Location = new System.Drawing.Point(24, 152);
            this.TransmitterGroupBox.Name = "TransmitterGroupBox";
            this.TransmitterGroupBox.Size = new System.Drawing.Size(227, 141);
            this.TransmitterGroupBox.TabIndex = 3;
            this.TransmitterGroupBox.TabStop = false;
            this.TransmitterGroupBox.Text = "Передатчик";
            // 
            // TransmitterSectorBack
            // 
            this.TransmitterSectorBack.Location = new System.Drawing.Point(63, 92);
            this.TransmitterSectorBack.Name = "TransmitterSectorBack";
            this.TransmitterSectorBack.Size = new System.Drawing.Size(101, 23);
            this.TransmitterSectorBack.TabIndex = 3;
            this.TransmitterSectorBack.Text = "Сектор назад";
            this.TransmitterSectorBack.UseVisualStyleBackColor = true;
            this.TransmitterSectorBack.Click += new System.EventHandler(this.TransmitterSectorBack_Click);
            // 
            // TransmitterSectorForward
            // 
            this.TransmitterSectorForward.Location = new System.Drawing.Point(63, 34);
            this.TransmitterSectorForward.Name = "TransmitterSectorForward";
            this.TransmitterSectorForward.Size = new System.Drawing.Size(101, 23);
            this.TransmitterSectorForward.TabIndex = 2;
            this.TransmitterSectorForward.Text = "Сектор вперед";
            this.TransmitterSectorForward.UseVisualStyleBackColor = true;
            this.TransmitterSectorForward.Click += new System.EventHandler(this.TransmitterSectorForward_Click);
            // 
            // TransmitterStepBackButton1
            // 
            this.TransmitterStepBackButton1.Location = new System.Drawing.Point(19, 63);
            this.TransmitterStepBackButton1.Name = "TransmitterStepBackButton1";
            this.TransmitterStepBackButton1.Size = new System.Drawing.Size(75, 23);
            this.TransmitterStepBackButton1.TabIndex = 1;
            this.TransmitterStepBackButton1.Text = "Шаг назад";
            this.TransmitterStepBackButton1.UseVisualStyleBackColor = true;
            this.TransmitterStepBackButton1.Click += new System.EventHandler(this.TransmitterStepBackButton1_Click);
            // 
            // TransmitterStepForwardButton
            // 
            this.TransmitterStepForwardButton.Location = new System.Drawing.Point(135, 63);
            this.TransmitterStepForwardButton.Name = "TransmitterStepForwardButton";
            this.TransmitterStepForwardButton.Size = new System.Drawing.Size(75, 23);
            this.TransmitterStepForwardButton.TabIndex = 0;
            this.TransmitterStepForwardButton.Text = "Шаг вперед";
            this.TransmitterStepForwardButton.UseVisualStyleBackColor = true;
            this.TransmitterStepForwardButton.Click += new System.EventHandler(this.TransmitterStepForwardButton_Click);
            // 
            // ReceiverGroupBox
            // 
            this.ReceiverGroupBox.Controls.Add(this.ReceiverSectorBack);
            this.ReceiverGroupBox.Controls.Add(this.ReceiverSectorForward);
            this.ReceiverGroupBox.Controls.Add(this.ReceiverStepBackButton);
            this.ReceiverGroupBox.Controls.Add(this.ReceiverStepForwardButton);
            this.ReceiverGroupBox.Location = new System.Drawing.Point(267, 152);
            this.ReceiverGroupBox.Name = "ReceiverGroupBox";
            this.ReceiverGroupBox.Size = new System.Drawing.Size(227, 141);
            this.ReceiverGroupBox.TabIndex = 4;
            this.ReceiverGroupBox.TabStop = false;
            this.ReceiverGroupBox.Text = "Приемник";
            // 
            // ReceiverSectorBack
            // 
            this.ReceiverSectorBack.Location = new System.Drawing.Point(65, 92);
            this.ReceiverSectorBack.Name = "ReceiverSectorBack";
            this.ReceiverSectorBack.Size = new System.Drawing.Size(104, 23);
            this.ReceiverSectorBack.TabIndex = 5;
            this.ReceiverSectorBack.Text = "Сектор назад";
            this.ReceiverSectorBack.UseVisualStyleBackColor = true;
            this.ReceiverSectorBack.Click += new System.EventHandler(this.ReceiverSectorBack_Click);
            // 
            // ReceiverSectorForward
            // 
            this.ReceiverSectorForward.Location = new System.Drawing.Point(65, 34);
            this.ReceiverSectorForward.Name = "ReceiverSectorForward";
            this.ReceiverSectorForward.Size = new System.Drawing.Size(104, 23);
            this.ReceiverSectorForward.TabIndex = 4;
            this.ReceiverSectorForward.Text = "Сектор вперед";
            this.ReceiverSectorForward.UseVisualStyleBackColor = true;
            this.ReceiverSectorForward.Click += new System.EventHandler(this.ReceiverSectorForward_Click);
            // 
            // ReceiverStepBackButton
            // 
            this.ReceiverStepBackButton.Location = new System.Drawing.Point(21, 63);
            this.ReceiverStepBackButton.Name = "ReceiverStepBackButton";
            this.ReceiverStepBackButton.Size = new System.Drawing.Size(75, 23);
            this.ReceiverStepBackButton.TabIndex = 3;
            this.ReceiverStepBackButton.Text = "Шаг назад";
            this.ReceiverStepBackButton.UseVisualStyleBackColor = true;
            this.ReceiverStepBackButton.Click += new System.EventHandler(this.ReceiverStepBackButton_Click);
            // 
            // ReceiverStepForwardButton
            // 
            this.ReceiverStepForwardButton.Location = new System.Drawing.Point(137, 63);
            this.ReceiverStepForwardButton.Name = "ReceiverStepForwardButton";
            this.ReceiverStepForwardButton.Size = new System.Drawing.Size(75, 23);
            this.ReceiverStepForwardButton.TabIndex = 2;
            this.ReceiverStepForwardButton.Text = "Шаг вперед";
            this.ReceiverStepForwardButton.UseVisualStyleBackColor = true;
            this.ReceiverStepForwardButton.Click += new System.EventHandler(this.ReceiverStepForwardButton_Click);
            // 
            // CompliteStepMotorButton
            // 
            this.CompliteStepMotorButton.Location = new System.Drawing.Point(419, 311);
            this.CompliteStepMotorButton.Name = "CompliteStepMotorButton";
            this.CompliteStepMotorButton.Size = new System.Drawing.Size(75, 23);
            this.CompliteStepMotorButton.TabIndex = 5;
            this.CompliteStepMotorButton.Text = "Применить";
            this.CompliteStepMotorButton.UseVisualStyleBackColor = true;
            this.CompliteStepMotorButton.Click += new System.EventHandler(this.CompliteStepMotorButton_Click);
            // 
            // nextGroup
            // 
            this.nextGroup.Location = new System.Drawing.Point(159, 318);
            this.nextGroup.Name = "nextGroup";
            this.nextGroup.Size = new System.Drawing.Size(125, 23);
            this.nextGroup.TabIndex = 6;
            this.nextGroup.Text = "Следующая группа";
            this.nextGroup.UseVisualStyleBackColor = true;
            this.nextGroup.Click += new System.EventHandler(this.nextGroup_Click);
            // 
            // previousGroup
            // 
            this.previousGroup.Location = new System.Drawing.Point(26, 318);
            this.previousGroup.Name = "previousGroup";
            this.previousGroup.Size = new System.Drawing.Size(119, 23);
            this.previousGroup.TabIndex = 7;
            this.previousGroup.Text = "Предыдущая группа";
            this.previousGroup.UseVisualStyleBackColor = true;
            this.previousGroup.Click += new System.EventHandler(this.previousGroup_Click);
            // 
            // ViewStepMotorSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 351);
            this.Controls.Add(this.previousGroup);
            this.Controls.Add(this.nextGroup);
            this.Controls.Add(this.CompliteStepMotorButton);
            this.Controls.Add(this.ReceiverGroupBox);
            this.Controls.Add(this.TransmitterGroupBox);
            this.Controls.Add(this.ConnectAndDisconnectComPortButton1);
            this.Controls.Add(this.ListComPortsComboBox);
            this.Controls.Add(this.GetListComPortsButton);
            this.Name = "ViewStepMotorSettings";
            this.Text = "Step Motor Settings";
            this.TransmitterGroupBox.ResumeLayout(false);
            this.ReceiverGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button previousGroup;

        private System.Windows.Forms.Button nextGroup;

        private System.Windows.Forms.Button ReceiverSectorBack;
        private System.Windows.Forms.Button ReceiverSectorForward;
        private System.Windows.Forms.Button TransmitterSectorBack;

        private System.Windows.Forms.Button TransmitterSectorForward;

        #endregion

        private System.Windows.Forms.Button GetListComPortsButton;
        private System.Windows.Forms.ComboBox ListComPortsComboBox;
        private System.Windows.Forms.Button ConnectAndDisconnectComPortButton1;
        private System.Windows.Forms.GroupBox TransmitterGroupBox;
        private System.Windows.Forms.Button TransmitterStepBackButton1;
        private System.Windows.Forms.Button TransmitterStepForwardButton;
        private System.Windows.Forms.GroupBox ReceiverGroupBox;
        private System.Windows.Forms.Button ReceiverStepBackButton;
        private System.Windows.Forms.Button ReceiverStepForwardButton;
        private System.Windows.Forms.Button CompliteStepMotorButton;
    }
}