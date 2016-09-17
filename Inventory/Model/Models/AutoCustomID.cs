using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class AutoCustomID
    {
        public long Id { get; set; }
        public Nullable<long> CompanyId { get; set; }
        public string ObjectName { get; set; }
        public bool IDType { get; set; }
        public int NoOfCharacter { get; set; }
        public string StartingChar { get; set; }
        public int StartingSequence { get; set; }
        public int IncrementNo { get; set; }
        public string UserName { get; set; }
        public virtual Company Company { get; set; }
    }
}
