using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class ExAlumno: MiembroDeLaComunidad
    {

        public int GraduationYear { get; set; }
        public string CurrentEmployer { get; set; }
        public string JobTitle { get; set; }
        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Graduation Year: {GraduationYear}\nCurrent Employer: {CurrentEmployer}\nJob Title: {JobTitle}");
        }
    }
}
