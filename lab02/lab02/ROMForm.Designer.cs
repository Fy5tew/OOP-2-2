namespace lab02 {
    partial class ROMForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ROMGroupBox = new System.Windows.Forms.GroupBox();
            this.ROMVolumeSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ROMTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ROMVolumeTextBox = new System.Windows.Forms.TextBox();
            this.ROMTypeLabel = new System.Windows.Forms.Label();
            this.ROMVolumeLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RAMEditButton = new System.Windows.Forms.Button();
            this.ROMGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ROMGroupBox
            // 
            this.ROMGroupBox.Controls.Add(this.ROMVolumeSizeComboBox);
            this.ROMGroupBox.Controls.Add(this.ROMTypeComboBox);
            this.ROMGroupBox.Controls.Add(this.ROMVolumeTextBox);
            this.ROMGroupBox.Controls.Add(this.ROMTypeLabel);
            this.ROMGroupBox.Controls.Add(this.ROMVolumeLabel);
            this.ROMGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ROMGroupBox.Name = "ROMGroupBox";
            this.ROMGroupBox.Size = new System.Drawing.Size(300, 130);
            this.ROMGroupBox.TabIndex = 0;
            this.ROMGroupBox.TabStop = false;
            this.ROMGroupBox.Text = "ПЗУ";
            // 
            // ROMVolumeSizeComboBox
            // 
            this.ROMVolumeSizeComboBox.FormattingEnabled = true;
            this.ROMVolumeSizeComboBox.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB",
            "TB"});
            this.ROMVolumeSizeComboBox.Location = new System.Drawing.Point(212, 91);
            this.ROMVolumeSizeComboBox.Name = "ROMVolumeSizeComboBox";
            this.ROMVolumeSizeComboBox.Size = new System.Drawing.Size(82, 24);
            this.ROMVolumeSizeComboBox.TabIndex = 2;
            this.ROMVolumeSizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // ROMTypeComboBox
            // 
            this.ROMTypeComboBox.FormattingEnabled = true;
            this.ROMTypeComboBox.Items.AddRange(new object[] {
            "HDD",
            "SSD",
            "SSHD",
            "NVMe SSD"});
            this.ROMTypeComboBox.Location = new System.Drawing.Point(6, 41);
            this.ROMTypeComboBox.Name = "ROMTypeComboBox";
            this.ROMTypeComboBox.Size = new System.Drawing.Size(288, 24);
            this.ROMTypeComboBox.TabIndex = 0;
            this.ROMTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // ROMVolumeTextBox
            // 
            this.ROMVolumeTextBox.Location = new System.Drawing.Point(6, 91);
            this.ROMVolumeTextBox.MaxLength = 8;
            this.ROMVolumeTextBox.Name = "ROMVolumeTextBox";
            this.ROMVolumeTextBox.Size = new System.Drawing.Size(200, 22);
            this.ROMVolumeTextBox.TabIndex = 1;
            this.ROMVolumeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // ROMTypeLabel
            // 
            this.ROMTypeLabel.AutoSize = true;
            this.ROMTypeLabel.Location = new System.Drawing.Point(6, 20);
            this.ROMTypeLabel.Name = "ROMTypeLabel";
            this.ROMTypeLabel.Size = new System.Drawing.Size(32, 16);
            this.ROMTypeLabel.TabIndex = 5;
            this.ROMTypeLabel.Text = "Тип";
            // 
            // ROMVolumeLabel
            // 
            this.ROMVolumeLabel.AutoSize = true;
            this.ROMVolumeLabel.Location = new System.Drawing.Point(6, 70);
            this.ROMVolumeLabel.Name = "ROMVolumeLabel";
            this.ROMVolumeLabel.Size = new System.Drawing.Size(51, 16);
            this.ROMVolumeLabel.TabIndex = 7;
            this.ROMVolumeLabel.Text = "Объем";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(162, 148);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(150, 50);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(12, 148);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 50);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RAMEditButton
            // 
            this.RAMEditButton.Location = new System.Drawing.Point(-146, -249);
            this.RAMEditButton.Name = "RAMEditButton";
            this.RAMEditButton.Size = new System.Drawing.Size(286, 39);
            this.RAMEditButton.TabIndex = 10;
            this.RAMEditButton.Text = "Изменить";
            this.RAMEditButton.UseVisualStyleBackColor = true;
            // 
            // ROMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 208);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RAMEditButton);
            this.Controls.Add(this.ROMGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ROMForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ПЗУ";
            this.ROMGroupBox.ResumeLayout(false);
            this.ROMGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ROMGroupBox;
        private System.Windows.Forms.ComboBox ROMVolumeSizeComboBox;
        private System.Windows.Forms.ComboBox ROMTypeComboBox;
        private System.Windows.Forms.TextBox ROMVolumeTextBox;
        private System.Windows.Forms.Label ROMTypeLabel;
        private System.Windows.Forms.Label ROMVolumeLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RAMEditButton;
    }
}