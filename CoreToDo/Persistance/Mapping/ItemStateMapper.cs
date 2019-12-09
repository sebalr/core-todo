using CoreToDo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreToDo.Persistance.Mapping
{
    public class ItemStateMapper : IEntityTypeConfiguration<ItemState>
    {
        public void Configure(EntityTypeBuilder<ItemState> builder)
        {
            builder.ToTable("ItemState")
                .Property(x => x.Changed).IsRequired();
        }
    }
}
