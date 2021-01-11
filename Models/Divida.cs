using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDividasCore.Models
{
    public class Divida
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public string Motivo { get; set; }
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public DateTime? DataExclusao { get; set; }
    }
}