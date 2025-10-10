using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mapa_de_clases
{
    public class MiembroDeLaComunidad: Persona
    {

        public int Id { get; set; }
        public string Role { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public override void getDetails()
        {
            base.getDetails();
            Console.WriteLine($"Id: {Id}\nRole: {Role}\nEmail: {Email}\nPhone Number: {PhoneNumber}");
        }
    }
}


