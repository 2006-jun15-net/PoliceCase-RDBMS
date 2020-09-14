using System;
using System.Collections.Generic;

namespace Police.Data.Entities
{
    public partial class InvolvedPersons
    {
        public int WitnessId { get; set; }
        public string CaseNumber { get; set; }

        public virtual CaseFolder CaseNumberNavigation { get; set; }
        public virtual Witness Witness { get; set; }
    }
}
