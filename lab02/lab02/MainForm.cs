using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02 {
    public partial class MainForm : Form {
        private JSONDataBase<PC> database = new JSONDataBase<PC>(@"D:\Study\ООПиП\lab02\lab02\db\data.json");

        private Memory RAM = null;
        private Memory ROM = null;
        private CPU CPU = null;
        private GPU GPU = null;

        public MainForm() {
            InitializeComponent();
        }

        private void SetRAM(Memory ram) {
            RAM = ram;
            RAMTextBox.Text = RAM.ToString().Replace("\n", "\r\n");
        }

        private void SetROM(Memory rom) {
            ROM = rom;
            ROMTextBox.Text = ROM.ToString().Replace("\n", "\r\n");
        }

        private void SetCPU(CPU cpu) {
            CPU = cpu;
            CPUTextBox.Text = CPU.ToString().Replace("\n", "\r\n");
        }

        private void SetGPU(GPU gpu) {
            GPU = gpu;
            GPUTextBox.Text = GPU.ToString().Replace("\n", "\r\n");
        }

        private void EditRAM() {
            RAMForm ramForm = new RAMForm(RAM);
            ramForm.OnRAMUpdate += SetRAM;
            ramForm.ShowDialog();
        }

        private void EditROM() {
            ROMForm romForm = new ROMForm(ROM);
            romForm.OnROMUpdate += SetROM;
            romForm.ShowDialog();
        }

        private void EditCPU() {
            CPUForm cpuForm = new CPUForm(CPU);
            cpuForm.OnCPUUpdate += SetCPU;
            cpuForm.ShowDialog();
        }

        private void EditGPU() {
            GPUForm gpuForm = new GPUForm(GPU);
            gpuForm.OnGPUUpdate += SetGPU;
            gpuForm.ShowDialog();
        }

        private PC GetPC() {
            PC pc = new PC();

            pc.Name = PCNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(pc.Name)) {
                throw new InvalidDataException("Не указано название компьютера");
            }

            pc.Type = PCTypeComboBox.Text;
            if (string.IsNullOrWhiteSpace(pc.Type)) {
                throw new InvalidDataException("Не указан тип компьютера");
            }

            pc.InstallationDate = PCDateInput.Value.Date;
            if (pc.InstallationDate > DateTime.Now.Date) {
                throw new InvalidDataException("Нельзя указать дату установки в будущем");
            }

            pc.InstallationTime = PCTimeInput.Text;
            if (!Regex.IsMatch(pc.InstallationTime, "^(2[0-3]|[01]?[0-9]):([0-5]?[0-9])$")) {
                throw new InvalidDataException("Неверный формат времени установки компьютера");
            }
            if (pc.InstallationDate == DateTime.Now.Date) {
                if (DateTime.Parse(pc.InstallationTime) > DateTime.Now) {
                    throw new InvalidDataException("Нельзя указать время установки в будущем");
                }
            }

            pc.RAM = RAM;
            if (pc.RAM is null) {
                throw new InvalidDataException("Не указана информация об ОЗУ");
            }

            pc.ROM = ROM;
            if (pc.ROM is null) {
                throw new InvalidDataException("Не указана информация о ПЗУ");
            }

            pc.CPU = CPU;
            if (pc.CPU is null) {
                throw new InvalidDataException("Не указана информация о процессоре");
            }

            pc.GPU = GPU;
            if (pc.GPU is null) {
                throw new InvalidDataException("Не указана информация о видеокарте");
            }

            return pc;
        }

        private void Save() {
            try {
                PC pc = GetPC();
                database.Append(pc);
                Clear();
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

        private void Watch() {
            List<PC> items = database.ReadAll();
            if (items.Count <= 0) {
                MessageBox.Show(
                    "Нет сохраненных данных",
                    "База данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else {
                string output = "";
                double labPrice = 0;
                foreach (PC pc in items) {
                    output += pc.ToString() + "\n\n";
                    labPrice += pc.CalculatePrice();
                }
                output += $"Суммарная расчетная стоимость лаборатории: {labPrice:F2} BYN";
                OutputForm outputForm = new OutputForm(output.Replace("\n", "\r\n"));
                outputForm.Text = "База данных";
                outputForm.ShowDialog();
            }
        }

        private void Clear() {
            ClearPC();
        }

        private void ClearPC() {
            PCNameTextBox.Clear();
            PCTypeComboBox.SelectedIndex = -1;
            PCDateInput.Value = DateTime.Now;
            PCTimeInput.Clear();
            
            RAMTextBox.Clear();
            ROMTextBox.Clear();
            CPUTextBox.Clear();
            GPUTextBox.Clear();

            RAM = null;
            ROM = null;
            CPU = null;
            GPU = null;
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

        private void RAMEditButton_Click(object sender, EventArgs e) {
            EditRAM();
        }

        private void ROMEditButton_Click(object sender, EventArgs e) {
            EditROM();
        }

        private void CPUEditButton_Click(object sender, EventArgs e) {
            EditCPU();
        }

        private void GPUEditButton_Click(object sender, EventArgs e) {
            EditGPU();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Save();
        }

        private void WatchButton_Click(object sender, EventArgs e) {
            Watch();
        }
    }
}
