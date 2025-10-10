using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Administrativo: Empleado
    {

        public string authority_level { get; set; }
        public int ext_number { get; set; }

        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($" Authority Level: {authority_level}\nExtension Number: {ext_number}");
        }

    }
}
