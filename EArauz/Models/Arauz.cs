using System;
using System.ComponentModel.DataAnnotations;

namespace EArauz.Models
{
    public class Arauz
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int IDBanner { get; set; }

        [Required]
        public float Promedio { get; set; }

        [Required]
        public string? NombreApellido { get; set; }

        [Required]
        public bool Asistencia { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
