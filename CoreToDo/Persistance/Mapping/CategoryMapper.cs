using CoreToDo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreToDo.Persistance.Mapping
{
    public class CategoryMapper : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category")
                .Property(x => x.Name).IsRequired();
        }
    }
}
