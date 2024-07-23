using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data;

public class AppDbContext : DbContext
{
    //demonstrando que a classe estudante será uma tabela
    public DbSet<Estudante> Estudantes { get; set; }
    
    //Configurando dbcontext para conectar no banco
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   
        //exemplo no sqlite
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
       
        base.OnConfiguring(optionsBuilder);
    }
}