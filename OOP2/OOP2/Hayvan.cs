using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Hayvan<T>
    {
        public int Id { get; set; }
        public T Name { get; set; }
        public string Voice { get; set; }
        public virtual void VoiceAnimal()
        {
        }
    }
}
