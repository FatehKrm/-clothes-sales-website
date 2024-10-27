using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Colors
    {
        [Key]
        public int ColorId { get; set; }
        public string ColorCode { get; set; }
        public string ColorName { get; set; }
        public string ProductCode { get; set; }

    }
}
