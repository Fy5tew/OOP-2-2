namespace lab02 {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PCGroupBox = new System.Windows.Forms.GroupBox();
            this.GPUGroupBox = new System.Windows.Forms.GroupBox();
            this.GPUEditButton = new System.Windows.Forms.Button();
            this.GPUTextBox = new System.Windows.Forms.TextBox();
            this.CPUGroupBox = new System.Windows.Forms.GroupBox();
            this.CPUEditButton = new System.Windows.Forms.Button();
            this.CPUTextBox = new System.Windows.Forms.TextBox();
            this.ROMGroupBox = new System.Windows.Forms.GroupBox();
            this.ROMEditButton = new System.Windows.Forms.Button();
            this.ROMTextBox = new System.Windows.Forms.TextBox();
            this.RAMGroupBox = new System.Windows.Forms.GroupBox();
            this.RAMEditButton = new System.Windows.Forms.Button();
            this.RAMTextBox = new System.Windows.Forms.TextBox();
            this.WatchButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PCTimeLabel = new System.Windows.Forms.Label();
            this.PCTimeInput = new System.Windows.Forms.MaskedTextBox();
            this.PCDateLabel = new System.Windows.Forms.Label();
            this.PCDateInput = new System.Windows.Forms.DateTimePicker();
            this.PCTypeLabel = new System.Windows.Forms.Label();
            this.PCNameTextBox = new System.Windows.Forms.TextBox();
            this.PCTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PCNameLabel = new System.Windows.Forms.Label();
            this.PCGroupBox.SuspendLayout();
            this.GPUGroupBox.SuspendLayout();
            this.CPUGroupBox.SuspendLayout();
            this.ROMGroupBox.SuspendLayout();
            this.RAMGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCGroupBox
            // 
            this.PCGroupBox.Controls.Add(this.GPUGroupBox);
            this.PCGroupBox.Controls.Add(this.CPUGroupBox);
            this.PCGroupBox.Controls.Add(this.ROMGroupBox);
            this.PCGroupBox.Controls.Add(this.RAMGroupBox);
            this.PCGroupBox.Controls.Add(this.WatchButton);
            this.PCGroupBox.Controls.Add(this.ResetButton);
            this.PCGroupBox.Controls.Add(this.SaveButton);
            this.PCGroupBox.Controls.Add(this.PCTimeLabel);
            this.PCGroupBox.Controls.Add(this.PCTimeInput);
            this.PCGroupBox.Controls.Add(this.PCDateLabel);
            this.PCGroupBox.Controls.Add(this.PCDateInput);
            this.PCGroupBox.Controls.Add(this.PCTypeLabel);
            this.PCGroupBox.Controls.Add(this.PCNameTextBox);
            this.PCGroupBox.Controls.Add(this.PCTypeComboBox);
            this.PCGroupBox.Controls.Add(this.PCNameLabel);
            this.PCGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PCGroupBox.Name = "PCGroupBox";
            this.PCGroupBox.Size = new System.Drawing.Size(630, 763);
            this.PCGroupBox.TabIndex = 0;
            this.PCGroupBox.TabStop = false;
            this.PCGroupBox.Text = "Компьютер";
            // 
            // GPUGroupBox
            // 
            this.GPUGroupBox.Controls.Add(this.GPUEditButton);
            this.GPUGroupBox.Controls.Add(this.GPUTextBox);
            this.GPUGroupBox.Location = new System.Drawing.Point(6, 490);
            this.GPUGroupBox.Name = "GPUGroupBox";
            this.GPUGroupBox.Size = new System.Drawing.Size(615, 153);
            this.GPUGroupBox.TabIndex = 7;
            this.GPUGroupBox.TabStop = false;
            this.GPUGroupBox.Text = "Видеокарта";
            // 
            // GPUEditButton
            // 
            this.GPUEditButton.Location = new System.Drawing.Point(6, 110);
            this.GPUEditButton.Name = "GPUEditButton";
            this.GPUEditButton.Size = new System.Drawing.Size(602, 39);
            this.GPUEditButton.TabIndex = 1;
            this.GPUEditButton.Text = "Изменить";
            this.GPUEditButton.UseVisualStyleBackColor = true;
            this.GPUEditButton.Click += new System.EventHandler(this.GPUEditButton_Click);
            // 
            // GPUTextBox
            // 
            this.GPUTextBox.Enabled = false;
            this.GPUTextBox.Location = new System.Drawing.Point(7, 24);
            this.GPUTextBox.Multiline = true;
            this.GPUTextBox.Name = "GPUTextBox";
            this.GPUTextBox.Size = new System.Drawing.Size(602, 80);
            this.GPUTextBox.TabIndex = 0;
            // 
            // CPUGroupBox
            // 
            this.CPUGroupBox.Controls.Add(this.CPUEditButton);
            this.CPUGroupBox.Controls.Add(this.CPUTextBox);
            this.CPUGroupBox.Location = new System.Drawing.Point(6, 331);
            this.CPUGroupBox.Name = "CPUGroupBox";
            this.CPUGroupBox.Size = new System.Drawing.Size(615, 153);
            this.CPUGroupBox.TabIndex = 6;
            this.CPUGroupBox.TabStop = false;
            this.CPUGroupBox.Text = "Процессор";
            // 
            // CPUEditButton
            // 
            this.CPUEditButton.Location = new System.Drawing.Point(6, 110);
            this.CPUEditButton.Name = "CPUEditButton";
            this.CPUEditButton.Size = new System.Drawing.Size(602, 39);
            this.CPUEditButton.TabIndex = 1;
            this.CPUEditButton.Text = "Изменить";
            this.CPUEditButton.UseVisualStyleBackColor = true;
            this.CPUEditButton.Click += new System.EventHandler(this.CPUEditButton_Click);
            // 
            // CPUTextBox
            // 
            this.CPUTextBox.Enabled = false;
            this.CPUTextBox.Location = new System.Drawing.Point(7, 24);
            this.CPUTextBox.Multiline = true;
            this.CPUTextBox.Name = "CPUTextBox";
            this.CPUTextBox.Size = new System.Drawing.Size(602, 80);
            this.CPUTextBox.TabIndex = 0;
            // 
            // ROMGroupBox
            // 
            this.ROMGroupBox.Controls.Add(this.ROMEditButton);
            this.ROMGroupBox.Controls.Add(this.ROMTextBox);
            this.ROMGroupBox.Location = new System.Drawing.Point(6, 225);
            this.ROMGroupBox.Name = "ROMGroupBox";
            this.ROMGroupBox.Size = new System.Drawing.Size(615, 100);
            this.ROMGroupBox.TabIndex = 5;
            this.ROMGroupBox.TabStop = false;
            this.ROMGroupBox.Text = "ПЗУ";
            // 
            // ROMEditButton
            // 
            this.ROMEditButton.Location = new System.Drawing.Point(7, 55);
            this.ROMEditButton.Name = "ROMEditButton";
            this.ROMEditButton.Size = new System.Drawing.Size(602, 39);
            this.ROMEditButton.TabIndex = 1;
            this.ROMEditButton.Text = "Изменить";
            this.ROMEditButton.UseVisualStyleBackColor = true;
            this.ROMEditButton.Click += new System.EventHandler(this.ROMEditButton_Click);
            // 
            // ROMTextBox
            // 
            this.ROMTextBox.Enabled = false;
            this.ROMTextBox.Location = new System.Drawing.Point(7, 24);
            this.ROMTextBox.Name = "ROMTextBox";
            this.ROMTextBox.Size = new System.Drawing.Size(602, 24);
            this.ROMTextBox.TabIndex = 0;
            // 
            // RAMGroupBox
            // 
            this.RAMGroupBox.Controls.Add(this.RAMEditButton);
            this.RAMGroupBox.Controls.Add(this.RAMTextBox);
            this.RAMGroupBox.Location = new System.Drawing.Point(6, 119);
            this.RAMGroupBox.Name = "RAMGroupBox";
            this.RAMGroupBox.Size = new System.Drawing.Size(615, 100);
            this.RAMGroupBox.TabIndex = 4;
            this.RAMGroupBox.TabStop = false;
            this.RAMGroupBox.Text = "ОЗУ";
            // 
            // RAMEditButton
            // 
            this.RAMEditButton.Location = new System.Drawing.Point(7, 55);
            this.RAMEditButton.Name = "RAMEditButton";
            this.RAMEditButton.Size = new System.Drawing.Size(602, 39);
            this.RAMEditButton.TabIndex = 1;
            this.RAMEditButton.Text = "Изменить";
            this.RAMEditButton.UseVisualStyleBackColor = true;
            this.RAMEditButton.Click += new System.EventHandler(this.RAMEditButton_Click);
            // 
            // RAMTextBox
            // 
            this.RAMTextBox.Enabled = false;
            this.RAMTextBox.Location = new System.Drawing.Point(7, 24);
            this.RAMTextBox.Name = "RAMTextBox";
            this.RAMTextBox.Size = new System.Drawing.Size(602, 24);
            this.RAMTextBox.TabIndex = 0;
            // 
            // WatchButton
            // 
            this.WatchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WatchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WatchButton.ForeColor = System.Drawing.Color.White;
            this.WatchButton.Location = new System.Drawing.Point(6, 705);
            this.WatchButton.Name = "WatchButton";
            this.WatchButton.Size = new System.Drawing.Size(615, 50);
            this.WatchButton.TabIndex = 10;
            this.WatchButton.Text = "Просмотр данных";
            this.WatchButton.UseVisualStyleBackColor = false;
            this.WatchButton.Click += new System.EventHandler(this.WatchButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(328, 649);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(293, 50);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(6, 649);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(300, 50);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PCTimeLabel
            // 
            this.PCTimeLabel.AutoSize = true;
            this.PCTimeLabel.Location = new System.Drawing.Point(318, 70);
            this.PCTimeLabel.Name = "PCTimeLabel";
            this.PCTimeLabel.Size = new System.Drawing.Size(128, 18);
            this.PCTimeLabel.TabIndex = 11;
            this.PCTimeLabel.Text = "Время установки";
            // 
            // PCTimeInput
            // 
            this.PCTimeInput.Location = new System.Drawing.Point(321, 89);
            this.PCTimeInput.Mask = "00:00";
            this.PCTimeInput.Name = "PCTimeInput";
            this.PCTimeInput.Size = new System.Drawing.Size(300, 24);
            this.PCTimeInput.TabIndex = 3;
            this.PCTimeInput.ValidatingType = typeof(System.DateTime);
            // 
            // PCDateLabel
            // 
            this.PCDateLabel.AutoSize = true;
            this.PCDateLabel.Location = new System.Drawing.Point(3, 68);
            this.PCDateLabel.Name = "PCDateLabel";
            this.PCDateLabel.Size = new System.Drawing.Size(118, 18);
            this.PCDateLabel.TabIndex = 9;
            this.PCDateLabel.Text = "Дата установки";
            // 
            // PCDateInput
            // 
            this.PCDateInput.Location = new System.Drawing.Point(6, 89);
            this.PCDateInput.Name = "PCDateInput";
            this.PCDateInput.Size = new System.Drawing.Size(300, 24);
            this.PCDateInput.TabIndex = 2;
            // 
            // PCTypeLabel
            // 
            this.PCTypeLabel.AutoSize = true;
            this.PCTypeLabel.Location = new System.Drawing.Point(318, 20);
            this.PCTypeLabel.Name = "PCTypeLabel";
            this.PCTypeLabel.Size = new System.Drawing.Size(33, 18);
            this.PCTypeLabel.TabIndex = 3;
            this.PCTypeLabel.Text = "Тип";
            // 
            // PCNameTextBox
            // 
            this.PCNameTextBox.Location = new System.Drawing.Point(6, 41);
            this.PCNameTextBox.Name = "PCNameTextBox";
            this.PCNameTextBox.Size = new System.Drawing.Size(300, 24);
            this.PCNameTextBox.TabIndex = 0;
            // 
            // PCTypeComboBox
            // 
            this.PCTypeComboBox.FormattingEnabled = true;
            this.PCTypeComboBox.Items.AddRange(new object[] {
            "Сервер",
            "Рабочая станция",
            "Ноутбук",
            "Терминал",
            "Виртуальная машина"});
            this.PCTypeComboBox.Location = new System.Drawing.Point(321, 41);
            this.PCTypeComboBox.Name = "PCTypeComboBox";
            this.PCTypeComboBox.Size = new System.Drawing.Size(300, 26);
            this.PCTypeComboBox.TabIndex = 1;
            this.PCTypeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoInput);
            // 
            // PCNameLabel
            // 
            this.PCNameLabel.AutoSize = true;
            this.PCNameLabel.Location = new System.Drawing.Point(3, 20);
            this.PCNameLabel.Name = "PCNameLabel";
            this.PCNameLabel.Size = new System.Drawing.Size(75, 18);
            this.PCNameLabel.TabIndex = 7;
            this.PCNameLabel.Text = "Название";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(654, 779);
            this.Controls.Add(this.PCGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Лаборатория";
            this.PCGroupBox.ResumeLayout(false);
            this.PCGroupBox.PerformLayout();
            this.GPUGroupBox.ResumeLayout(false);
            this.GPUGroupBox.PerformLayout();
            this.CPUGroupBox.ResumeLayout(false);
            this.CPUGroupBox.PerformLayout();
            this.ROMGroupBox.ResumeLayout(false);
            this.ROMGroupBox.PerformLayout();
            this.RAMGroupBox.ResumeLayout(false);
            this.RAMGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PCGroupBox;
        private System.Windows.Forms.Label PCNameLabel;
        private System.Windows.Forms.TextBox PCNameTextBox;
        private System.Windows.Forms.Label PCTypeLabel;
        private System.Windows.Forms.ComboBox PCTypeComboBox;
        private System.Windows.Forms.Label PCDateLabel;
        private System.Windows.Forms.DateTimePicker PCDateInput;
        private System.Windows.Forms.Label PCTimeLabel;
        private System.Windows.Forms.MaskedTextBox PCTimeInput;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button WatchButton;
        private System.Windows.Forms.GroupBox ROMGroupBox;
        private System.Windows.Forms.Button ROMEditButton;
        private System.Windows.Forms.TextBox ROMTextBox;
        private System.Windows.Forms.GroupBox RAMGroupBox;
        private System.Windows.Forms.Button RAMEditButton;
        private System.Windows.Forms.TextBox RAMTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox CPUGroupBox;
        private System.Windows.Forms.Button CPUEditButton;
        private System.Windows.Forms.TextBox CPUTextBox;
        private System.Windows.Forms.GroupBox GPUGroupBox;
        private System.Windows.Forms.Button GPUEditButton;
        private System.Windows.Forms.TextBox GPUTextBox;
    }
}

