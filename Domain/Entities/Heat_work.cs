using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Domain.Entities
{
    public class Heat_work
    {
        [Required]
        public int Id { get;set; }

        [Required]
        [Display(Name = "HEAT_NO(Number)")]
        public virtual int HEAT_NO { get; set; }

        [Display(Name = "HEAT_DTE(Date)")]
        public virtual DateTime HEAT_DTE { get; set; }


    }
}
