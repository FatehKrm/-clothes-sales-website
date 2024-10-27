using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string  MailAdress { get; set; }
        public string PassWord { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public DateTime  Birth { get; set; }
        public string? ImageUrl { get; set; } 
    }
}
  