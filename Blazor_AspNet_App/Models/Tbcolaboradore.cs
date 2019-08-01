using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_AspNet_App.Models
{
    [Table("TBColaboradores")]
    public partial class Tbcolaboradore
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Nome { get; set; }
        [Required]
        [StringLength(20)]
        public string Cidade { get; set; }
        [Required]
        [StringLength(20)]
        public string Departamento { get; set; }
        [Required]
        [StringLength(6)]
        public string Genero { get; set; }
    }
}