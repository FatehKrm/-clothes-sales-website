using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }  // Miktar

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }  // Siparilteki ürünün birim fiyatı 
        [Column(TypeName = "decimal(18,2)")]
        public decimal Payments { get; set; } // Ödemeler
    }
}
