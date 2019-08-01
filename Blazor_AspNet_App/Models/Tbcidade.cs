using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_AspNet_App.Models
{
    [Table("TBCidades")]
    public partial class Tbcidade
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Cidade { get; set; }
    }
}