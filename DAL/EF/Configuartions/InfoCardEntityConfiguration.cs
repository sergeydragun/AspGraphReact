using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Configuartions
{
    public class InfoCardEntityConfiguration : IEntityTypeConfiguration<InfoCard>
    {
        public void Configure(EntityTypeBuilder<InfoCard> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Cards)
                .HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.AssignedUsers)
                .WithMany(x => x.AssignedCards);
                
        }
    }
}
