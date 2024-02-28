using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02 {
    public delegate void UpdateRAM(Memory RAM);

    public partial class RAMForm : Form {
        public event UpdateRAM OnRAMUpdate;

        public RAMForm(Memory ram) {
            InitializeComponent();
            SetRAM(ram);
        }

        private void SetRAM(Memory ram) {
            if (ram is null) {
                return;
            }

            RAMTypeComboBox.Text = ram.Type;
            RAMVolumeTextBox.Text = ram.Volume.ToString();
            RAMVolumeSizeComboBox.Text = ram.VolumeType;
        }

        private Memory GetRAM() {
            Memory ram = new Memory();

            ram.Type = RAMTypeComboBox.Text;
            if (string.IsNullOrWhiteSpace(ram.Type)) {
                throw new InvalidDataException("Не указан тип ОЗУ");
            }

            try {
                ram.Volume = Convert.ToInt64(RAMVolumeTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для объема ОЗУ");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для объема ОЗУ");
            }
            if (ram.Volume == 0) {
                throw new InvalidDataException("Объем ОЗУ не может быть равен нулю");
            }

            ram.VolumeType = RAMVolumeSizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(ram.VolumeType)) {
                throw new InvalidDataException("Не указана размерность объема ОЗУ");
            }

            return ram;
        }

        private void UpdateRAM() {
            try {
                Memory ram = GetRAM();
                OnRAMUpdate(ram);
                this.Close();
            }
            catch (InvalidDataException ex) {
                MessageBox.Show(
                    ex.Message,
                    "Неверный ввод",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void ClearRAM() {
            RAMTypeComboBox.SelectedIndex = -1;
            RAMVolumeTextBox.Clear();
            RAMVolumeSizeComboBox.SelectedIndex = -1;
        }

        private void NoInput(object sender, KeyPressEventArgs e) {
            e.Handled = true;
        }

        private void IntInputKeyPressHandler(object sender, KeyPressEventArgs e) {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
                e.Handled = true;
            }
        }

        private void DoubleInputKeyPressHandler(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '.') {
                e.KeyChar = ',';
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8) {
                e.Handled = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            UpdateRAM();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            ClearRAM();
        }
    }
}
