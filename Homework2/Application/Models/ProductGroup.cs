﻿namespace Application.Models
{

    public partial class ProductGroup
    {
        public int Id { get; set; }

        public string? Name { get; set; } = null;

        public string? Description { get; set; } = null;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }


}
