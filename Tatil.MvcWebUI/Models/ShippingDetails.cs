using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tatil.MvcWebUI.Models
{
    public class ShippingDetails
    {
       
        public string UserName { get; set; }
        [Required(ErrorMessage ="Lütfen TC Kimlik numaranızı giriniz.")]
        public string TCKimlik { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon numaranızı giriniz.")]
        public string Telefon { get; set; }


    }
}