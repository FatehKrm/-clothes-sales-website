using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string User_Password { get; set; }
        public string User_Email { get; set; }
        public string Name_LastName { get; set; }
        public string User_Adress { get; set; }
        public string Phone_Number { get; set; }
        public DateTime User_Regstion { get; set; }
        public string User_Rol { get; set; }

    }
}
