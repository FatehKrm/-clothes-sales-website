using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Products
    {
        [Key]
        public int P_Id { get; set; }  // P means Product . 
        public string P_Name { get; set; }
        public int p_Categry_Id { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? P_Price { get; set; }
        public int Stok_Quantity { get; set; }
        public string? Description { get; set; }
        public string? ImageURL { get; set; }
        public DateTime? Added_Date { get; set; }
        public string? P_Code { get; set; } // ürün kodu 
        public string P_Color { get; set; }
        public string P_ColorCode { get; set; }
        public bool P_IsActive { get; set; }
        public string P_Size { get; set; }

      
    }
}
