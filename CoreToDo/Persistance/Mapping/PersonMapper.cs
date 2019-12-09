using CoreToDo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreToDo.Persistance.Mapping
{
    public class PersonMapper : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person")
                .Property(x => x.Email).IsRequired();

            builder.HasMany(x => x.Items)
                .WithOne();
        }
    }
}
