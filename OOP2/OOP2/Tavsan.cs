using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Tavsan : Hayvan<string>
    {
        public string Renk { get; set; }
        public override void VoiceAnimal()
        {
            Console.WriteLine("fıtıfııtı");
        }
    }
}
