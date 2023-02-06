using Juan_Felipe_Balanta_Renteria.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Juan_Felipe_Balanta_Renteria.DataContext
{
    public class TableroContext : DbContext
    {
        public TableroContext(DbContextOptions<TableroContext> options) : base(options){}


        public DbSet<TableroEntity> Tableros { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<TableroEntity>().HasData(
                new TableroEntity 
                {
                    Id=1,
                    Pais = "AUS",
                    Nombre = " Carlos Alvis",
                    Arranque = 134,
                    Envion = 177,
                    TotalPeso = 311
                }
                );

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetEntryAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }

}
