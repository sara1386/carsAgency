using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Car
    {
        public int? CompanyId { get; set; }
        public string? ModelName { get; set; }
        public int? Passengers { get; set; }
        public int Id { get; set; }

        public virtual Company? Company { get; set; }
    }
}
