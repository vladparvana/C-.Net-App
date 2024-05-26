using System.Data.Entity;

namespace DatabaseAccess.Database
{
    /// <summary>
    /// Clasa care reprezintă un inițializator pentru baza de date.
    /// </summary>
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        /// <summary>
        /// Metoda care este apelată pentru a adăuga date de inițializare în baza de date.
        /// </summary>
        /// <param name="context">Contextul bazei de date căreia i se adaugă date de inițializare.</param>
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}
