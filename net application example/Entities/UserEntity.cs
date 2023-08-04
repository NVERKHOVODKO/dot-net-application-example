using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
    }
}