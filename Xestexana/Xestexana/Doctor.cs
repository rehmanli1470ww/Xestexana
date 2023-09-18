using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xestexana
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        public Doctor(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Specialty: {Specialty}");
        }
    }

}
