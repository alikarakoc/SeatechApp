using Microsoft.EntityFrameworkCore;
using Dapper;
using Seatech.Domain.Entities;

namespace Seatech.Infrastructure.Persistence
{
    public class SeatechDbContext : DbContext
    {
        public SeatechDbContext(DbContextOptions<SeatechDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public int Execute(string query, object parameters)
        {
            return Database.GetDbConnection().Execute(query, parameters);
        }
        public List<T> SQLQuery<T>(string query, object parameters)
        {

            return Database.GetDbConnection().Query<T>(query, param: parameters).ToList();
        }
        public List<T> SQLQuery<T>(string query)
        {
            return Database.GetDbConnection().Query<T>(query).ToList();
        }

        public virtual DbSet<Category> Category { get; set; }

    }
}
