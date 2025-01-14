﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DAOs.Request
{
    public class ProductRequest
    {
        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string? Description { get; set; }

        public string Category { get; set; } = null!;

        public decimal UnitPrice { get; set; }

        public decimal CostPrice { get; set; }

        public decimal Weight { get; set; }

        public bool IsJewelry { get; set; }

        public bool IsGold { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
