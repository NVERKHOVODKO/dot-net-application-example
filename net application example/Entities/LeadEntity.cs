﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class LeadEntity: BaseEntity
    {
        [JsonIgnore]
        [ForeignKey("PersonId")]
        public PersonEntity Person { get; set; }
        
        public Guid PersonId { get; set; }
    }
}