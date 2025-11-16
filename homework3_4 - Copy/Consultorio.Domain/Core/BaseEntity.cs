using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Consultorio.Domain.Core
    {
            public abstract class BaseEntity
            {
                public int Id { get; set; }


       

        [NotMapped] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [NotMapped] public bool IsActive { get; set; } = true;
            }

        

    }
