using System;
using System.ComponentModel.DataAnnotations;

namespace connectionDB.Models
{
    public class TbAcadActivity
    {
        [Key]
        [Required]
        public int IdAcadActivity { get; set; }

        [Required]
        public int IdUserClass { get; set; }

        [Required]
        [MaxLength(100)]
        public string NmAcadActivity { get; set; }

        [Required]
        public DateTime DtDeadline { get; set; }

        [Required]
        public virtual TbUserClass IdUserClassNavigation { get; set; }
    }
}
