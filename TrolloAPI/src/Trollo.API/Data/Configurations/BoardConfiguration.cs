using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrolloAPI.Data.Entities;

namespace TrolloAPI.Data.Configurations
{
    public class BoardConfiguration: IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(b => b.Status)
                .IsRequired()
                .HasMaxLength(16);
            
            builder.Property(b => b.Scope)
                .IsRequired()
                .HasMaxLength(16);
        }
    }
}