using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Fransız:Human
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public override void SelamVer()
        {
            Console.WriteLine("Fransız Selamı");
        }

    }
}
