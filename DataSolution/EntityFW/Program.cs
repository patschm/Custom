using EntityFW.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Linq;

namespace EntityFW
{
    class Program
    {
        private static string constring = @"Server=.\SqlExpress;Database=HobbyDB;Trusted_Connection=True;MultipleActiveResultSets=true;";

        static void Main(string[] args)
        {
            //InsertData();
            try
            {
                LeesData();
            }
            catch(DbUpdateConcurrencyException de)
            {

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void LeesData()
        {
            DbContextOptionsBuilder bld = new DbContextOptionsBuilder();
            bld.UseSqlServer(constring);

            HobbyContext ctx = new HobbyContext(bld.Options);
            var query = ctx.People.Include(p=>p.Hobbies).ThenInclude(ph=>ph.Hobby);

                foreach (var p in query)
                {
                    Console.WriteLine($"[{p.ID}] {p.FirstName} {p.LastName} ({p.Age})");
                    foreach (var h in p.Hobbies)
                    {
                        Console.WriteLine($"\t{h.Hobby.Description}");
                    }
                }
         

            Person p1 = ctx.People.FirstOrDefault();
            p1.LastName = "Hendriks";

            ctx.SaveChanges();

            var e1 = ctx.Entry(p1);
            Console.WriteLine($"{e1.CurrentValues}");
            Console.WriteLine($"{e1.OriginalValues}");
        }

        static void InsertData()
        {
            DbContextOptionsBuilder bld = new DbContextOptionsBuilder();
            bld.UseSqlServer(constring);

            HobbyContext ctx = new HobbyContext(bld.Options);
            //ctx.Database.EnsureCreated();

            Person p1 = new Person { Age = 42, FirstName = "Kees", LastName = "de Vries" };
            Person p2 = new Person { Age = 34, FirstName = "Marieke", LastName = "Otten" };

            Hobby h1 = new Hobby { Description = "Programmeren" };
            Hobby h2 = new Hobby { Description = "Zeilen" };
            Hobby h3 = new Hobby { Description = "Sigarenbandjes" };

            p1.Hobbies.Add(new PersonHobby { Hobby = h1 });
            p1.Hobbies.Add(new PersonHobby { Hobby = h2 });
            p2.Hobbies.Add(new PersonHobby { Hobby = h3 });
            p2.Hobbies.Add(new PersonHobby { Hobby = h1 });

            ctx.People.Add(p1);
            ctx.People.Add(p2);

            ctx.SaveChanges();

            Console.WriteLine("Gelukt!!!!");
        }
    }
}
