using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(new Employee
            {
                Id = new Guid("cd32897e-c50b-4779-81ef-65a485530254"),
                ProjectId = new Guid("d72f01d7-7e27-4ce9-bb19-6ce17b3ccee8"),
                FirstName = "Selçuk",
                LastName = "KARAAĞAÇ",
                Age = 37,
                Position = "Senior Developer"

            });

        }
    }
}
