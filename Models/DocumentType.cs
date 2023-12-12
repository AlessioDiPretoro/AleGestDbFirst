using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            Ddts = new HashSet<Ddt>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Ddt> Ddts { get; set; }
    }
}
