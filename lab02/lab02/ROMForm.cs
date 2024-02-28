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
    public delegate void UpdateROM(Memory ROM);

    public partial class ROMForm : Form {
        public event UpdateROM OnROMUpdate;

        public ROMForm(Memory rom) {
            InitializeComponent();
            SetROM(rom);
        }

        private void SetROM(Memory rom) {
            if (rom is null) {
                return;
            }

            ROMTypeComboBox.Text = rom.Type;
            ROMVolumeTextBox.Text = rom.Volume.ToString();
            ROMVolumeSizeComboBox.Text = rom.VolumeType;
        }

        private Memory GetROM() {
            Memory rom = new Memory();

            rom.Type = ROMTypeComboBox.Text;
            if (string.IsNullOrWhiteSpace(rom.Type)) {
                throw new InvalidDataException("Не указан тип ПЗУ");
            }

            try {
                rom.Volume = Convert.ToInt64(ROMVolumeTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для объема ПЗУ");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для объема ПЗУ");
            }
            if (rom.Volume == 0) {
                throw new InvalidDataException("Объем ПЗУ не может быть равен нулю");
            }

            rom.VolumeType = ROMVolumeSizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(rom.VolumeType)) {
                throw new InvalidDataException("Не указана размерность объема ПЗУ");
            }

            return rom;
        }

        private void UpdateROM() {
            try {
                Memory ram = GetROM();
                OnROMUpdate(ram);
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

        private void ClearROM() {
            ROMTypeComboBox.SelectedIndex = -1;
            ROMVolumeTextBox.Clear();
            ROMVolumeSizeComboBox.SelectedIndex = -1;
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
            UpdateROM();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            ClearROM();
        }
    }
}
