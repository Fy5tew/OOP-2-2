using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal class Calculator: IBinaryCalculator {
        public int UnaryMinus(int number) {
            return -number;
        }

        public int BinaryNOT(int number) {
            return ~number;
        }

        public int BinaryAND(int firstNumber, int secondNumber) {
            return firstNumber & secondNumber;
        }

        public int BinaryOR(int firstNumber, int secondNumber) {
            return firstNumber | secondNumber;
        }

        public int BinaryXOR(int firstNumber, int secondNumber) {
            return firstNumber ^ secondNumber;
        }

        public int FromHEX(string hex) {
            return Convert.ToInt32(hex, 16);
        }

        public int FromDEC(string dec) {
            return Convert.ToInt32(dec, 10);
        }

        public int FromOCT(string oct) {
            return Convert.ToInt32(oct, 8);
        }

        public int FromBIN(string bin) {
            return Convert.ToInt32(bin, 2);
        }

        public string ToHEX(int number) {
            return Convert.ToString(number, 16);
        }

        public string ToDEC(int number) {
            return Convert.ToString(number, 10);
        }

        public string ToOCT(int number) {
            return Convert.ToString(number, 8);
        }

        public string ToBIN(int number) {
            return Convert.ToString(number, 2);
        }
    }
}
