using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class Administrador: Docente
    {

        public string office { get; set; }
        public int team_in_charge { get; set; }

        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Office: {office}\nTeam in Charge: {team_in_charge}");
        }
    }
}
