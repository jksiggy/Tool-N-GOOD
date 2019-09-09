﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Tool_N_GOOD.Models
{
    public class BrandType
    {
        [Key]
        public int BrandTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
    }
}