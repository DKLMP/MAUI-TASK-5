using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_TASK_5.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public string resultText = "0";
        [ObservableProperty]
        string currentEntry = "";
        [ObservableProperty]
        int currentState = 1;
        [ObservableProperty]
        string mathOperator;
        [ObservableProperty]
        double firstNumber, secondNumber;
        [ObservableProperty]
        string decimalFormat = "N0";
        [ObservableProperty]
        string buttonText;

        public string _pressed;
        public string pressed 
        {
            get
            {
                return _pressed;
            } 
            set
            { 
                _pressed =   ; }
        }


        [RelayCommand]
       public void SelectNumber()
        {
            currentEntry += pressed;
            if ((resultText == "0" && pressed == "0")
                || (currentEntry.Length <= 1 && pressed != "0")
                || currentState < 0)
            {
                resultText = "";
                if (currentState < 0)
                    currentState *= -1;
            }

            if (pressed == "." && decimalFormat != "N2")
            {
                decimalFormat = "N2";
            }
            resultText += pressed;
        }
    }
}
