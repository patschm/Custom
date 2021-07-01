using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Spooky
{
    class Program
    {
        static void Main(string[] args)
        {
            // LeestMetas();
            NouWordtHetLeuk();
        }

        private static async void NouWordtHetLeuk()
        {
            Assembly asm = Assembly.LoadFrom(@"D:\Onderwater.dll");
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
