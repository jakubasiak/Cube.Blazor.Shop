using System;
using System.Collections.Generic;
using System.Text;


namespace Cube.Blazor.Shop.Shared.Models
{
    public class Edition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
