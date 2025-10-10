using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Empleado: MiembroDeLaComunidad
    {

        public string Department { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Department: {Department}\nPosition: {Position}\nSalary: {Salary}");
        }

    }
}
