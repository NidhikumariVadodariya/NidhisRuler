using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace NidhisRuler.Models
{
    public class Ruler
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Type { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Shape { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Measurement { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Color { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Use { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Range(1, 5)]
        public decimal Rating { get; set; }
    }

    public class RulerShapeViewModel
    {
        public List<Ruler> Rulers { get; set; }
        public SelectList Shapes { get; set; }
        public string RulerShape { get; set; }
        public string SearchString { get; set; }
    }

}
