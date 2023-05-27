﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeezStoneExample_API.Modelos.Dto
{
    public class NumeroVillaDto
    {
        [Required]
        public int VillaNo { get; set; }

        [Required]
        public int VillaId { get; set; }

        public string DetalleEspecial { get; set; }
    }
}
