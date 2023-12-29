using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Watchlist.Data
{
    public class FilmUtilisateur
    {
        
        public string IdUtilisateur {  get; set; }
        public int IdFilm { get; set; }
        public bool Vu {  get; set; }
        public int Note {  get; set; }

       
        public virtual Utilisateur User { get; set; }
        public virtual Film Film { get; set; }

        public DbSet<FilmUtilisateur> FilmsUtilisateur { get; set; }

    }
}
