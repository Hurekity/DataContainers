using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace Police
{
    internal class Base
    {
        const string delimiter = "\n------------------------------------------";
        private Dictionary<LicencePlate, List<Crime>> police_base;

        public Base(Dictionary<LicencePlate, List<Crime>> police_base)
        {
            this.police_base = new Dictionary<LicencePlate, List<Crime>>(police_base);
        }
        public void Print()
        {
            foreach (KeyValuePair<LicencePlate, List<Crime>> i in police_base)
            {
                Console.WriteLine($"{i.Key}:\n");
                foreach (Crime j in i.Value)
                {
                    Console.WriteLine($"\t {j}");
                }
                Console.WriteLine(delimiter);
            }
        }
        public void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (KeyValuePair<LicencePlate, List<Crime>> i in police_base)
            {
                sw.Write(i.Key + ":");
                foreach (Crime j in i.Value)
                {

                    sw.Write("\n" + j + ",");

                }
                sw.WriteLine();
            }
            sw.Close();
            System.Diagnostics.Process.Start("notepad", filename);
        }
        public void Read(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
