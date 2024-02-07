namespace lab01 {
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
            this.firstNumberInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonAND = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.buttonXOR = new System.Windows.Forms.Button();
            this.buttonNOT = new System.Windows.Forms.Button();
            this.buttonEq = new System.Windows.Forms.Button();
            this.buttonDEL = new System.Windows.Forms.Button();
            this.buttonUMinus = new System.Windows.Forms.Button();
            this.radioButtonHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonDEC = new System.Windows.Forms.RadioButton();
            this.radioButtonOCT = new System.Windows.Forms.RadioButton();
            this.radioButtonBIN = new System.Windows.Forms.RadioButton();
            this.operationInput = new System.Windows.Forms.TextBox();
            this.secondNumberInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNumberInput
            // 
            this.firstNumberInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.firstNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNumberInput.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.firstNumberInput.Location = new System.Drawing.Point(10, 13);
            this.firstNumberInput.Name = "firstNumberInput";
            this.firstNumberInput.ReadOnly = true;
            this.firstNumberInput.Size = new System.Drawing.Size(889, 45);
            this.firstNumberInput.TabIndex = 0;
            this.firstNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.buttonA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonF, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.button0, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonE, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCE, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAND, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonOR, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonXOR, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNOT, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonEq, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonDEL, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUMinus, 5, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 304);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 503);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonA.ForeColor = System.Drawing.Color.White;
            this.buttonA.Location = new System.Drawing.Point(3, 3);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(120, 119);
            this.buttonA.TabIndex = 21;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonB.ForeColor = System.Drawing.Color.White;
            this.buttonB.Location = new System.Drawing.Point(129, 3);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(120, 119);
            this.buttonB.TabIndex = 22;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(3, 128);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(120, 119);
            this.buttonC.TabIndex = 23;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonD.ForeColor = System.Drawing.Color.White;
            this.buttonD.Location = new System.Drawing.Point(129, 128);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(120, 119);
            this.buttonD.TabIndex = 24;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonF
            // 
            this.buttonF.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonF.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonF.ForeColor = System.Drawing.Color.White;
            this.buttonF.Location = new System.Drawing.Point(129, 253);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(120, 119);
            this.buttonF.TabIndex = 26;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = false;
            this.buttonF.Click += new System.EventHandler(this.buttonF_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button7.Location = new System.Drawing.Point(255, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 119);
            this.button7.TabIndex = 18;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(255, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 119);
            this.button4.TabIndex = 15;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Location = new System.Drawing.Point(381, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 119);
            this.button5.TabIndex = 16;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(507, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 119);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(255, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 119);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(381, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 119);
            this.button2.TabIndex = 13;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(507, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 119);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button0.Location = new System.Drawing.Point(381, 378);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(120, 121);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonE.ForeColor = System.Drawing.Color.White;
            this.buttonE.Location = new System.Drawing.Point(3, 253);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(120, 119);
            this.buttonE.TabIndex = 25;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button8.Location = new System.Drawing.Point(381, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 119);
            this.button8.TabIndex = 19;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button9.Location = new System.Drawing.Point(507, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 119);
            this.button9.TabIndex = 20;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCE.ForeColor = System.Drawing.Color.White;
            this.buttonCE.Location = new System.Drawing.Point(759, 3);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(127, 119);
            this.buttonCE.TabIndex = 31;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonAND
            // 
            this.buttonAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAND.Location = new System.Drawing.Point(633, 128);
            this.buttonAND.Name = "buttonAND";
            this.buttonAND.Size = new System.Drawing.Size(120, 119);
            this.buttonAND.TabIndex = 27;
            this.buttonAND.Text = "AND";
            this.buttonAND.UseVisualStyleBackColor = true;
            this.buttonAND.Click += new System.EventHandler(this.buttonAND_Click);
            // 
            // buttonOR
            // 
            this.buttonOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonOR.Location = new System.Drawing.Point(759, 128);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(121, 119);
            this.buttonOR.TabIndex = 28;
            this.buttonOR.Text = "OR";
            this.buttonOR.UseVisualStyleBackColor = true;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // buttonXOR
            // 
            this.buttonXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonXOR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonXOR.Location = new System.Drawing.Point(633, 253);
            this.buttonXOR.Name = "buttonXOR";
            this.buttonXOR.Size = new System.Drawing.Size(120, 119);
            this.buttonXOR.TabIndex = 29;
            this.buttonXOR.Text = "XOR";
            this.buttonXOR.UseVisualStyleBackColor = true;
            this.buttonXOR.Click += new System.EventHandler(this.buttonXOR_Click);
            // 
            // buttonNOT
            // 
            this.buttonNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNOT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonNOT.Location = new System.Drawing.Point(759, 253);
            this.buttonNOT.Name = "buttonNOT";
            this.buttonNOT.Size = new System.Drawing.Size(121, 119);
            this.buttonNOT.TabIndex = 30;
            this.buttonNOT.Text = "NOT";
            this.buttonNOT.UseVisualStyleBackColor = true;
            this.buttonNOT.Click += new System.EventHandler(this.buttonNOT_Click);
            // 
            // buttonEq
            // 
            this.buttonEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEq.Location = new System.Drawing.Point(759, 378);
            this.buttonEq.Name = "buttonEq";
            this.buttonEq.Size = new System.Drawing.Size(120, 119);
            this.buttonEq.TabIndex = 32;
            this.buttonEq.Text = "=";
            this.buttonEq.UseVisualStyleBackColor = true;
            this.buttonEq.Click += new System.EventHandler(this.buttonEq_Click);
            // 
            // buttonDEL
            // 
            this.buttonDEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDEL.ForeColor = System.Drawing.Color.White;
            this.buttonDEL.Location = new System.Drawing.Point(633, 3);
            this.buttonDEL.Name = "buttonDEL";
            this.buttonDEL.Size = new System.Drawing.Size(120, 119);
            this.buttonDEL.TabIndex = 33;
            this.buttonDEL.Text = "DEL";
            this.buttonDEL.UseVisualStyleBackColor = false;
            this.buttonDEL.Click += new System.EventHandler(this.buttonDEL_Click);
            // 
            // buttonUMinus
            // 
            this.buttonUMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonUMinus.Location = new System.Drawing.Point(633, 378);
            this.buttonUMinus.Name = "buttonUMinus";
            this.buttonUMinus.Size = new System.Drawing.Size(120, 119);
            this.buttonUMinus.TabIndex = 34;
            this.buttonUMinus.Text = "+/-";
            this.buttonUMinus.UseVisualStyleBackColor = true;
            this.buttonUMinus.Click += new System.EventHandler(this.buttonUMinus_Click);
            // 
            // radioButtonHEX
            // 
            this.radioButtonHEX.AutoSize = true;
            this.radioButtonHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHEX.Location = new System.Drawing.Point(10, 175);
            this.radioButtonHEX.Name = "radioButtonHEX";
            this.radioButtonHEX.Size = new System.Drawing.Size(65, 24);
            this.radioButtonHEX.TabIndex = 3;
            this.radioButtonHEX.TabStop = true;
            this.radioButtonHEX.Text = "HEX";
            this.radioButtonHEX.UseVisualStyleBackColor = true;
            this.radioButtonHEX.CheckedChanged += new System.EventHandler(this.radioButtonHEX_CheckedChanged);
            // 
            // radioButtonDEC
            // 
            this.radioButtonDEC.AutoSize = true;
            this.radioButtonDEC.Checked = true;
            this.radioButtonDEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDEC.Location = new System.Drawing.Point(10, 205);
            this.radioButtonDEC.Name = "radioButtonDEC";
            this.radioButtonDEC.Size = new System.Drawing.Size(66, 24);
            this.radioButtonDEC.TabIndex = 4;
            this.radioButtonDEC.TabStop = true;
            this.radioButtonDEC.Text = "DEC";
            this.radioButtonDEC.UseVisualStyleBackColor = true;
            this.radioButtonDEC.CheckedChanged += new System.EventHandler(this.radioButtonDEC_CheckedChanged);
            // 
            // radioButtonOCT
            // 
            this.radioButtonOCT.AutoSize = true;
            this.radioButtonOCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOCT.Location = new System.Drawing.Point(10, 235);
            this.radioButtonOCT.Name = "radioButtonOCT";
            this.radioButtonOCT.Size = new System.Drawing.Size(65, 24);
            this.radioButtonOCT.TabIndex = 5;
            this.radioButtonOCT.TabStop = true;
            this.radioButtonOCT.Text = "OCT";
            this.radioButtonOCT.UseVisualStyleBackColor = true;
            this.radioButtonOCT.CheckedChanged += new System.EventHandler(this.radioButtonOCT_CheckedChanged);
            // 
            // radioButtonBIN
            // 
            this.radioButtonBIN.AutoSize = true;
            this.radioButtonBIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBIN.Location = new System.Drawing.Point(10, 265);
            this.radioButtonBIN.Name = "radioButtonBIN";
            this.radioButtonBIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonBIN.Size = new System.Drawing.Size(58, 24);
            this.radioButtonBIN.TabIndex = 6;
            this.radioButtonBIN.TabStop = true;
            this.radioButtonBIN.Text = "BIN";
            this.radioButtonBIN.UseVisualStyleBackColor = true;
            this.radioButtonBIN.CheckedChanged += new System.EventHandler(this.radioButtonBIN_CheckedChanged);
            // 
            // operationInput
            // 
            this.operationInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.operationInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationInput.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.operationInput.Location = new System.Drawing.Point(10, 64);
            this.operationInput.Name = "operationInput";
            this.operationInput.ReadOnly = true;
            this.operationInput.Size = new System.Drawing.Size(889, 45);
            this.operationInput.TabIndex = 7;
            this.operationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secondNumberInput
            // 
            this.secondNumberInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.secondNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumberInput.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.secondNumberInput.Location = new System.Drawing.Point(10, 115);
            this.secondNumberInput.Name = "secondNumberInput";
            this.secondNumberInput.ReadOnly = true;
            this.secondNumberInput.Size = new System.Drawing.Size(889, 45);
            this.secondNumberInput.TabIndex = 8;
            this.secondNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 816);
            this.Controls.Add(this.secondNumberInput);
            this.Controls.Add(this.operationInput);
            this.Controls.Add(this.radioButtonBIN);
            this.Controls.Add(this.radioButtonOCT);
            this.Controls.Add(this.radioButtonDEC);
            this.Controls.Add(this.radioButtonHEX);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.firstNumberInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бинарный калькулятор";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAND;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.Button buttonXOR;
        private System.Windows.Forms.Button buttonNOT;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonEq;
        private System.Windows.Forms.RadioButton radioButtonHEX;
        private System.Windows.Forms.RadioButton radioButtonOCT;
        private System.Windows.Forms.RadioButton radioButtonBIN;
        private System.Windows.Forms.RadioButton radioButtonDEC;
        private System.Windows.Forms.Button buttonDEL;
        private System.Windows.Forms.TextBox operationInput;
        private System.Windows.Forms.TextBox secondNumberInput;
        private System.Windows.Forms.Button buttonUMinus;
    }
}

