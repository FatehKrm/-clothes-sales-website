using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class TemporanyColors
    {
        [Key]
        public int TemporanyId { get; set; }
        public string TemporanyColorName { get; set; }
        public string  TemporanyColorCode { get; set; }
        public bool TemporanyColorIsActive { get; set; }
    }
}
