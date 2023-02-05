using System.Collections.Generic;
using System.Windows;

namespace MVVM
{
    internal class Model
    {
        public List<string> ariphmeticOperation = new() { "Сложение", "Вычитание", "Умножение", "Деление" };
        public List<string> ariphmeticOperationSign = new() { "+", "-", "*", "/" };

        private double _firstNumber = 0, _secondNumber = 0;
        private int _ariphmeticOperationPosition = 0;

        public void SetNumbersAndIndex(double firstNumber, double secondNumber, int ariphmeticOperationPosition)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
            _ariphmeticOperationPosition = ariphmeticOperationPosition;
        }

        public double Answer // Подсчет ответа
        {
            get
            {
                try
                {
                    switch (_ariphmeticOperationPosition)
                    {
                        case 0:
                            return _firstNumber + _secondNumber;

                        case 1:
                            return _firstNumber - _secondNumber;

                        case 2:
                            return _firstNumber * _secondNumber;

                        case 3:
                            return _firstNumber / _secondNumber;

                        default:
                            return 0;
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                    return 0;
                }
            }
        }
    }
}
