using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Persona
    {
       
        public string Name { get; set; }

        public string LastName { get; set; }
        
        public int Age { get; set; }

        public string Address { get; set; }

        public virtual void getFullName()
        {
            Console.WriteLine($"Full Name: {Name} {LastName}");
        }

        public virtual void getDetails()
        {
            Console.WriteLine($"Age: {Age}\nAddress: {Address}");
        }
    }
}
