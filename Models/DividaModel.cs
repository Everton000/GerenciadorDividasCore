using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDividasCore.Models
{
    public class Divida
    {
        [Required]
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public string Motivo { get; set; }
        public float Valor { get; set; }
        public DateTime Data { get; set; }
    }
}