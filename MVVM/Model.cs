using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    internal class Model
    {
        public static List<string> ariphmeticOperation = new() { "Сложение", "Вычитание", "Умножение", "Деление" };

        private double _firstNumber, _secondNumber, _ariphmeticOperationPosition;
        
        public double FirstNumber 
        { 
            set { _firstNumber = value; }
        }

        public double SecondNumber
        {
            set { _secondNumber = value; }
        }

        public int AriphmeticOperationPosition
        {
            set { _ariphmeticOperationPosition = value; }
        }


    }
}
