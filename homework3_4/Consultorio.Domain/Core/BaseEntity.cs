using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Consultorio.Domain.Core
    {
            public abstract class BaseEntity
            {
                public int Id { get; set; }
                public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
                public bool IsActive { get; set; } = true;
            }

        

    }
