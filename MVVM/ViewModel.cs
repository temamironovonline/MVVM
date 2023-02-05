using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System;

namespace MVVM
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private Model _model = new Model();

        public List<string> GetAriphmeticOperations // Для присваивания значений в Combo Box из списка арифметический операций
        {
            get
            {
                return _model.ariphmeticOperation;
            }
        }

        private int _ariphmeticOperationIndex = -1; // Индекс для combo box

        public string AriphmeticOperationIndex // Получение знака арифметической операции
        {
            get 
            { 
                if (_ariphmeticOperationIndex == -1)
                {
                    return "";
                }
                else
                {
                    return _model.ariphmeticOperationSign[_ariphmeticOperationIndex];
                }
            }
        }

        public int SelectedIndex // Изменение индекса при выборе арифметической операции
        {
            set
            {
                _ariphmeticOperationIndex = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AriphmeticOperationIndex"));
            }
        }

        private double _firstNumber = 0, _secondNumber = 0;

        public double FirstNumber // Присваивание значения переменной из TextBox первого числа
        {
            set
            {
                _firstNumber = Convert.ToDouble(value);
            }
        }

        public double SecondNumber // Присваивание значения переменной из TextBox второго числа
        {
            set
            {
                _secondNumber = Convert.ToDouble(value);
            }
        }

        public string GetAnswer // Получение ответа
        {
            get
            {
                return Convert.ToString(_model.Answer);
            }
        }

        public RoutedCommand Command { get; set; } = new RoutedCommand();

        public void Command_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                _model.SetNumbersAndIndex(_firstNumber, _secondNumber, _ariphmeticOperationIndex);
                PropertyChanged(this, new PropertyChangedEventArgs("GetAnswer"));
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Проверьте правильность вводимых данных");
            }
        }

        public CommandBinding bind;

        public ViewModel()
        {
            bind = new CommandBinding(Command);
            bind.Executed += Command_Executed;
        }


    }
}
