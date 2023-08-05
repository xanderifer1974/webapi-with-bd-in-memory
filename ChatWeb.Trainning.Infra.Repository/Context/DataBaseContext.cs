using ChatWeb.Trainning.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatWeb.Trainning.Infra.Repository.Context
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            
        }

        public DbSet<ClienteModel> Clientes { get; set; }
    }
}
