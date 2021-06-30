using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        private int a;
        private int b;
        private int answer;

        public int Answer
        {
            get { return answer; }
            set { 
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

    }
}
