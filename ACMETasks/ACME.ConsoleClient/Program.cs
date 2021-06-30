using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACME.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Synchroon();
            //AsynchronousOldStyle();
            //AsynchroonNewStyle();
            //TaskGein();
            //TaskFouten();
            //AsynchroonHip();
            //Rommelig();
            MeerFun();
            Console.WriteLine("Klaar!!!");
            Console.ReadLine();
        }

        private static async void MeerFun()
        {
            int result = 0;
            var t1 =Task.Run(async () => {
                await Task.Delay(2000);
                result += 42;
            });
            var t2 = Task.Run(async () => {
                Task.Delay(3000);
                result += 12;
            });

            await Task.WhenAll(t1, t2);
            Console.WriteLine(result);
        }

        private static async void AsynchroonHip()
        {

            int res2 = await AddAsync(1, 2);
            Console.WriteLine(res2);


            Task<int> t1 = Task.Run<int>(()=>Add(5, 6));
            int result = await t1;
            Console.WriteLine($"En verder met {result}");
            try
            {
                await Task.Run(() =>
                    {
                        Console.WriteLine("Start");
                        throw new Exception("Oooops");
                    });
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TaskFouten()
        {
            //try
            //{
            //    Task t1 = Task.Run(() =>
            //    {
            //        Console.WriteLine("Start");
            //        throw new Exception("Oooops");
            //    });
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}
            Task.Run(() =>
                {
                    Console.WriteLine("Start");
                    throw new Exception("Oooops");
                }).ContinueWith(pt => {
                    if (pt.Exception != null)
                    {
                        Console.WriteLine(pt.Exception.InnerException.Message);
                    }
                });
        }

        private static void TaskGein()
        {
            CancellationTokenSource nikko = new CancellationTokenSource();

            CancellationToken bommetje = nikko.Token;
            Task t1 = Task.Run(()=> { 
                for(int i = 0; i < 1000; i++)
                {
                    //bommetje.ThrowIfCancellationRequested();
                    if (bommetje.IsCancellationRequested)
                    {
                        Console.WriteLine("Bye");
                        return;
                    }
                    Task.Delay(100).Wait();
                    Console.WriteLine(i);
                }
            });

            Console.ReadLine();
            nikko.Cancel();
            Console.WriteLine(t1.IsFaulted);
        }

        private static void Rommelig()
        {
            int counter = 0;
            for(int i = 0; i < 10; i++)
            {
                Task.Run(() => {
                    int tmp = counter;
                    tmp++;
                    Task.Delay(500).Wait();
                    counter = tmp;
                    Console.WriteLine(counter);
                });
            }
            
        }

        private static void AsynchroonNewStyle()
        {
       
            Task<int> t1 = new Task<int>(() =>  Add(3, 4));
            t1.ContinueWith(pt => { 
                int result = pt.Result;
                Console.WriteLine(result);
            });
 
            t1.Start();

            // Beter
            Task.Run<int>(() => Add(5, 6))
                .ContinueWith(pt => Console.WriteLine(pt.Result));


        }

        private static void AsynchronousOldStyle()
        {
            Func<int, int, int> del = Add;
            del.BeginInvoke(2, 3, IkBenKlaar, del);
          
        }

        private static void IkBenKlaar(IAsyncResult ar)
        {

            Func<int, int, int> del = ar.AsyncState as Func<int, int, int>;
            int result = del.EndInvoke(ar);
            Console.WriteLine(result);
        }

        private static void Synchroon()
        {
            int result = Add(3, 4);
            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            Task.Delay(10000).Wait();
            return a + b;
        }
        static Task<int> AddAsync(int a, int b)
        {
            return Task.Run(() => Add(a, b));
        }
    }
}
