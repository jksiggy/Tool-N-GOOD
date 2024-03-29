﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool_N_GOOD.Models
{
    public class Tool
    {
       
        [Key]
        public int ToolId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Measurement { get; set; }
        [Required]
        public bool Serviceable { get; set; }

        [Display(Name = "Brand")]
        public int? BrandTypeId { get; set; }

        [Display(Name = "Brand")]
        public BrandType BrandType { get; set; }

        [Display(Name = "Tool Type")]
        public int? ToolTypeId { get; set; }

        [Display(Name = "Tool Type")]
        public ToolType ToolType { get; set; }

        [Required]
        [Display(Name = "Owner")]
        public string UserId { get; set; }

        [Display(Name = "Owner")]
        public ApplicationUser User{ get; set; }

        [Display(Name = "Measurement Type")]
        public int? MeasurementTypeId { get; set; }
        
        [Display(Name = "Measurement Type")]
        public MeasurementType MeasurementType { get; set; }

        public virtual ICollection<UsageHistory> UsageHistories { get; set; }
    
    }
}