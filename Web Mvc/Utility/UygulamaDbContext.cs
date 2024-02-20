using Microsoft.EntityFrameworkCore;
using WebUygulamaProje1.Models;

namespace WebUygulamaProje1.Utility
{
    public class UygulamaDbContext : DbContext
    {

        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options): base(options) { }

        public DbSet <YemekTuru> YemekTurleri { get; set; }

		public DbSet<Yemek> Yemekler {  get; set; }
	}
}
