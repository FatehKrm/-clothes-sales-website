using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Sizes
    {
        [Key]
        public int Size_Id { get; set; }
        public string SizeName { get; set; }

    }
}
