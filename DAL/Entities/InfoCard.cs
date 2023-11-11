using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class InfoCard
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public uint UserId { get; set; }
        public virtual User User { get; set; }
        public DataType Created { get; set; }
        public ICollection<User> AssignedUsers { get; set; } = new List<User>();
    }
}
