using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue=false)]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Bir ürün ismi girin.")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Bir açıklama girin.")]
        public string Description { get; set; }
        [Required]
        [Range(0.01,double.MaxValue, ErrorMessage = "Bir fiyat girin.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage ="Kategori gerekli.")]
        public string Category { get; set; }
    }
}
