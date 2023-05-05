using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VKTest.Models
{
    public enum CodeState
    {
        Active,
        Blocked
    }
    public class UserState
    {
        public Guid ID { get; set; }
        public CodeState Code { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }

}