using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDividasCore.Models
{
    public class Divida
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid ClienteId { get; set; }
        [Required]
        public string Motivo { get; set; }
        [Required]
        public float Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }
}