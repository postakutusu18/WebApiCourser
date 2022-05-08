using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Config
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasData(new Project
            {
                Id = new Guid("d72f01d7-7e27-4ce9-bb19-6ce17b3ccee8"),
                Name = "ASP.NET Core Web APi Project",
                Description = "Web Applicaton Programming Interface",
                Field = "Computer Science"
            });
        }
    }
}
