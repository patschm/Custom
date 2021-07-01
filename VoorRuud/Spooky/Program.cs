using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace Spooky
{
    class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            // LeestMetas();
            NouWordtHetLeuk();
            Console.ReadLine();
        }

        private static async void NouWordtHetLeuk()
        {
            var result = await client.GetAsync("assembly/ow");
            var bassm = await result.Content.ReadAsByteArrayAsync();
            Assembly asm = Assembly.Load(bassm);

            //Assembly asm = Assembly.LoadFrom(@"D:\Onderwater.dll");
            Type tesType = asm.GetType("OnderWater.Test");
            object obj = Activator.CreateInstance(tesType);

            MethodInfo dimethod = tesType.GetMethod("DoeIets");
            Task<int> res = dimethod.Invoke(obj, new object[] { }) as Task<int>;
            Console.WriteLine(await res);
        }

        private static void LeestMetas()
        {
            Assembly asm = Assembly.LoadFrom(@"D:\Onderwater.dll");
            Console.WriteLine(asm.FullName);
            foreach(Type tp in asm.GetTypes())
            {
                Console.WriteLine(tp.FullName);
                foreach(MemberInfo mi in tp.GetMembers())
                {
                    Console.WriteLine(mi.Name);
                }
            }
        }
    }
}
