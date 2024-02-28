namespace lab02 {
    partial class RAMForm {
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
            this.RAMGroupBox = new System.Windows.Forms.GroupBox();
            this.RAMVolumeSizeComboBox = new System.Windows.Forms.ComboBox();
            this.RAMVolumeTextBox = new System.Windows.Forms.TextBox();
            this.RAMVolumeLabel = new System.Windows.Forms.Label();
            this.RAMTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RAMTypeLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RAMEditButton = new System.Windows.Forms.Button();
            this.RAMGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RAMGroupBox
            // 
            this.RAMGroupBox.Controls.Add(this.RAMVolumeSizeComboBox);
            this.RAMGroupBox.Controls.Add(this.RAMVolumeTextBox);
            this.RAMGroupBox.Controls.Add(this.RAMVolumeLabel);
            this.RAMGroupBox.Controls.Add(this.RAMTypeComboBox);
            this.RAMGroupBox.Controls.Add(this.RAMTypeLabel);
            this.RAMGroupBox.Location = new System.Drawing.Point(12, 12);
            this.RAMGroupBox.Name = "RAMGroupBox";
            this.RAMGroupBox.Size = new System.Drawing.Size(300, 130);
            this.RAMGroupBox.TabIndex = 0;
            this.RAMGroupBox.TabStop = false;
            this.RAMGroupBox.Text = "ОЗУ";
            // 
            // RAMVolumeSizeComboBox
            // 
            this.RAMVolumeSizeComboBox.FormattingEnabled = true;
            this.RAMVolumeSizeComboBox.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.RAMVolumeSizeComboBox.Location = new System.Drawing.Point(212, 91);
            this.RAMVolumeSizeComboBox.Name = "RAMVolumeSizeComboBox";
            this.RAMVolumeSizeComboBox.Size = new System.Drawing.Size(82, 24);
            this.RAMVolumeSizeComboBox.TabIndex = 2;
            this.RAMVolumeSizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // RAMVolumeTextBox
            // 
            this.RAMVolumeTextBox.Location = new System.Drawing.Point(6, 91);
            this.RAMVolumeTextBox.MaxLength = 8;
            this.RAMVolumeTextBox.Name = "RAMVolumeTextBox";
            this.RAMVolumeTextBox.Size = new System.Drawing.Size(200, 22);
            this.RAMVolumeTextBox.TabIndex = 1;
            this.RAMVolumeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // RAMVolumeLabel
            // 
            this.RAMVolumeLabel.AutoSize = true;
            this.RAMVolumeLabel.Location = new System.Drawing.Point(6, 70);
            this.RAMVolumeLabel.Name = "RAMVolumeLabel";
            this.RAMVolumeLabel.Size = new System.Drawing.Size(51, 16);
            this.RAMVolumeLabel.TabIndex = 2;
            this.RAMVolumeLabel.Text = "Объем";
            // 
            // RAMTypeComboBox
            // 
            this.RAMTypeComboBox.FormattingEnabled = true;
            this.RAMTypeComboBox.Items.AddRange(new object[] {
            "DDR1",
            "DDR2",
            "DDR3",
            "DDR4",
            "DDR5",
            "SDRAM",
            "DDR SDRAM",
            "DDR2 SDRAM",
            "DDR3 SDRAM",
            "DDR4 SDRAM",
            "LPDDR2",
            "LPDDR3",
            "LPDDR4",
            "LPDDR5",
            "ECC",
            "SO-DIMM",
            "UDIMM",
            "RDIMM",
            "DIMM"});
            this.RAMTypeComboBox.Location = new System.Drawing.Point(6, 41);
            this.RAMTypeComboBox.Name = "RAMTypeComboBox";
            this.RAMTypeComboBox.Size = new System.Drawing.Size(288, 24);
            this.RAMTypeComboBox.TabIndex = 0;
            this.RAMTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // RAMTypeLabel
            // 
            this.RAMTypeLabel.AutoSize = true;
            this.RAMTypeLabel.Location = new System.Drawing.Point(6, 20);
            this.RAMTypeLabel.Name = "RAMTypeLabel";
            this.RAMTypeLabel.Size = new System.Drawing.Size(32, 16);
            this.RAMTypeLabel.TabIndex = 0;
            this.RAMTypeLabel.Text = "Тип";
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
            this.RAMEditButton.Location = new System.Drawing.Point(-145, -237);
            this.RAMEditButton.Name = "RAMEditButton";
            this.RAMEditButton.Size = new System.Drawing.Size(286, 39);
            this.RAMEditButton.TabIndex = 10;
            this.RAMEditButton.Text = "Изменить";
            this.RAMEditButton.UseVisualStyleBackColor = true;
            // 
            // RAMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 208);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RAMEditButton);
            this.Controls.Add(this.RAMGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RAMForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОЗУ";
            this.RAMGroupBox.ResumeLayout(false);
            this.RAMGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RAMGroupBox;
        private System.Windows.Forms.ComboBox RAMVolumeSizeComboBox;
        private System.Windows.Forms.TextBox RAMVolumeTextBox;
        private System.Windows.Forms.Label RAMVolumeLabel;
        private System.Windows.Forms.ComboBox RAMTypeComboBox;
        private System.Windows.Forms.Label RAMTypeLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RAMEditButton;
    }
}