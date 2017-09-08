using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage="Lütfen bir isim giriniz.")]
         public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen bir adres giriniz.")]
        
        public string Line1 { get; set; }
        
        [Required(ErrorMessage = "Lütfen bir şehir giriniz.")]
        public string City { get; set; }
        
        public string Zip { get; set; }
        [Required(ErrorMessage = "Lütfen bir ülke giriniz.")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
