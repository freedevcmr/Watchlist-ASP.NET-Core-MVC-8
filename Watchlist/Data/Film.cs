using Microsoft.EntityFrameworkCore;

namespace Watchlist.Data
{
    public class Film
    {
        public int Id { get; set; } 
        
        public string Titre { get; set; }
        public int Annee { get; set; }

     //  public DbSet<Film> Films { get; set; }
        
    }
}
