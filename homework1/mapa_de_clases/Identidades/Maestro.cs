using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Maestro: Docente
    {
        
        public string Subject { get; set; }
        public int NumberOfStudents { get; set; }
        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Subject: {Subject}\nNumber of Students: {NumberOfStudents}");
        }


    }
}
