using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01 {
    public partial class MainForm : Form {
        private string previousBase = "DEC";
        private IBinaryCalculator calculator = new Calculator();

        public MainForm() {
            InitializeComponent();
            EnableDecSymbols();
            firstNumberInput.Text = "0";
            buttonEq.Click += CalculateByClick;
        }

        private void Clear() {
            firstNumberInput.Clear();
            operationInput.Clear();
            secondNumberInput.Clear();
            firstNumberInput.Text = "0";
        }

        private void InputSymbol(char symbol) {
            if (string.IsNullOrEmpty(operationInput.Text)) {
                if (firstNumberInput.Text == "0") {
                    firstNumberInput.Text = "";
                }
                firstNumberInput.AppendText(symbol.ToString());
            }
            else {
                if (secondNumberInput.Text == "0") {
                    secondNumberInput.Text = "";
                }
                secondNumberInput.AppendText(symbol.ToString());
            }
        }

        private void DeleteSymbol() {
            if (!string.IsNullOrEmpty(secondNumberInput.Text)) {
                secondNumberInput.Text = secondNumberInput.Text.Substring(0, secondNumberInput.Text.Length - 1);
            }
            else if (!string.IsNullOrEmpty(operationInput.Text)) {
                SetOperation("");
            }
            else if (!string.IsNullOrEmpty(firstNumberInput.Text)) {
                if (firstNumberInput.Text.Length == 1) {
                    firstNumberInput.Text = "0";
                }
                else {
                    firstNumberInput.Text = firstNumberInput.Text.Substring(0, firstNumberInput.Text.Length - 1);
                }
            }
        }

        private void SetOperation(string operation) {
            if (string.IsNullOrEmpty(firstNumberInput.Text)) {
                return;
            }
            if (operation == "UMIN") {
                CalculateUnaryMinus();
                return;
            }
            if (!string.IsNullOrEmpty(secondNumberInput.Text)) {
                return;
            }
            if (operation == "NOT") {
                CalculateBinaryNot();
                return;
            }
            if (firstNumberInput.Text == "0") {
                return;
            }
            operationInput.Text = operation;
        }

        private void CalculateBinaryNot() {
            if (!string.IsNullOrEmpty(operationInput.Text)) {
                return;
            }
            int? firstNumber = null;
            try {
                firstNumber = GetValue(firstNumberInput.Text);
            }
            catch (OverflowException) {
                MessageBox.Show(
                    "Слишком большое число!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Clear();
                return;
            }
            if (!firstNumber.HasValue) {
                return;
            }
            firstNumber = calculator.BinaryNOT(firstNumber.Value);
            firstNumberInput.Text = FormatValue(firstNumber.Value);
        }

        private void CalculateUnaryMinus() {
            if (!string.IsNullOrEmpty(operationInput.Text) && string.IsNullOrEmpty(secondNumberInput.Text)) {
                return;
            }
            int? firstNumber = null;
            int? secondNumber = null;
            try {
                firstNumber = GetValue(firstNumberInput.Text);
                secondNumber = GetValue(secondNumberInput.Text);
            }
            catch (OverflowException) {
                MessageBox.Show(
                    "Слишком большие числа!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Clear();
                return;
            }
            if (secondNumber.HasValue) {
                secondNumber = calculator.UnaryMinus(secondNumber.Value);
                secondNumberInput.Text = FormatValue(secondNumber.Value);
                return;
            }
            if (firstNumber.HasValue) {
                firstNumber = calculator.UnaryMinus(firstNumber.Value);
                firstNumberInput.Text = FormatValue(firstNumber.Value);
                return;
            }
        }

        private void Calculate() {
            int? firstNumber = null;
            int? secondNumber = null;

            try {
                firstNumber = GetValue(firstNumberInput.Text);
                secondNumber = GetValue(secondNumberInput.Text);
            }
            catch (OverflowException) {
                MessageBox.Show(
                    "Слишком большие числа!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Clear();
            }

            if (!firstNumber.HasValue || !secondNumber.HasValue) {
                return;
            }

            int result;

            switch (operationInput.Text) {
                case "AND":
                    result = calculator.BinaryAND(firstNumber.Value, secondNumber.Value);
                    break;
                case "OR":
                    result = calculator.BinaryOR(firstNumber.Value, secondNumber.Value);
                    break;
                case "XOR":
                    result = calculator.BinaryXOR(firstNumber.Value, secondNumber.Value);
                    break;
                default:
                    return;
            }

            Clear();
            firstNumberInput.Text = FormatValue(result);
        }

        private void SetBase(string newBase) {
            int? firstNumber = null;
            int? secondNumber = null;

            try {
                firstNumber = GetValue(firstNumberInput.Text);
                secondNumber = GetValue(secondNumberInput.Text);
            }
            catch (OverflowException) {
                MessageBox.Show(
                    "Слишком большие числа!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Clear();
            }

            switch (newBase) {
                case "HEX":
                    EnableHexSymbols();
                    if (firstNumber.HasValue) {
                        firstNumberInput.Text = calculator.ToHEX(firstNumber.Value);
                    }
                    if (secondNumber.HasValue) {
                        secondNumberInput.Text = calculator.ToHEX(secondNumber.Value);
                    }
                    break;
                case "DEC":
                    EnableDecSymbols();
                    if (firstNumber.HasValue) {
                        firstNumberInput.Text = calculator.ToDEC(firstNumber.Value);
                    }
                    if (secondNumber.HasValue) {
                        secondNumberInput.Text = calculator.ToDEC(secondNumber.Value);
                    }
                    break;
                case "OCT":
                    EnableOctSymbols();
                    if (firstNumber.HasValue) {
                        firstNumberInput.Text = calculator.ToOCT(firstNumber.Value);
                    }
                    if (secondNumber.HasValue) {
                        secondNumberInput.Text = calculator.ToOCT(secondNumber.Value);
                    }
                    break;
                case "BIN":
                    EnableBinSymbols();
                    if (firstNumber.HasValue) {
                        firstNumberInput.Text = calculator.ToBIN(firstNumber.Value);
                    }
                    if (secondNumber.HasValue) {
                        secondNumberInput.Text = calculator.ToBIN(secondNumber.Value);
                    }
                    break;
                default:
                    SetBase("DEC");
                    return;
            }

            previousBase = newBase;
        }

        private int? GetValue(string number) {
            if (string.IsNullOrEmpty(number)) {
                return null;
            }
            switch (previousBase) {
                case "HEX":
                    return calculator.FromHEX(number);
                case "DEC":
                    return calculator.FromDEC(number);
                case "OCT":
                    return calculator.FromOCT(number);
                case "BIN":
                    return calculator.FromBIN(number);
                default:
                    return null;
            }
        }

        private string FormatValue(int value) {
            switch (previousBase) {
                case "HEX":
                    return calculator.ToHEX(value);
                case "DEC":
                    return calculator.ToDEC(value);
                case "OCT":
                    return calculator.ToOCT(value);
                case "BIN":
                    return calculator.ToBIN(value);
                default:
                    return "";
            }
        }

        private void EnableHexSymbols() {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
        }

        private void EnableDecSymbols() {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
        }

        private void EnableOctSymbols() {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
        }

        private void EnableBinSymbols() {
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
        }

        private void radioButtonHEX_CheckedChanged(object sender, EventArgs e) {
            SetBase("HEX");
        }

        private void radioButtonDEC_CheckedChanged(object sender, EventArgs e) {
            SetBase("DEC");
        }

        private void radioButtonOCT_CheckedChanged(object sender, EventArgs e) {
            SetBase("OCT");
        }

        private void radioButtonBIN_CheckedChanged(object sender, EventArgs e) {
            SetBase("BIN");
        }

        private void button0_Click(object sender, EventArgs e) {
            InputSymbol('0');
        }

        private void button1_Click(object sender, EventArgs e) {
            InputSymbol('1');
        }

        private void button2_Click(object sender, EventArgs e) {
            InputSymbol('2');
        }

        private void button3_Click(object sender, EventArgs e) {
            InputSymbol('3');
        }

        private void button4_Click(object sender, EventArgs e) {
            InputSymbol('4');
        }

        private void button5_Click(object sender, EventArgs e) {
            InputSymbol('5');
        }

        private void button6_Click(object sender, EventArgs e) {
            InputSymbol('6');
        }

        private void button7_Click(object sender, EventArgs e) {
            InputSymbol('7');
        }

        private void button8_Click(object sender, EventArgs e) {
            InputSymbol('8');
        }

        private void button9_Click(object sender, EventArgs e) {
            InputSymbol('9');
        }

        private void buttonA_Click(object sender, EventArgs e) {
            InputSymbol('A');
        }

        private void buttonB_Click(object sender, EventArgs e) {
            InputSymbol('B');
        }

        private void buttonC_Click(object sender, EventArgs e) {
            InputSymbol('C');
        }

        private void buttonD_Click(object sender, EventArgs e) {
            InputSymbol('D');
        }

        private void buttonE_Click(object sender, EventArgs e) {
            InputSymbol('E');
        }

        private void buttonF_Click(object sender, EventArgs e) {
            InputSymbol('F');
        }

        private void buttonAND_Click(object sender, EventArgs e) {
            SetOperation("AND");
        }

        private void buttonOR_Click(object sender, EventArgs e) {
            SetOperation("OR");
        }

        private void buttonXOR_Click(object sender, EventArgs e) {
            SetOperation("XOR");
        }

        private void buttonNOT_Click(object sender, EventArgs e) {
            SetOperation("NOT");
        }

        private void buttonUMinus_Click(object sender, EventArgs e) {
            SetOperation("UMIN");
        }

        private void buttonDEL_Click(object sender, EventArgs e) {
            DeleteSymbol();
        }

        private void buttonCE_Click(object sender, EventArgs e) {
            Clear();
        }

        private void buttonEq_Click(object sender, EventArgs e) {
        }

        private void CalculateByClick(object sender, EventArgs e) {
            Calculate();
        }
    }
}
