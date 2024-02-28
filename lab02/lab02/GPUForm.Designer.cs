namespace lab02 {
    partial class GPUForm {
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
            this.GPUGroupBox = new System.Windows.Forms.GroupBox();
            this.GPUDX11SupportCheckBox = new System.Windows.Forms.CheckBox();
            this.GPUMemorySizeComboBox = new System.Windows.Forms.ComboBox();
            this.GPUFrequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.GPUMaxFrequencySizeComboBox = new System.Windows.Forms.ComboBox();
            this.GPUMaxFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.GPUMaxFrequencyLabel = new System.Windows.Forms.Label();
            this.GPUWorkingFrequencySizeComboBox = new System.Windows.Forms.ComboBox();
            this.GPUWorkingFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.GPUWorkingFrequencyLabel = new System.Windows.Forms.Label();
            this.GPUMemoryTextBox = new System.Windows.Forms.TextBox();
            this.GPUModelTextBox = new System.Windows.Forms.TextBox();
            this.GPUMemoryLabel = new System.Windows.Forms.Label();
            this.GPUManufacturerLabel = new System.Windows.Forms.Label();
            this.GPUModelLabel = new System.Windows.Forms.Label();
            this.GPUManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.GPUSeriesTextBox = new System.Windows.Forms.TextBox();
            this.GPUSeriesLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.GPUGroupBox.SuspendLayout();
            this.GPUFrequencyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPUGroupBox
            // 
            this.GPUGroupBox.Controls.Add(this.GPUDX11SupportCheckBox);
            this.GPUGroupBox.Controls.Add(this.GPUMemorySizeComboBox);
            this.GPUGroupBox.Controls.Add(this.GPUFrequencyGroupBox);
            this.GPUGroupBox.Controls.Add(this.GPUMemoryTextBox);
            this.GPUGroupBox.Controls.Add(this.GPUModelTextBox);
            this.GPUGroupBox.Controls.Add(this.GPUMemoryLabel);
            this.GPUGroupBox.Controls.Add(this.GPUManufacturerLabel);
            this.GPUGroupBox.Controls.Add(this.GPUModelLabel);
            this.GPUGroupBox.Controls.Add(this.GPUManufacturerTextBox);
            this.GPUGroupBox.Controls.Add(this.GPUSeriesTextBox);
            this.GPUGroupBox.Controls.Add(this.GPUSeriesLabel);
            this.GPUGroupBox.Location = new System.Drawing.Point(12, 12);
            this.GPUGroupBox.Name = "GPUGroupBox";
            this.GPUGroupBox.Size = new System.Drawing.Size(300, 377);
            this.GPUGroupBox.TabIndex = 0;
            this.GPUGroupBox.TabStop = false;
            this.GPUGroupBox.Text = "Видеокарта";
            // 
            // GPUDX11SupportCheckBox
            // 
            this.GPUDX11SupportCheckBox.AutoSize = true;
            this.GPUDX11SupportCheckBox.Location = new System.Drawing.Point(6, 347);
            this.GPUDX11SupportCheckBox.Name = "GPUDX11SupportCheckBox";
            this.GPUDX11SupportCheckBox.Size = new System.Drawing.Size(163, 20);
            this.GPUDX11SupportCheckBox.TabIndex = 6;
            this.GPUDX11SupportCheckBox.Text = "Поддержка DirectX11";
            this.GPUDX11SupportCheckBox.UseVisualStyleBackColor = true;
            // 
            // GPUMemorySizeComboBox
            // 
            this.GPUMemorySizeComboBox.FormattingEnabled = true;
            this.GPUMemorySizeComboBox.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.GPUMemorySizeComboBox.Location = new System.Drawing.Point(212, 186);
            this.GPUMemorySizeComboBox.Name = "GPUMemorySizeComboBox";
            this.GPUMemorySizeComboBox.Size = new System.Drawing.Size(82, 24);
            this.GPUMemorySizeComboBox.TabIndex = 4;
            this.GPUMemorySizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // GPUFrequencyGroupBox
            // 
            this.GPUFrequencyGroupBox.Controls.Add(this.GPUMaxFrequencySizeComboBox);
            this.GPUFrequencyGroupBox.Controls.Add(this.GPUMaxFrequencyTextBox);
            this.GPUFrequencyGroupBox.Controls.Add(this.GPUMaxFrequencyLabel);
            this.GPUFrequencyGroupBox.Controls.Add(this.GPUWorkingFrequencySizeComboBox);
            this.GPUFrequencyGroupBox.Controls.Add(this.GPUWorkingFrequencyTextBox);
            this.GPUFrequencyGroupBox.Controls.Add(this.GPUWorkingFrequencyLabel);
            this.GPUFrequencyGroupBox.Location = new System.Drawing.Point(6, 216);
            this.GPUFrequencyGroupBox.Name = "GPUFrequencyGroupBox";
            this.GPUFrequencyGroupBox.Size = new System.Drawing.Size(288, 125);
            this.GPUFrequencyGroupBox.TabIndex = 5;
            this.GPUFrequencyGroupBox.TabStop = false;
            this.GPUFrequencyGroupBox.Text = "Частота";
            // 
            // GPUMaxFrequencySizeComboBox
            // 
            this.GPUMaxFrequencySizeComboBox.FormattingEnabled = true;
            this.GPUMaxFrequencySizeComboBox.Items.AddRange(new object[] {
            "Hz",
            "MHz",
            "GHz"});
            this.GPUMaxFrequencySizeComboBox.Location = new System.Drawing.Point(199, 89);
            this.GPUMaxFrequencySizeComboBox.Name = "GPUMaxFrequencySizeComboBox";
            this.GPUMaxFrequencySizeComboBox.Size = new System.Drawing.Size(82, 24);
            this.GPUMaxFrequencySizeComboBox.TabIndex = 3;
            this.GPUMaxFrequencySizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // GPUMaxFrequencyTextBox
            // 
            this.GPUMaxFrequencyTextBox.Location = new System.Drawing.Point(6, 89);
            this.GPUMaxFrequencyTextBox.MaxLength = 8;
            this.GPUMaxFrequencyTextBox.Name = "GPUMaxFrequencyTextBox";
            this.GPUMaxFrequencyTextBox.Size = new System.Drawing.Size(187, 22);
            this.GPUMaxFrequencyTextBox.TabIndex = 2;
            this.GPUMaxFrequencyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleInputKeyPressHandler);
            // 
            // GPUMaxFrequencyLabel
            // 
            this.GPUMaxFrequencyLabel.AutoSize = true;
            this.GPUMaxFrequencyLabel.Location = new System.Drawing.Point(6, 68);
            this.GPUMaxFrequencyLabel.Name = "GPUMaxFrequencyLabel";
            this.GPUMaxFrequencyLabel.Size = new System.Drawing.Size(103, 16);
            this.GPUMaxFrequencyLabel.TabIndex = 4;
            this.GPUMaxFrequencyLabel.Text = "Максимальная";
            // 
            // GPUWorkingFrequencySizeComboBox
            // 
            this.GPUWorkingFrequencySizeComboBox.FormattingEnabled = true;
            this.GPUWorkingFrequencySizeComboBox.Items.AddRange(new object[] {
            "Hz",
            "MHz",
            "GHz"});
            this.GPUWorkingFrequencySizeComboBox.Location = new System.Drawing.Point(199, 41);
            this.GPUWorkingFrequencySizeComboBox.Name = "GPUWorkingFrequencySizeComboBox";
            this.GPUWorkingFrequencySizeComboBox.Size = new System.Drawing.Size(82, 24);
            this.GPUWorkingFrequencySizeComboBox.TabIndex = 1;
            this.GPUWorkingFrequencySizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // GPUWorkingFrequencyTextBox
            // 
            this.GPUWorkingFrequencyTextBox.Location = new System.Drawing.Point(6, 41);
            this.GPUWorkingFrequencyTextBox.MaxLength = 8;
            this.GPUWorkingFrequencyTextBox.Name = "GPUWorkingFrequencyTextBox";
            this.GPUWorkingFrequencyTextBox.Size = new System.Drawing.Size(187, 22);
            this.GPUWorkingFrequencyTextBox.TabIndex = 0;
            this.GPUWorkingFrequencyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleInputKeyPressHandler);
            // 
            // GPUWorkingFrequencyLabel
            // 
            this.GPUWorkingFrequencyLabel.AutoSize = true;
            this.GPUWorkingFrequencyLabel.Location = new System.Drawing.Point(6, 20);
            this.GPUWorkingFrequencyLabel.Name = "GPUWorkingFrequencyLabel";
            this.GPUWorkingFrequencyLabel.Size = new System.Drawing.Size(63, 16);
            this.GPUWorkingFrequencyLabel.TabIndex = 0;
            this.GPUWorkingFrequencyLabel.Text = "Рабочая";
            // 
            // GPUMemoryTextBox
            // 
            this.GPUMemoryTextBox.Location = new System.Drawing.Point(6, 186);
            this.GPUMemoryTextBox.MaxLength = 8;
            this.GPUMemoryTextBox.Name = "GPUMemoryTextBox";
            this.GPUMemoryTextBox.Size = new System.Drawing.Size(200, 22);
            this.GPUMemoryTextBox.TabIndex = 3;
            this.GPUMemoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // GPUModelTextBox
            // 
            this.GPUModelTextBox.Location = new System.Drawing.Point(6, 138);
            this.GPUModelTextBox.Name = "GPUModelTextBox";
            this.GPUModelTextBox.Size = new System.Drawing.Size(288, 22);
            this.GPUModelTextBox.TabIndex = 2;
            // 
            // GPUMemoryLabel
            // 
            this.GPUMemoryLabel.AutoSize = true;
            this.GPUMemoryLabel.Location = new System.Drawing.Point(6, 165);
            this.GPUMemoryLabel.Name = "GPUMemoryLabel";
            this.GPUMemoryLabel.Size = new System.Drawing.Size(101, 16);
            this.GPUMemoryLabel.TabIndex = 10;
            this.GPUMemoryLabel.Text = "Объем памяти";
            // 
            // GPUManufacturerLabel
            // 
            this.GPUManufacturerLabel.AutoSize = true;
            this.GPUManufacturerLabel.Location = new System.Drawing.Point(6, 20);
            this.GPUManufacturerLabel.Name = "GPUManufacturerLabel";
            this.GPUManufacturerLabel.Size = new System.Drawing.Size(111, 16);
            this.GPUManufacturerLabel.TabIndex = 8;
            this.GPUManufacturerLabel.Text = "Производитель";
            // 
            // GPUModelLabel
            // 
            this.GPUModelLabel.AutoSize = true;
            this.GPUModelLabel.Location = new System.Drawing.Point(6, 117);
            this.GPUModelLabel.Name = "GPUModelLabel";
            this.GPUModelLabel.Size = new System.Drawing.Size(57, 16);
            this.GPUModelLabel.TabIndex = 12;
            this.GPUModelLabel.Text = "Модель";
            // 
            // GPUManufacturerTextBox
            // 
            this.GPUManufacturerTextBox.Location = new System.Drawing.Point(6, 41);
            this.GPUManufacturerTextBox.Name = "GPUManufacturerTextBox";
            this.GPUManufacturerTextBox.Size = new System.Drawing.Size(288, 22);
            this.GPUManufacturerTextBox.TabIndex = 0;
            // 
            // GPUSeriesTextBox
            // 
            this.GPUSeriesTextBox.Location = new System.Drawing.Point(6, 90);
            this.GPUSeriesTextBox.Name = "GPUSeriesTextBox";
            this.GPUSeriesTextBox.Size = new System.Drawing.Size(288, 22);
            this.GPUSeriesTextBox.TabIndex = 1;
            // 
            // GPUSeriesLabel
            // 
            this.GPUSeriesLabel.AutoSize = true;
            this.GPUSeriesLabel.Location = new System.Drawing.Point(6, 68);
            this.GPUSeriesLabel.Name = "GPUSeriesLabel";
            this.GPUSeriesLabel.Size = new System.Drawing.Size(47, 16);
            this.GPUSeriesLabel.TabIndex = 11;
            this.GPUSeriesLabel.Text = "Серия";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(162, 395);
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
            this.SaveButton.Location = new System.Drawing.Point(12, 395);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 50);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GPUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GPUGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GPUForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видеокарта";
            this.GPUGroupBox.ResumeLayout(false);
            this.GPUGroupBox.PerformLayout();
            this.GPUFrequencyGroupBox.ResumeLayout(false);
            this.GPUFrequencyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPUGroupBox;
        private System.Windows.Forms.CheckBox GPUDX11SupportCheckBox;
        private System.Windows.Forms.ComboBox GPUMemorySizeComboBox;
        private System.Windows.Forms.GroupBox GPUFrequencyGroupBox;
        private System.Windows.Forms.ComboBox GPUMaxFrequencySizeComboBox;
        private System.Windows.Forms.TextBox GPUMaxFrequencyTextBox;
        private System.Windows.Forms.Label GPUMaxFrequencyLabel;
        private System.Windows.Forms.ComboBox GPUWorkingFrequencySizeComboBox;
        private System.Windows.Forms.TextBox GPUWorkingFrequencyTextBox;
        private System.Windows.Forms.Label GPUWorkingFrequencyLabel;
        private System.Windows.Forms.TextBox GPUMemoryTextBox;
        private System.Windows.Forms.TextBox GPUModelTextBox;
        private System.Windows.Forms.Label GPUMemoryLabel;
        private System.Windows.Forms.Label GPUManufacturerLabel;
        private System.Windows.Forms.Label GPUModelLabel;
        private System.Windows.Forms.TextBox GPUManufacturerTextBox;
        private System.Windows.Forms.TextBox GPUSeriesTextBox;
        private System.Windows.Forms.Label GPUSeriesLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
    }
}