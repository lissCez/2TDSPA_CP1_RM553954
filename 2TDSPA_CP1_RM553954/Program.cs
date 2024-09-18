using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using _2TDSPA_CP1_RM553954.Data;
using _2TDSPA_CP1_RM553954.Models;

class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var optionsBuilder = new DbContextOptionsBuilder<MeuDbContext>();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

        using (var context = new MeuDbContext(optionsBuilder.Options))
        {

            var categoria = new Categoria { NomeCat = "Eletrônicos" };
            context.Categorias.Add(categoria);
            context.SaveChanges();

            Console.WriteLine("Categoria criada com sucesso!");

            var produto = new Produto { NomeProd = "Monitor", PrecoProd = 1000.00m, CategoriaId = categoria.Id };
            context.Produtos.Add(produto);
            context.SaveChanges();

            Console.WriteLine("Produto adicionado com sucesso!");
        }
    }
}
