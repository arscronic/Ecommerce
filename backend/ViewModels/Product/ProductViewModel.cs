﻿using System.ComponentModel.DataAnnotations;

namespace backend.ViewModels.Product
{
    public class ProductViewModel
    {

        public string Title { get; set; } = null!;


        public string Description { get; set; } = null!;


        public decimal Price { get; set; }


        public int Quantity { get; set; }

        public string? ImagePath { get; set; }


        public bool IsActive { get; set; }
    }
}
