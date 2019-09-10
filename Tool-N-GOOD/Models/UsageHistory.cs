﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tool_N_GOOD.Models
{
    public class UsageHistory
    {
        [Key]
        public int UsageHistoryId { get; set; }
        [Required]
        
        public string UserId { get; set; }

        [Display(Name = "Borrower")]
        public ApplicationUser User { get; set; }
        [Required]
        public int ToolId { get; set; }
        public Tool Tool { get; set; }
        [Required]
        [Display(Name = "Work")]
        public string TaskFor { get; set; }
        [Required]
        public bool Inspection { get; set; }
        [Required]
        public bool Serviceable { get; set; }

        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Checkout Date")]
        public DateTime? CheckoutTime { get; set; }

        [Display(Name = "Expected Date")]
        public DateTime? ExpectedReturn { get; set; }

        [Required]
        [Display(Name = "Date Return ")]
        public DateTime PromiseReturn { get; set; }
    }
}