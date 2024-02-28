using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02 {
    public class PC {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime InstallationDate { get; set; }
        public string InstallationTime { get; set; }
        public Memory RAM { get; set; }
        public Memory ROM { get; set; }
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }

        public double CalculatePrice() {
            return RAM.CalculatePrice() + ROM.CalculatePrice() + CPU.CalculatePrice() + GPU.CalculatePrice();
        }

        public override string ToString() {
            return $"{Type} '{Name}':\n" +
                $"\tУстановлен {InstallationDate.Date.ToString("dd.MM.yyyy")} в {InstallationTime}\n" +
                $"\tОЗУ: {RAM}\n" +
                $"\tПЗУ: {ROM}\n" +
                $"\tПроцессор:\n\t\t{CPU.ToString().Replace("\n", "\n\t\t")}\n" +
                $"\tВидеокарта:\n\t\t{GPU.ToString().Replace("\n", "\n\t\t")}\n" +
                $"\tРасчетная стоимость: {CalculatePrice():F2} BYN";
        }
    }

    public class CPU {
        public string Manufacturer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public int CoresCount { get; set; }
        public Frequency WorkingFrequency { get; set; }
        public Frequency MaxFrequency { get; set; }
        public string Architecture { get; set; }
        public Memory[] Cache { get; set; }

        public double CalculatePrice() {
            return (1.4 * CoresCount) + (0.2 * WorkingFrequency.Value);
        }

        public override string ToString() {
            return $"{Architecture} {CoresCount}-ядерный {Manufacturer} {Series} {Model}\n" +
                $"Частота: {WorkingFrequency} (Максимум {MaxFrequency})\n" +
                $"Кэш: {string.Join(", ", Cache.Select(cache => cache.ToString()))}";
        }
    }

    public class GPU {
        public string Manufacturer { get; set; }
        public string Series { get; set; }
        public string Model { get; set; }
        public Memory Memory { get; set; }
        public Frequency WorkingFrequency { get; set; }
        public Frequency MaxFrequency { get; set; }
        public bool DX11Support { get; set; }

        public double CalculatePrice() {
            return Memory.CalculatePrice() + (1.8 * WorkingFrequency.Value) + (DX11Support ? 20.6 : 0);
        }

        public override string ToString() {
            return $"{Memory} {Manufacturer} {Series} {Model}\n" +
                $"Частота: {WorkingFrequency} (Максимум {MaxFrequency})\n" +
                (DX11Support ? "Поддерживает DirectX11" : "Не поддерживает DirectX11");
        }
    }

    public class Memory {
        public string Type { get; set; }
        public long Volume { get; set; }
        public string VolumeType { get; set; }

        public double CalculatePrice() {
            return 1.7 * Volume;
        }

        public override string ToString() {
            return $"{Volume} {VolumeType} {Type}";
        }
    }

    public class Frequency {
        public double Value { get; set; }
        public string Type { get; set; }

        public override string ToString() {
            return $"{Value} {Type}";
        }
    }
}
