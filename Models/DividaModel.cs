using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDividasCore.Models
{
    public class Divida
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
    }
}