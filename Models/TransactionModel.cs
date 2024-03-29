﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxCRUDInASPNETCore.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        
        [MaxLength(12)]
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName="nvarchar(12)")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
