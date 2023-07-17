using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public int Id { get;set; }

        [Display(Name = "Бригада)")]
        public virtual int Team { get; set; }

        [Display(Name = "Дата")]
        public virtual DateTime DataTeam { get; set; }

        //[Display(Name = "Rec_ID")]
        //public virtual int  Rec_Id { get; set; }

        //[Display(Name = "HEAT_NO(Number)")]
        //public virtual int HEAT_NO { get; set; }

        //[Display(Name = "HEAT_DTE(Date)")]
        //public virtual DateTime HEAT_DTE { get; set; }


    }
}
