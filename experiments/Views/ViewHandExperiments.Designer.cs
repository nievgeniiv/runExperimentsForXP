using System.ComponentModel;

namespace experiments.Views
{
    partial class ViewHandExperiments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.nextCombination = new System.Windows.Forms.Button();
            this.prevCombination = new System.Windows.Forms.Button();
            this.nextElementTransmitter = new System.Windows.Forms.Button();
            this.prevElementTransmitter = new System.Windows.Forms.Button();
            this.nextElementReceiver = new System.Windows.Forms.Button();
            this.prevElementReceiver = new System.Windows.Forms.Button();
            this.takePhoto = new System.Windows.Forms.Button();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.LableForCenterX = new System.Windows.Forms.Label();
            this.LableForCenterY = new System.Windows.Forms.Label();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextCombination
            // 
            this.nextCombination.Location = new System.Drawing.Point(73, 93);
            this.nextCombination.Name = "nextCombination";
            this.nextCombination.Size = new System.Drawing.Size(154, 23);
            this.nextCombination.TabIndex = 0;
            this.nextCombination.Text = "Следующая комбинация";
            this.nextCombination.UseVisualStyleBackColor = true;
            this.nextCombination.Click += new System.EventHandler(this.nextCombination_Click);
            // 
            // prevCombination
            // 
            this.prevCombination.Location = new System.Drawing.Point(73, 138);
            this.prevCombination.Name = "prevCombination";
            this.prevCombination.Size = new System.Drawing.Size(154, 23);
            this.prevCombination.TabIndex = 1;
            this.prevCombination.Text = "Предыдущая комбинация";
            this.prevCombination.UseVisualStyleBackColor = true;
            this.prevCombination.Click += new System.EventHandler(this.prevCombination_Click);
            // 
            // nextElementTransmitter
            // 
            this.nextElementTransmitter.Location = new System.Drawing.Point(265, 93);
            this.nextElementTransmitter.Name = "nextElementTransmitter";
            this.nextElementTransmitter.Size = new System.Drawing.Size(198, 23);
            this.nextElementTransmitter.TabIndex = 2;
            this.nextElementTransmitter.Text = "Следующий элемент в передатчике";
            this.nextElementTransmitter.UseVisualStyleBackColor = true;
            this.nextElementTransmitter.Click += new System.EventHandler(this.nextElementTransmitter_Click);
            // 
            // prevElementTransmitter
            // 
            this.prevElementTransmitter.Location = new System.Drawing.Point(265, 138);
            this.prevElementTransmitter.Name = "prevElementTransmitter";
            this.prevElementTransmitter.Size = new System.Drawing.Size(208, 23);
            this.prevElementTransmitter.TabIndex = 3;
            this.prevElementTransmitter.Text = "Предыдущий элемент в передатчике";
            this.prevElementTransmitter.UseVisualStyleBackColor = true;
            this.prevElementTransmitter.Click += new System.EventHandler(this.prevElementTransmitter_Click);
            // 
            // nextElementReceiver
            // 
            this.nextElementReceiver.Location = new System.Drawing.Point(497, 93);
            this.nextElementReceiver.Name = "nextElementReceiver";
            this.nextElementReceiver.Size = new System.Drawing.Size(208, 23);
            this.nextElementReceiver.TabIndex = 4;
            this.nextElementReceiver.Text = "Следующий элемент в приемнике";
            this.nextElementReceiver.UseVisualStyleBackColor = true;
            this.nextElementReceiver.Click += new System.EventHandler(this.nextElementReceiver_Click);
            // 
            // prevElementReceiver
            // 
            this.prevElementReceiver.Location = new System.Drawing.Point(497, 138);
            this.prevElementReceiver.Name = "prevElementReceiver";
            this.prevElementReceiver.Size = new System.Drawing.Size(208, 23);
            this.prevElementReceiver.TabIndex = 5;
            this.prevElementReceiver.Text = "Предыдущий элемент в приемнике";
            this.prevElementReceiver.UseVisualStyleBackColor = true;
            this.prevElementReceiver.Click += new System.EventHandler(this.prevElementReceiver_Click);
            // 
            // takePhoto
            // 
            this.takePhoto.Location = new System.Drawing.Point(310, 201);
            this.takePhoto.Name = "takePhoto";
            this.takePhoto.Size = new System.Drawing.Size(153, 23);
            this.takePhoto.TabIndex = 6;
            this.takePhoto.Text = "Сохранить фотографию";
            this.takePhoto.UseVisualStyleBackColor = true;
            this.takePhoto.Click += new System.EventHandler(this.takePhoto_Click);
            // 
            // CenterX
            // 
            this.CenterX.Location = new System.Drawing.Point(184, 57);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(90, 20);
            this.CenterX.TabIndex = 7;
            this.CenterX.Text = "0";
            // 
            // LableForCenterX
            // 
            this.LableForCenterX.Location = new System.Drawing.Point(222, 32);
            this.LableForCenterX.Name = "LableForCenterX";
            this.LableForCenterX.Size = new System.Drawing.Size(14, 13);
            this.LableForCenterX.TabIndex = 8;
            this.LableForCenterX.Text = "Х";
            // 
            // LableForCenterY
            // 
            this.LableForCenterY.Location = new System.Drawing.Point(391, 32);
            this.LableForCenterY.Name = "LableForCenterY";
            this.LableForCenterY.Size = new System.Drawing.Size(14, 13);
            this.LableForCenterY.TabIndex = 10;
            this.LableForCenterY.Text = "Y";
            // 
            // CenterY
            // 
            this.CenterY.Location = new System.Drawing.Point(353, 57);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(90, 20);
            this.CenterY.TabIndex = 9;
            this.CenterY.Text = "0";
            // 
            // ViewHandExperiments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.LableForCenterY);
            this.Controls.Add(this.CenterY);
            this.Controls.Add(this.LableForCenterX);
            this.Controls.Add(this.CenterX);
            this.Controls.Add(this.takePhoto);
            this.Controls.Add(this.prevElementReceiver);
            this.Controls.Add(this.nextElementReceiver);
            this.Controls.Add(this.prevElementTransmitter);
            this.Controls.Add(this.nextElementTransmitter);
            this.Controls.Add(this.prevCombination);
            this.Controls.Add(this.nextCombination);
            this.Name = "ViewHandExperiments";
            this.Text = "ViewHandExperiments";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.Label LableForCenterX;
        private System.Windows.Forms.Label LableForCenterY;
        private System.Windows.Forms.TextBox CenterY;

        private System.Windows.Forms.Button takePhoto;

        private System.Windows.Forms.Button prevElementReceiver;

        private System.Windows.Forms.Button nextElementReceiver;
        private System.Windows.Forms.Button prevElementTransmitter;

        private System.Windows.Forms.Button nextElementTransmitter;

        private System.Windows.Forms.Button prevCombination;

        private System.Windows.Forms.Button nextCombination;

        #endregion
    }
}