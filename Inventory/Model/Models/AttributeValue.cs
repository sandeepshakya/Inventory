using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class AttributeValue
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public string Value { get; set; }
        public int ValueId { get; set; }
    }
}
