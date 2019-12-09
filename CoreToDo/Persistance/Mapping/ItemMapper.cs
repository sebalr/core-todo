using CoreToDo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreToDo.Persistance.Mapping
{
    public class ItemMapper : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item")
                .Property(x => x.Body).IsRequired();

            builder.HasOne(x => x.ItemState)
                .WithMany();
        }
    }
}
