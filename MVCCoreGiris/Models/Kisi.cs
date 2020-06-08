using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreGiris.Models
{
    public class Kisi
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [Display(Name = "Ad")]
        public string KisiAd { get; set; }
    }
}
