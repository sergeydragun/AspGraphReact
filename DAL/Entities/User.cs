using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : IdentityUser<int>
    {
        public ICollection<InfoCard> Cards { get; set; } = new List<InfoCard>();
        
        public ICollection<InfoCard> AssignedCards { get; set; } = new HashSet<InfoCard>();
    }
}
