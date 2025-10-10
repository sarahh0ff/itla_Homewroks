using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Docente: Empleado
    {
        public string Area { get; set; }
        public int YearsOfExperience { get; set; }
        public string AcademicTitle { get; set; }
        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Area: {Area}\nYears of Experience: {YearsOfExperience}\nAcademic Title: {AcademicTitle}");
        }

    }
}
