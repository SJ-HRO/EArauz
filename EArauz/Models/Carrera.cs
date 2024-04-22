using System;
using System.ComponentModel.DataAnnotations;

namespace EArauz.Models
{
    public class Carrera
    {
        [Key]
        public int ArauzId { get; set; }

        [Required]
        public string? NombreCarrera { get; set; }

        [Required]
        public string? Campus { get; set; }

        [Required]
        public int NumeroSemestres { get; set; }
    }
}
