using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_learn.models
{
    public class Stock
    {
        public int Id { get; set; }

        [StringLength(255)] // Adjust the length as needed
        public string Symbol { get; set; } = string.Empty;

        [StringLength(255)] // Adjust the length as needed
        public string CompanyName { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }

        [StringLength(255)] // Adjust the length as needed
        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        // Assuming this is a self-referencing one-to-many relationship
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}