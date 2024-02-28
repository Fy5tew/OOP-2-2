namespace lab02 {
    partial class CPUForm {
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
            this.CPUGroupBox = new System.Windows.Forms.GroupBox();
            this.CPUCacheGroupBox = new System.Windows.Forms.GroupBox();
            this.CPUCacheL3SizeComboBox = new System.Windows.Forms.ComboBox();
            this.CPUCacheL3TextBox = new System.Windows.Forms.TextBox();
            this.CPUCacheL3Label = new System.Windows.Forms.Label();
            this.CPUCacheL2SizeComboBox = new System.Windows.Forms.ComboBox();
            this.CPUCacheL2TextBox = new System.Windows.Forms.TextBox();
            this.CPUCacheL2Label = new System.Windows.Forms.Label();
            this.CPUCacheL1SizeComboBox = new System.Windows.Forms.ComboBox();
            this.CPUCacheL1TextBox = new System.Windows.Forms.TextBox();
            this.CPUCacheL1Label = new System.Windows.Forms.Label();
            this.CPUArchitectureGroupBox = new System.Windows.Forms.GroupBox();
            this.CPUArchitecture64RadioButton = new System.Windows.Forms.RadioButton();
            this.CPUArchitecture32RadioButton = new System.Windows.Forms.RadioButton();
            this.CPUFrequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.CPUMaxFrequencySizeComboBox = new System.Windows.Forms.ComboBox();
            this.CPUMaxFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.CPUMaxFrequencyLabel = new System.Windows.Forms.Label();
            this.CPUWorkingFrequencySizeComboBox = new System.Windows.Forms.ComboBox();
            this.CPUWorkingFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.CPUWorkingFrequencyLabel = new System.Windows.Forms.Label();
            this.CPUCoresTextBox = new System.Windows.Forms.TextBox();
            this.CPUCoresLabel = new System.Windows.Forms.Label();
            this.CPUModelTextBox = new System.Windows.Forms.TextBox();
            this.CPUModelLabel = new System.Windows.Forms.Label();
            this.CPUSeriesTextBox = new System.Windows.Forms.TextBox();
            this.CPUSeriesLabel = new System.Windows.Forms.Label();
            this.CPUManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.CPUManufacturerLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CPUGroupBox.SuspendLayout();
            this.CPUCacheGroupBox.SuspendLayout();
            this.CPUArchitectureGroupBox.SuspendLayout();
            this.CPUFrequencyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPUGroupBox
            // 
            this.CPUGroupBox.Controls.Add(this.CPUCacheGroupBox);
            this.CPUGroupBox.Controls.Add(this.CPUArchitectureGroupBox);
            this.CPUGroupBox.Controls.Add(this.CPUFrequencyGroupBox);
            this.CPUGroupBox.Controls.Add(this.CPUCoresTextBox);
            this.CPUGroupBox.Controls.Add(this.CPUCoresLabel);
            this.CPUGroupBox.Controls.Add(this.CPUModelTextBox);
            this.CPUGroupBox.Controls.Add(this.CPUModelLabel);
            this.CPUGroupBox.Controls.Add(this.CPUSeriesTextBox);
            this.CPUGroupBox.Controls.Add(this.CPUSeriesLabel);
            this.CPUGroupBox.Controls.Add(this.CPUManufacturerTextBox);
            this.CPUGroupBox.Controls.Add(this.CPUManufacturerLabel);
            this.CPUGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUGroupBox.Location = new System.Drawing.Point(12, 12);
            this.CPUGroupBox.Name = "CPUGroupBox";
            this.CPUGroupBox.Size = new System.Drawing.Size(300, 525);
            this.CPUGroupBox.TabIndex = 0;
            this.CPUGroupBox.TabStop = false;
            this.CPUGroupBox.Text = "Процессор";
            // 
            // CPUCacheGroupBox
            // 
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL3SizeComboBox);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL3TextBox);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL3Label);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL2SizeComboBox);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL2TextBox);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL2Label);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL1SizeComboBox);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL1TextBox);
            this.CPUCacheGroupBox.Controls.Add(this.CPUCacheL1Label);
            this.CPUCacheGroupBox.Location = new System.Drawing.Point(6, 406);
            this.CPUCacheGroupBox.Name = "CPUCacheGroupBox";
            this.CPUCacheGroupBox.Size = new System.Drawing.Size(288, 115);
            this.CPUCacheGroupBox.TabIndex = 6;
            this.CPUCacheGroupBox.TabStop = false;
            this.CPUCacheGroupBox.Text = "Размер кэша";
            // 
            // CPUCacheL3SizeComboBox
            // 
            this.CPUCacheL3SizeComboBox.FormattingEnabled = true;
            this.CPUCacheL3SizeComboBox.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.CPUCacheL3SizeComboBox.Location = new System.Drawing.Point(199, 81);
            this.CPUCacheL3SizeComboBox.Name = "CPUCacheL3SizeComboBox";
            this.CPUCacheL3SizeComboBox.Size = new System.Drawing.Size(82, 26);
            this.CPUCacheL3SizeComboBox.TabIndex = 5;
            this.CPUCacheL3SizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // CPUCacheL3TextBox
            // 
            this.CPUCacheL3TextBox.Location = new System.Drawing.Point(36, 81);
            this.CPUCacheL3TextBox.MaxLength = 8;
            this.CPUCacheL3TextBox.Name = "CPUCacheL3TextBox";
            this.CPUCacheL3TextBox.Size = new System.Drawing.Size(156, 24);
            this.CPUCacheL3TextBox.TabIndex = 4;
            this.CPUCacheL3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // CPUCacheL3Label
            // 
            this.CPUCacheL3Label.AutoSize = true;
            this.CPUCacheL3Label.Location = new System.Drawing.Point(6, 84);
            this.CPUCacheL3Label.Name = "CPUCacheL3Label";
            this.CPUCacheL3Label.Size = new System.Drawing.Size(24, 18);
            this.CPUCacheL3Label.TabIndex = 6;
            this.CPUCacheL3Label.Text = "L3";
            // 
            // CPUCacheL2SizeComboBox
            // 
            this.CPUCacheL2SizeComboBox.FormattingEnabled = true;
            this.CPUCacheL2SizeComboBox.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.CPUCacheL2SizeComboBox.Location = new System.Drawing.Point(199, 51);
            this.CPUCacheL2SizeComboBox.Name = "CPUCacheL2SizeComboBox";
            this.CPUCacheL2SizeComboBox.Size = new System.Drawing.Size(82, 26);
            this.CPUCacheL2SizeComboBox.TabIndex = 3;
            this.CPUCacheL2SizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // CPUCacheL2TextBox
            // 
            this.CPUCacheL2TextBox.Location = new System.Drawing.Point(36, 51);
            this.CPUCacheL2TextBox.MaxLength = 8;
            this.CPUCacheL2TextBox.Name = "CPUCacheL2TextBox";
            this.CPUCacheL2TextBox.Size = new System.Drawing.Size(156, 24);
            this.CPUCacheL2TextBox.TabIndex = 2;
            this.CPUCacheL2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // CPUCacheL2Label
            // 
            this.CPUCacheL2Label.AutoSize = true;
            this.CPUCacheL2Label.Location = new System.Drawing.Point(6, 54);
            this.CPUCacheL2Label.Name = "CPUCacheL2Label";
            this.CPUCacheL2Label.Size = new System.Drawing.Size(24, 18);
            this.CPUCacheL2Label.TabIndex = 3;
            this.CPUCacheL2Label.Text = "L2";
            // 
            // CPUCacheL1SizeComboBox
            // 
            this.CPUCacheL1SizeComboBox.FormattingEnabled = true;
            this.CPUCacheL1SizeComboBox.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.CPUCacheL1SizeComboBox.Location = new System.Drawing.Point(199, 21);
            this.CPUCacheL1SizeComboBox.Name = "CPUCacheL1SizeComboBox";
            this.CPUCacheL1SizeComboBox.Size = new System.Drawing.Size(82, 26);
            this.CPUCacheL1SizeComboBox.TabIndex = 1;
            this.CPUCacheL1SizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // CPUCacheL1TextBox
            // 
            this.CPUCacheL1TextBox.Location = new System.Drawing.Point(37, 21);
            this.CPUCacheL1TextBox.MaxLength = 8;
            this.CPUCacheL1TextBox.Name = "CPUCacheL1TextBox";
            this.CPUCacheL1TextBox.Size = new System.Drawing.Size(156, 24);
            this.CPUCacheL1TextBox.TabIndex = 0;
            this.CPUCacheL1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // CPUCacheL1Label
            // 
            this.CPUCacheL1Label.AutoSize = true;
            this.CPUCacheL1Label.Location = new System.Drawing.Point(7, 24);
            this.CPUCacheL1Label.Name = "CPUCacheL1Label";
            this.CPUCacheL1Label.Size = new System.Drawing.Size(24, 18);
            this.CPUCacheL1Label.TabIndex = 0;
            this.CPUCacheL1Label.Text = "L1";
            // 
            // CPUArchitectureGroupBox
            // 
            this.CPUArchitectureGroupBox.Controls.Add(this.CPUArchitecture64RadioButton);
            this.CPUArchitectureGroupBox.Controls.Add(this.CPUArchitecture32RadioButton);
            this.CPUArchitectureGroupBox.Location = new System.Drawing.Point(6, 347);
            this.CPUArchitectureGroupBox.Name = "CPUArchitectureGroupBox";
            this.CPUArchitectureGroupBox.Size = new System.Drawing.Size(288, 53);
            this.CPUArchitectureGroupBox.TabIndex = 5;
            this.CPUArchitectureGroupBox.TabStop = false;
            this.CPUArchitectureGroupBox.Text = "Архитектура";
            // 
            // CPUArchitecture64RadioButton
            // 
            this.CPUArchitecture64RadioButton.AutoSize = true;
            this.CPUArchitecture64RadioButton.Location = new System.Drawing.Point(125, 23);
            this.CPUArchitecture64RadioButton.Name = "CPUArchitecture64RadioButton";
            this.CPUArchitecture64RadioButton.Size = new System.Drawing.Size(67, 22);
            this.CPUArchitecture64RadioButton.TabIndex = 1;
            this.CPUArchitecture64RadioButton.TabStop = true;
            this.CPUArchitecture64RadioButton.Text = "64-Bit";
            this.CPUArchitecture64RadioButton.UseVisualStyleBackColor = true;
            // 
            // CPUArchitecture32RadioButton
            // 
            this.CPUArchitecture32RadioButton.AutoSize = true;
            this.CPUArchitecture32RadioButton.Location = new System.Drawing.Point(6, 23);
            this.CPUArchitecture32RadioButton.Name = "CPUArchitecture32RadioButton";
            this.CPUArchitecture32RadioButton.Size = new System.Drawing.Size(67, 22);
            this.CPUArchitecture32RadioButton.TabIndex = 0;
            this.CPUArchitecture32RadioButton.TabStop = true;
            this.CPUArchitecture32RadioButton.Text = "32-Bit";
            this.CPUArchitecture32RadioButton.UseVisualStyleBackColor = true;
            // 
            // CPUFrequencyGroupBox
            // 
            this.CPUFrequencyGroupBox.Controls.Add(this.CPUMaxFrequencySizeComboBox);
            this.CPUFrequencyGroupBox.Controls.Add(this.CPUMaxFrequencyTextBox);
            this.CPUFrequencyGroupBox.Controls.Add(this.CPUMaxFrequencyLabel);
            this.CPUFrequencyGroupBox.Controls.Add(this.CPUWorkingFrequencySizeComboBox);
            this.CPUFrequencyGroupBox.Controls.Add(this.CPUWorkingFrequencyTextBox);
            this.CPUFrequencyGroupBox.Controls.Add(this.CPUWorkingFrequencyLabel);
            this.CPUFrequencyGroupBox.Location = new System.Drawing.Point(6, 216);
            this.CPUFrequencyGroupBox.Name = "CPUFrequencyGroupBox";
            this.CPUFrequencyGroupBox.Size = new System.Drawing.Size(288, 125);
            this.CPUFrequencyGroupBox.TabIndex = 4;
            this.CPUFrequencyGroupBox.TabStop = false;
            this.CPUFrequencyGroupBox.Text = "Частота";
            // 
            // CPUMaxFrequencySizeComboBox
            // 
            this.CPUMaxFrequencySizeComboBox.FormattingEnabled = true;
            this.CPUMaxFrequencySizeComboBox.Items.AddRange(new object[] {
            "Hz",
            "MHz",
            "GHz"});
            this.CPUMaxFrequencySizeComboBox.Location = new System.Drawing.Point(199, 89);
            this.CPUMaxFrequencySizeComboBox.Name = "CPUMaxFrequencySizeComboBox";
            this.CPUMaxFrequencySizeComboBox.Size = new System.Drawing.Size(82, 26);
            this.CPUMaxFrequencySizeComboBox.TabIndex = 3;
            this.CPUMaxFrequencySizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // CPUMaxFrequencyTextBox
            // 
            this.CPUMaxFrequencyTextBox.Location = new System.Drawing.Point(6, 89);
            this.CPUMaxFrequencyTextBox.MaxLength = 8;
            this.CPUMaxFrequencyTextBox.Name = "CPUMaxFrequencyTextBox";
            this.CPUMaxFrequencyTextBox.Size = new System.Drawing.Size(187, 24);
            this.CPUMaxFrequencyTextBox.TabIndex = 2;
            this.CPUMaxFrequencyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleInputKeyPressHandler);
            // 
            // CPUMaxFrequencyLabel
            // 
            this.CPUMaxFrequencyLabel.AutoSize = true;
            this.CPUMaxFrequencyLabel.Location = new System.Drawing.Point(6, 68);
            this.CPUMaxFrequencyLabel.Name = "CPUMaxFrequencyLabel";
            this.CPUMaxFrequencyLabel.Size = new System.Drawing.Size(113, 18);
            this.CPUMaxFrequencyLabel.TabIndex = 4;
            this.CPUMaxFrequencyLabel.Text = "Максимальная";
            // 
            // CPUWorkingFrequencySizeComboBox
            // 
            this.CPUWorkingFrequencySizeComboBox.FormattingEnabled = true;
            this.CPUWorkingFrequencySizeComboBox.Items.AddRange(new object[] {
            "Hz",
            "MHz",
            "GHz"});
            this.CPUWorkingFrequencySizeComboBox.Location = new System.Drawing.Point(199, 41);
            this.CPUWorkingFrequencySizeComboBox.Name = "CPUWorkingFrequencySizeComboBox";
            this.CPUWorkingFrequencySizeComboBox.Size = new System.Drawing.Size(82, 26);
            this.CPUWorkingFrequencySizeComboBox.TabIndex = 1;
            this.CPUWorkingFrequencySizeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // CPUWorkingFrequencyTextBox
            // 
            this.CPUWorkingFrequencyTextBox.Location = new System.Drawing.Point(6, 41);
            this.CPUWorkingFrequencyTextBox.MaxLength = 8;
            this.CPUWorkingFrequencyTextBox.Name = "CPUWorkingFrequencyTextBox";
            this.CPUWorkingFrequencyTextBox.Size = new System.Drawing.Size(187, 24);
            this.CPUWorkingFrequencyTextBox.TabIndex = 0;
            this.CPUWorkingFrequencyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoubleInputKeyPressHandler);
            // 
            // CPUWorkingFrequencyLabel
            // 
            this.CPUWorkingFrequencyLabel.AutoSize = true;
            this.CPUWorkingFrequencyLabel.Location = new System.Drawing.Point(6, 20);
            this.CPUWorkingFrequencyLabel.Name = "CPUWorkingFrequencyLabel";
            this.CPUWorkingFrequencyLabel.Size = new System.Drawing.Size(68, 18);
            this.CPUWorkingFrequencyLabel.TabIndex = 0;
            this.CPUWorkingFrequencyLabel.Text = "Рабочая";
            // 
            // CPUCoresTextBox
            // 
            this.CPUCoresTextBox.Location = new System.Drawing.Point(6, 186);
            this.CPUCoresTextBox.MaxLength = 8;
            this.CPUCoresTextBox.Name = "CPUCoresTextBox";
            this.CPUCoresTextBox.Size = new System.Drawing.Size(288, 24);
            this.CPUCoresTextBox.TabIndex = 3;
            this.CPUCoresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntInputKeyPressHandler);
            // 
            // CPUCoresLabel
            // 
            this.CPUCoresLabel.AutoSize = true;
            this.CPUCoresLabel.Location = new System.Drawing.Point(6, 165);
            this.CPUCoresLabel.Name = "CPUCoresLabel";
            this.CPUCoresLabel.Size = new System.Drawing.Size(129, 18);
            this.CPUCoresLabel.TabIndex = 6;
            this.CPUCoresLabel.Text = "Количество ядер";
            // 
            // CPUModelTextBox
            // 
            this.CPUModelTextBox.Location = new System.Drawing.Point(6, 138);
            this.CPUModelTextBox.Name = "CPUModelTextBox";
            this.CPUModelTextBox.Size = new System.Drawing.Size(288, 24);
            this.CPUModelTextBox.TabIndex = 2;
            // 
            // CPUModelLabel
            // 
            this.CPUModelLabel.AutoSize = true;
            this.CPUModelLabel.Location = new System.Drawing.Point(6, 117);
            this.CPUModelLabel.Name = "CPUModelLabel";
            this.CPUModelLabel.Size = new System.Drawing.Size(64, 18);
            this.CPUModelLabel.TabIndex = 4;
            this.CPUModelLabel.Text = "Модель";
            // 
            // CPUSeriesTextBox
            // 
            this.CPUSeriesTextBox.Location = new System.Drawing.Point(6, 90);
            this.CPUSeriesTextBox.Name = "CPUSeriesTextBox";
            this.CPUSeriesTextBox.Size = new System.Drawing.Size(288, 24);
            this.CPUSeriesTextBox.TabIndex = 1;
            // 
            // CPUSeriesLabel
            // 
            this.CPUSeriesLabel.AutoSize = true;
            this.CPUSeriesLabel.Location = new System.Drawing.Point(6, 68);
            this.CPUSeriesLabel.Name = "CPUSeriesLabel";
            this.CPUSeriesLabel.Size = new System.Drawing.Size(51, 18);
            this.CPUSeriesLabel.TabIndex = 2;
            this.CPUSeriesLabel.Text = "Серия";
            // 
            // CPUManufacturerTextBox
            // 
            this.CPUManufacturerTextBox.Location = new System.Drawing.Point(6, 41);
            this.CPUManufacturerTextBox.Name = "CPUManufacturerTextBox";
            this.CPUManufacturerTextBox.Size = new System.Drawing.Size(288, 24);
            this.CPUManufacturerTextBox.TabIndex = 0;
            // 
            // CPUManufacturerLabel
            // 
            this.CPUManufacturerLabel.AutoSize = true;
            this.CPUManufacturerLabel.Location = new System.Drawing.Point(6, 20);
            this.CPUManufacturerLabel.Name = "CPUManufacturerLabel";
            this.CPUManufacturerLabel.Size = new System.Drawing.Size(118, 18);
            this.CPUManufacturerLabel.TabIndex = 0;
            this.CPUManufacturerLabel.Text = "Производитель";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(162, 543);
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
            this.SaveButton.Location = new System.Drawing.Point(12, 543);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 50);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CPUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 600);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CPUGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CPUForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Процессор";
            this.CPUGroupBox.ResumeLayout(false);
            this.CPUGroupBox.PerformLayout();
            this.CPUCacheGroupBox.ResumeLayout(false);
            this.CPUCacheGroupBox.PerformLayout();
            this.CPUArchitectureGroupBox.ResumeLayout(false);
            this.CPUArchitectureGroupBox.PerformLayout();
            this.CPUFrequencyGroupBox.ResumeLayout(false);
            this.CPUFrequencyGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CPUGroupBox;
        private System.Windows.Forms.GroupBox CPUCacheGroupBox;
        private System.Windows.Forms.ComboBox CPUCacheL3SizeComboBox;
        private System.Windows.Forms.TextBox CPUCacheL3TextBox;
        private System.Windows.Forms.Label CPUCacheL3Label;
        private System.Windows.Forms.ComboBox CPUCacheL2SizeComboBox;
        private System.Windows.Forms.TextBox CPUCacheL2TextBox;
        private System.Windows.Forms.Label CPUCacheL2Label;
        private System.Windows.Forms.ComboBox CPUCacheL1SizeComboBox;
        private System.Windows.Forms.TextBox CPUCacheL1TextBox;
        private System.Windows.Forms.Label CPUCacheL1Label;
        private System.Windows.Forms.GroupBox CPUArchitectureGroupBox;
        private System.Windows.Forms.RadioButton CPUArchitecture64RadioButton;
        private System.Windows.Forms.RadioButton CPUArchitecture32RadioButton;
        private System.Windows.Forms.GroupBox CPUFrequencyGroupBox;
        private System.Windows.Forms.ComboBox CPUMaxFrequencySizeComboBox;
        private System.Windows.Forms.TextBox CPUMaxFrequencyTextBox;
        private System.Windows.Forms.Label CPUMaxFrequencyLabel;
        private System.Windows.Forms.ComboBox CPUWorkingFrequencySizeComboBox;
        private System.Windows.Forms.TextBox CPUWorkingFrequencyTextBox;
        private System.Windows.Forms.Label CPUWorkingFrequencyLabel;
        private System.Windows.Forms.TextBox CPUCoresTextBox;
        private System.Windows.Forms.Label CPUCoresLabel;
        private System.Windows.Forms.TextBox CPUModelTextBox;
        private System.Windows.Forms.Label CPUModelLabel;
        private System.Windows.Forms.TextBox CPUSeriesTextBox;
        private System.Windows.Forms.Label CPUSeriesLabel;
        private System.Windows.Forms.TextBox CPUManufacturerTextBox;
        private System.Windows.Forms.Label CPUManufacturerLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SaveButton;
    }
}