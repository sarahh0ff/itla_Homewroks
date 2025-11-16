using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio.Domain.Core;
 using global::Consultorio.Domain.Core.Consultorio.Domain.Core;
   

namespace Consultorio.Domain.Entities
{
        public class Medico : BaseEntity
        {
            public string Name { get; set; } = string.Empty;
            public string Lastname { get; set; } = string.Empty;
            public string Especialidad { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }
    

}
