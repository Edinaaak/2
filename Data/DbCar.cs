using Microsoft.EntityFrameworkCore;
using RentaCar.Models;

namespace RentaCar.Data
{
    public class DbCar :DbContext
    {
        public DbCar(DbContextOptions<DbCar> options) : base(options) {}
        public DbSet<Automobili> Automobili { get; set; }
        public DbSet<Register> Registar { get; set; }


    }
}
