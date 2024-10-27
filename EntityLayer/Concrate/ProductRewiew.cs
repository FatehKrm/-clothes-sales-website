using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class ProductRewiew
    {
        [Key]
        public int ProRewId { get; set; } // product Rewiew Id , ürün inceleme id si 
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Raiting { get; set; }
        [Range(1, 5, ErrorMessage = " Değerlendirme puanı 1 ile 5 arası olmalı ")]
        public string Comment { get; set; } // yorumlar 
        public DateTime Date { get; set; }
    }
}
