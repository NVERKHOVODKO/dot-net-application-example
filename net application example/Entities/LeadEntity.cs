using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class LeadEntity: BaseEntity
    {
        public Guid PersonId { get; set; }
        [JsonIgnore]
        [ForeignKey("PersonId")]
        public PersonEntity Person { get; set; }
    }
}