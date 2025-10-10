using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Estudiante: MiembroDeLaComunidad
    {

        
        public string Major { get; set; }
        public int Year { get; set; }
        public double GPA { get; set; }
        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Major: {Major}\nYear: {Year}\nGPA: {GPA}");
        }
    }
}
