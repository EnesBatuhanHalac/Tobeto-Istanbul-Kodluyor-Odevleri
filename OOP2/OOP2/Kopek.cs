using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Kopek:Hayvan<string>
    {
        public void GetName(string name)
        {
            Console.WriteLine(name);
        }
        public string Türü { get; set; }
        public override void VoiceAnimal()
        {
            Console.WriteLine("Hav Hav Hav");
        }
    }
}
