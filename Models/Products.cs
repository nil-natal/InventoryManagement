using System;
using System.Collections.Generic;

namespace InventoryManagement.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string Disciplina { get; set; }
        public string Professor { get; set; }
        public string Aula { get; set; }
        public decimal Data { get; set; }
        public int Hora { get; set; }
    }
}
