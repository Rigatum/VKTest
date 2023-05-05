using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VKTest.Models
{
    public enum CodeGroup
    {
        Admin,
        User
    }

    public class UserGroup
    {
        public Guid ID { get; set; }
        public CodeGroup Code { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}