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
    public delegate void UpdateGPU(GPU GPU);

    public partial class GPUForm : Form {
        public event UpdateGPU OnGPUUpdate;

        public GPUForm(GPU gpu) {
            InitializeComponent();
            SetGPU(gpu);
        }

        private void SetGPU(GPU gpu) {
            if (gpu is null) {
                return;
            }

            GPUManufacturerTextBox.Text = gpu.Manufacturer;
            GPUSeriesTextBox.Text = gpu.Series;
            GPUModelTextBox.Text = gpu.Model;
            GPUWorkingFrequencyTextBox.Text = gpu.WorkingFrequency.Value.ToString();
            GPUWorkingFrequencySizeComboBox.Text = gpu.WorkingFrequency.Type;
            GPUMaxFrequencyTextBox.Text += gpu.MaxFrequency.Value.ToString();
            GPUMaxFrequencySizeComboBox.Text += gpu.MaxFrequency.Type;
            GPUDX11SupportCheckBox.Checked = gpu.DX11Support;
        }

        private GPU GetGPU() {
            GPU gpu = new GPU();

            gpu.Manufacturer = GPUManufacturerTextBox.Text;
            if (string.IsNullOrWhiteSpace(gpu.Manufacturer)) {
                throw new InvalidDataException("Не указан производитель видеокарты");
            }

            gpu.Series = GPUSeriesTextBox.Text;
            if (string.IsNullOrWhiteSpace(gpu.Series)) {
                throw new InvalidDataException("Не указана серия видеокарты");
            }

            gpu.Model = GPUModelTextBox.Text;
            if (string.IsNullOrWhiteSpace(gpu.Model)) {
                throw new InvalidDataException("Не указана модель видеокарты");
            }

            gpu.Memory = GetGPUMemory();

            gpu.WorkingFrequency = GetGPUWorkingFrequency();

            gpu.MaxFrequency = GetGPUMaxFrequency();

            gpu.DX11Support = GPUDX11SupportCheckBox.Checked;

            return gpu;
        }

        private Memory GetGPUMemory() {
            Memory gpuMemory = new Memory();

            gpuMemory.Type = "GPU";

            try {
                gpuMemory.Volume = Convert.ToInt64(GPUMemoryTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для объема памяти видеокарты");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для объема памяти видеокарты");
            }
            if (gpuMemory.Volume == 0) {
                throw new InvalidDataException("Объем памяти видеокарты не может быть равен нулю");
            }

            gpuMemory.VolumeType = GPUMemorySizeComboBox.Text;
            if (string.IsNullOrEmpty(gpuMemory.VolumeType)) {
                throw new InvalidDataException("Не указана размерность памяти видеокарты");
            }

            return gpuMemory;
        }

        private Frequency GetGPUWorkingFrequency() {
            Frequency gpuWorkingFrequency = new Frequency();

            try {
                gpuWorkingFrequency.Value = Convert.ToDouble(GPUWorkingFrequencyTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для рабочей частоты видеокарты");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для рабочей частоты видеокарты");
            }
            if (gpuWorkingFrequency.Value == 0) {
                throw new InvalidDataException("Рабочая частота видеокарты не может быть равна нулю");
            }

            gpuWorkingFrequency.Type = GPUWorkingFrequencySizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(gpuWorkingFrequency.Type)) {
                throw new InvalidDataException("Не указана размерность рабочей частоты видеокарты");
            }

            return gpuWorkingFrequency;
        }

        private Frequency GetGPUMaxFrequency() {
            Frequency gpuMaxFrequency = new Frequency();

            try {
                gpuMaxFrequency.Value = Convert.ToDouble(GPUMaxFrequencyTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для максимальной частоты видеокарты");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для максимальной частоты видеокарты");
            }
            if (gpuMaxFrequency.Value == 0) {
                throw new InvalidDataException("Максимальная частота видеокарты не может быть равна нулю");
            }

            gpuMaxFrequency.Type = GPUMaxFrequencySizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(gpuMaxFrequency.Type)) {
                throw new InvalidDataException("Не указана размерность максимальной частоты видеокарты");
            }

            return gpuMaxFrequency;
        }

        private void UpdateGPU() {
            try {
                GPU gpu = GetGPU();
                OnGPUUpdate(gpu);
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

        private void ClearGPU() {
            GPUManufacturerTextBox.Clear();
            GPUSeriesTextBox.Clear();
            GPUModelTextBox.Clear();
            GPUMemoryTextBox.Clear();
            GPUMemorySizeComboBox.SelectedIndex = -1;
            GPUWorkingFrequencyTextBox.Clear();
            GPUWorkingFrequencySizeComboBox.SelectedIndex = -1;
            GPUMaxFrequencyTextBox.Clear();
            GPUMaxFrequencySizeComboBox.SelectedIndex = -1;
            GPUDX11SupportCheckBox.Checked = false;
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
            UpdateGPU();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            ClearGPU();
        }
    }
}
