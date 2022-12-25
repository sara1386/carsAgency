using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Company
    {
        public Company()
        {
            Cars = new HashSet<Car>();
        }

        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public int Id { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
