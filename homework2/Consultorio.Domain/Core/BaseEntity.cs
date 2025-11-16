using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Domain.Core
{
    namespace Consultorio.Domain.Core
    {
        public class BaseEntity
        {
            public int Id { get; set; }

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
            public DateTime? UpdatedAt { get; set; }
            public bool IsActive { get; set; } = true;
            public bool IsDeleted { get; set; } = false;

            public void MarkAsDeleted()
            {
                IsDeleted = true;
                IsActive = false;
                UpdatedAt = DateTime.UtcNow;
            }
        }
    }

}
