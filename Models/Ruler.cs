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
        public string Type { get; set; }
        public string Shape { get; set; }
        public string Material { get; set; }
        public string Measurement { get; set; }
        public string Color { get; set; }
        public string Use { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }

    public class RulerShapeViewModel
    {
        public List<Ruler> Rulers { get; set; }
        public SelectList Shapes { get; set; }
        public string RulerShape { get; set; }
        public string SearchString { get; set; }
    }

}
