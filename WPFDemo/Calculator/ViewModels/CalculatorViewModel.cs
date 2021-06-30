using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        public struct Sum
        {
            public int A { get; set; }
            public int B { get; set; }
            public int Answer { get; set; }
        }

        private int a;
        private int b;
        private int answer;
        private CalculatorLogic.Calculator blcalc = new CalculatorLogic.Calculator();

        public int Answer
        {
            get { return answer; }
            set
            {
                answer = value;
                Notify(nameof(Answer));
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                b = value;
                Notify(nameof(B));
            }
        }
        public int A
        {
            get { return a; }
            set
            {
                a = value;
                Notify(nameof(A));
            }
        }

        public ObservableCollection<Sum> History { get; set; } = new ObservableCollection<Sum>();

        public RelayCommand CommandPlus
        {
            get
            {
                return new RelayCommand(o =>
                {
                    Answer = blcalc.Add(A, B);
                    History.Add(new Sum { A = A, B = B, Answer = Answer });
                });
            }
        }
    }
}
