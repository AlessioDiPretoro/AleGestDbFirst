using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Client
    {
        public Client()
        {
            Fidelities = new HashSet<Fidelity>();
            Invoices = new HashSet<Invoice>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string EmailPec { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Cell { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Cap { get; set; } = null!;
        public string Prov { get; set; } = null!;
        public string FiscalCode { get; set; } = null!;
        public string PIva { get; set; } = null!;
        public bool IsPrivate { get; set; }

        public virtual ICollection<Fidelity> Fidelities { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
