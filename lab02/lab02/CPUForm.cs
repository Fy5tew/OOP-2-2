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
    public delegate void UpdateCPU(CPU CPU);

    public partial class CPUForm : Form {
        public event UpdateCPU OnCPUUpdate;

        public CPUForm(CPU cpu) {
            InitializeComponent();
            SetCPU(cpu);
        }

        private void SetCPU(CPU cpu) {
            if (cpu is null) {
                return;
            }

            CPUManufacturerTextBox.Text = cpu.Manufacturer;
            CPUSeriesTextBox.Text = cpu.Series;
            CPUModelTextBox.Text = cpu.Model;
            CPUCoresTextBox.Text = cpu.CoresCount.ToString();
            CPUWorkingFrequencyTextBox.Text = cpu.WorkingFrequency.Value.ToString();
            CPUWorkingFrequencySizeComboBox.Text = cpu.WorkingFrequency.Type;
            CPUMaxFrequencyTextBox.Text = cpu.MaxFrequency.Value.ToString();
            CPUMaxFrequencySizeComboBox.Text = cpu.MaxFrequency.Type;
            if (cpu.Architecture == CPUArchitecture32RadioButton.Text) {
                CPUArchitecture32RadioButton.Checked = true;
            }
            if (cpu.Architecture == CPUArchitecture64RadioButton.Text) {
                CPUArchitecture64RadioButton.Checked = true;
            }
            CPUCacheL1TextBox.Text = cpu.Cache[0].Volume.ToString();
            CPUCacheL1SizeComboBox.Text = cpu.Cache[0].VolumeType;
            CPUCacheL2TextBox.Text = cpu.Cache[1].Volume.ToString();
            CPUCacheL2SizeComboBox.Text = cpu.Cache[1].VolumeType;
            CPUCacheL3TextBox.Text = cpu.Cache[2].Volume.ToString();
            CPUCacheL3SizeComboBox.Text = cpu.Cache[2].VolumeType;
        }

        private CPU GetCPU() {
            CPU cpu = new CPU();

            cpu.Manufacturer = CPUManufacturerTextBox.Text;
            if (string.IsNullOrWhiteSpace(cpu.Manufacturer)) {
                throw new InvalidDataException("Не указан производитель процессора");
            }

            cpu.Series = CPUSeriesTextBox.Text;
            if (string.IsNullOrWhiteSpace(cpu.Series)) {
                throw new InvalidDataException("Не указана серия процессора");
            }

            cpu.Model = CPUModelTextBox.Text;
            if (string.IsNullOrWhiteSpace(cpu.Model)) {
                throw new InvalidDataException("Не указана модель процессора");
            }

            try {
                cpu.CoresCount = Convert.ToInt32(CPUCoresTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для количества ядер процессора");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для количества ядер процессора");
            }
            if (cpu.CoresCount == 0) {
                throw new InvalidDataException("Количество ядер процессора не может быть равно нулю");
            }

            cpu.WorkingFrequency = GetCPUWorkingFrequency();
            cpu.MaxFrequency = GetCPUMaxFrequency();

            if (CPUArchitecture32RadioButton.Checked) {
                cpu.Architecture = CPUArchitecture32RadioButton.Text;
            }
            if (CPUArchitecture64RadioButton.Checked) {
                cpu.Architecture = CPUArchitecture64RadioButton.Text;
            }
            if (string.IsNullOrWhiteSpace(cpu.Architecture)) {
                throw new InvalidDataException("Не указана архитектура процессора");
            }

            cpu.Cache = GetCPUCache();

            return cpu;
        }

        private Frequency GetCPUWorkingFrequency() {
            Frequency cpuWorkingFrequency = new Frequency();

            try {
                cpuWorkingFrequency.Value = Convert.ToDouble(CPUWorkingFrequencyTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для рабочей частоты процессора");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для рабочей частоты процессора");
            }
            if (cpuWorkingFrequency.Value == 0) {
                throw new InvalidDataException("Рабочая частота процессора не может быть равна нулю");
            }

            cpuWorkingFrequency.Type = CPUWorkingFrequencySizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(cpuWorkingFrequency.Type)) {
                throw new InvalidDataException("Не указана размерность рабочей частоты процессора");
            }

            return cpuWorkingFrequency;
        }

        private Frequency GetCPUMaxFrequency() {
            Frequency cpuMaxFrequency = new Frequency();

            try {
                cpuMaxFrequency.Value = Convert.ToDouble(CPUMaxFrequencyTextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число максимальной частоты процессора");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для максимальной частоты процессора");
            }
            if (cpuMaxFrequency.Value == 0) {
                throw new InvalidDataException("Максимальная частота процессора не может быть равна нулю");
            }

            cpuMaxFrequency.Type = CPUMaxFrequencySizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(cpuMaxFrequency.Type)) {
                throw new InvalidDataException("Не указана размерность максимальной частоты процессора");
            }

            return cpuMaxFrequency;
        }

        private Memory[] GetCPUCache() {
            Memory[] cache = new Memory[3];
            cache[0] = GetCPUCacheL1();
            cache[1] = GetCPUCacheL2();
            cache[2] = GetCPUCacheL3();
            return cache;
        }

        private Memory GetCPUCacheL1() {
            Memory cache = new Memory();

            cache.Type = "L1";

            try {
                cache.Volume = Convert.ToInt64(CPUCacheL1TextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для объема кэша L1");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для объема кэша L1");
            }
            if (cache.Volume == 0) {
                throw new InvalidDataException("Объем кэша L1 не может быть равен нулю");
            }

            cache.VolumeType = CPUCacheL1SizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(cache.VolumeType)) {
                throw new InvalidDataException("Не указана размерность объема кэша L1 процессора");
            }

            return cache;
        }

        private Memory GetCPUCacheL2() {
            Memory cache = new Memory();

            cache.Type = "L2";
            
            try {
                cache.Volume = Convert.ToInt64(CPUCacheL2TextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для объема кэша L2");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для объема кэша L2");
            }
            if (cache.Volume == 0) {
                throw new InvalidDataException("Объем кэша L2 не может быть равен нулю");
            }

            cache.VolumeType = CPUCacheL2SizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(cache.VolumeType)) {
                throw new InvalidDataException("Не указана размерность объема кэша L2 процессора");
            }

            return cache;
        }

        private Memory GetCPUCacheL3() {
            Memory cache = new Memory();

            cache.Type = "L3";

            try {
                cache.Volume = Convert.ToInt64(CPUCacheL3TextBox.Text);
            }
            catch (OverflowException) {
                throw new InvalidDataException("Слишком большое число для объема кэша L3");
            }
            catch (FormatException) {
                throw new InvalidDataException("Неверный ввод для объема кэша L3");
            }
            if (cache.Volume == 0) {
                throw new InvalidDataException("Объем кэша L3 не может быть равен нулю");
            }

            cache.VolumeType = CPUCacheL3SizeComboBox.Text;
            if (string.IsNullOrWhiteSpace(cache.VolumeType)) {
                throw new InvalidDataException("Не указана размерность объема кэша L3 процессора");
            }

            return cache;
        }

        private void UpdateCPU() {
            try {
                CPU cpu = GetCPU();
                OnCPUUpdate(cpu);
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

        private void ClearCPU() {
            CPUManufacturerTextBox.Clear();
            CPUSeriesTextBox.Clear();
            CPUModelTextBox.Clear();
            CPUCoresTextBox.Clear();
            CPUWorkingFrequencyTextBox.Clear();
            CPUWorkingFrequencySizeComboBox.SelectedIndex = -1;
            CPUMaxFrequencyTextBox.Clear();
            CPUMaxFrequencySizeComboBox.SelectedIndex = -1;
            CPUArchitecture32RadioButton.Checked = false;
            CPUArchitecture64RadioButton.Checked = false;
            CPUCacheL1TextBox.Clear();
            CPUCacheL1SizeComboBox.SelectedIndex = -1;
            CPUCacheL2TextBox.Clear();
            CPUCacheL2SizeComboBox.SelectedIndex = -1;
            CPUCacheL3TextBox.Clear();
            CPUCacheL3SizeComboBox.SelectedIndex = -1;
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
            UpdateCPU();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            ClearCPU();
        }
    }
}
