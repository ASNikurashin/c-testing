using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Domain.Entities
{
    public class ShiftEn : EntityBase
    {
        [Required(ErrorMessage = "Заполните всю смену")]

        [Display(Name = "Бригада")]
        public override int Team { get; set; }

        [Display(Name = "Дата")]
        public override DateTime DataTeam { get; set; }
    }
}
