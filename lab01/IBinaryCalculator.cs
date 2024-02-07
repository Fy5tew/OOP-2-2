using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01 {
    internal interface IBinaryCalculator {
        int UnaryMinus(int number);

        int BinaryNOT(int number);

        int BinaryAND(int firstNumber, int secondNumber);

        int BinaryOR(int firstNumber, int secondNumber);

        int BinaryXOR(int firstNumber, int secondNumber);

        int FromHEX(string hex);

        int FromDEC(string dec);

        int FromOCT(string oct);

        int FromBIN(string bin);

        string ToHEX(int number);

        string ToDEC(int number);

        string ToOCT(int number);

        string ToBIN(int number);
    }
}
