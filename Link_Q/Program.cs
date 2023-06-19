using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Q
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Countri> Countries = new List<Countri>();

            Countries.Add(
                new Countri
                {
                    Name = "Україна",
                    Capital = "Київ",
                    Square = 603700 + 153,
                    People = 43000000,
                    Part = "Європа"
                }
            );
            Countries.Add(
                new Countri
                {
                    Name = "Польща",
                    Capital = "Варшава",
                    Square = 322575,
                    People = 3700750,
                    Part = "Європа"
                }
            );
            Countries.Add(
                new Countri
                {
                    Name = "США",
                    Capital = "Вашингтон",
                    Square = 9834000,
                    People = 3319000,
                    Part = "Америка"
                }
            );
            Countries.Add(
               new Countri
               {
                   Name = "Китай",
                   Capital = "Пекин",
                   Square = 9598962,
                   People = 1411750000,
                   Part = "Азія"
               }
           );





            var res = from c in Countries select c;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            var res1 = from c in Countries select c.Name;
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            var res2 = from c in Countries select c.Capital;
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            var res3 = from c in Countries
                       where c.Part=="Європа"
                       select c.Name;
            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            var res4 = from c in Countries
                       where c.Square > 400000
                       select c.Name +" "+c.Square;
            foreach (var item in res4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Отобразить все страны, у которых в названии есть буквы a, u;");
            var res5 = from c in Countries
                       where c.Name.ToLower().Contains("а")
                       select c.Name;
            foreach (var item in res5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Отобразить все страны, у которых название начинается с буквы a;");
            var res6 = from c in Countries
                       where c.Name.ToLower().StartsWith("a")
                       select c.Name;
            foreach (var item in res6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Отобразить название стран, у которых площадь находится в указанном диапазоне; 300000-500000");
            var res7 = from c in Countries
                       where c.Square>300000 && c.Square<500000
                       select c.Name + " " + c.Square;
            foreach (var item in res7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Отобразить название стран, у которых количество жителей больше указанного числа");
            var res8 = from c in Countries
                       where c.People > 3000000
                       select c.Name;
            foreach (var item in res8)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------------");


            Console.WriteLine("Показать топ-5 стран по площади;");
            var res9 = (from c in Countries
                        orderby c.Square descending
                        select c).Take(5);
            foreach (var item in res9)
            {
                Console.WriteLine(item.Name +" "+ item.Square);
            }
            Console.WriteLine("---------------------------------------------");
            
            Console.WriteLine("Показать топ-5 стран по количеству жителей;");
            var res10 = (from c in Countries
                        orderby c.People descending
                        select c).Take(5);
            foreach (var item in res10)
            {
                Console.WriteLine(item.Name +" "+ item.People);
            }
            Console.WriteLine("---------------------------------------------");
            
            
            Console.WriteLine("Показать страну с самой большой площадью;");
            var res11 = (from c in Countries
                         orderby c.Square descending
                         select c).Take(1);
            foreach (var item in res11)
            {
                Console.WriteLine(item.Name + " " + item.Square);
            }
            Console.WriteLine("---------------------------------------------");


            Console.WriteLine("Показать страну с самой маленькой площадью в Африке;");
            var res12 = (from c in Countries
                         where c.Part=="Африка"
                         orderby c.Square ascending
                         select c).Take(1);
            foreach (var item in res12)
            {
                Console.WriteLine(item.Name + " " + item.Square);
            }
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Показать среднюю площадь стран в Азии");
            var res13 = (from c in Countries
                         where c.Part == "Азія"
                         select c.Square).Average();

            Console.WriteLine(res13);
            Console.WriteLine("---------------------------------------------");

            Console.ReadLine();
        }
    }
}
