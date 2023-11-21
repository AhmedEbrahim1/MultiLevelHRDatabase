﻿using Microsoft.EntityFrameworkCore;

namespace MyHrSystemDemo.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) { }
        /*the properties refer to tables at database*/
        public virtual DbSet<Employee>Employees{ get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Branch>  Branches{ get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Level> Levels { get; set; }

    }
}
