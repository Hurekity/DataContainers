using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Police
{
    class Program
    {
        
        static void Main(string[] args)
        {

            #region CHECK
            /*Dictionary<int, string> pairs = new Dictionary<int, string>()
            {
                [1] = "Ремень безопасности",
                [2] = "Превышение скорости"
            };
            Console.WriteLine(Violations.list.Count);
            Crime crime = new Crime(1, new DateTime(2023, 05, 23), "Lenin Street");
            Console.WriteLine(crime); */
            #endregion

            Dictionary<LicencePlate, List<Crime>> police_base = new Dictionary<LicencePlate, List<Crime>>()
            {
                [new LicencePlate("M137NB")] = new List<Crime>()
                {
                    new Crime(1, new DateTime(2023, 05, 23, 13, 30, 00), "Lenin Street"),
                    new Crime(2, new DateTime(2023, 05, 23, 13, 30, 00), "Lenin Street")
                },

                [new LicencePlate("A001BB")] = new List<Crime>()
                {
                    new Crime(3, new DateTime(2023, 06, 12,19,02,00), "Astronauts Street"),
                    new Crime(4, new DateTime(2023, 06, 12,19,02,00), "Astronauts Street"),
                    new Crime(5, new DateTime(2023, 06, 12,19,02,00), "Astronauts Street")
                },

                [new LicencePlate("A123BB")] = new List<Crime>()
                {
                    new Crime(6, new DateTime(2023, 06, 12,19,02,00), "Paris commune Street"),
                    new Crime(7, new DateTime(2023, 06, 12,19,02,00), "Paris commune Street"),
                    new Crime(8, new DateTime(2023, 06, 12,19,02,00), "Sholom Aleihom Street")
                }
            };
            /*for ( Dictionary<LicencePlate, List<Crime>>.Enumerator en = police_base.GetEnumerator(); en.Current.Key != police_base.Last().Key; en.MoveNext())
             {
                 Console.WriteLine(en.Current.Key);
             }*/
            #region PrintInMain
            /* foreach (KeyValuePair<LicencePlate, List<Crime>> i in police_base)
             {
                 Console.WriteLine($"{i.Key}:\n");
                 foreach (Crime j in i.Value)
                 {
                     Console.WriteLine($"\t {j}");
                 }
                 Console.WriteLine(delimiter);
             }
             string str = "Парковка в неположенном месте";
             Console.WriteLine(str);*/
            #endregion
            Base @base = new Base();
            @base.Load("Base.txt");
            @base.Print();
        }
        const string delimiter = "\n------------------------------------------";
       
    }
}
