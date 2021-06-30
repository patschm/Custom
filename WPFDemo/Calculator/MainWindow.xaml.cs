using Calculator.ViewModels;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculatorViewModel vmodel = new CalculatorViewModel();
        //private CalculatorLogic.Calculator blcalc = new CalculatorLogic.Calculator();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vmodel;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    vmodel.Answer =  blcalc.Add(vmodel.A, vmodel.B);
        //}
    }
}
