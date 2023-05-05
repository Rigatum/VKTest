using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UserGroupID { get; set; }
        public UserGroup UserGroup { get; set; }
        public Guid UserStateID { get; set; }
        public UserState UserState { get; set; }
    }
}