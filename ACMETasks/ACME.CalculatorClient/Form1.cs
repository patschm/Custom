using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME.CalculatorClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            SynchronizationContext ctx = SynchronizationContext.Current;

            string sa = txtA.Text;
            bool aok = int.TryParse(sa, out int a);
            string sb = txtB.Text;
            bool bok = int.TryParse(sb, out int b);
            if (bok && aok)
            {
                //int result = Add(a, b);
                //UpdateLabel(result);

                //Task.Run<int>(() => Add(a, b))
                //    .ContinueWith(pt =>
                //    {
                //        ctx.Post(UpdateLabel, pt.Result);
                //    });

                int result = await AddAsync(a, b);
                UpdateLabel(result);
            }
        }

        private void UpdateLabel(object val)
        {
            lblAnswer.Text = val.ToString();
        }

        private int Add(int a, int b)
        {
            Task.Delay(10000).Wait();
            return a + b;
        }
        private Task<int> AddAsync(int a, int b)
        {
            return Task.Run(()=>Add(a,b));
        }
       
    }
}
