using Microsoft.EntityFrameworkCore;
using System;

namespace AplicacaoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString:@"Server=(local)\SQLEXPRESS;Database=AplicacaoMVC;Integrated Security = True;MultipleActiveResultSets=true");
        }

        //public void SetModified(object entity)
        //{
        //    Entry(entity).State = EntityState.Modified;
        //}
    }
}
