using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Fidelity
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Number { get; set; } = null!;
        public bool? ActivePromo { get; set; }

        public virtual Client Client { get; set; } = null!;
    }
}
