﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class ProductEntity: BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime? BuyDate { get; set; }
        public DateTime? SellDate { get; set; }
        [JsonIgnore]
        [ForeignKey("CategoryId")]
        public CategoryEntity Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}