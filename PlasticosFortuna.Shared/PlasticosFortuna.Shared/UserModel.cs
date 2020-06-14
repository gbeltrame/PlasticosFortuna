using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlasticosFortuna.Shared
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string LoginId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string EmailAddress { get; set; }
        public UserRole UserRole { get; set; }
    }
}
