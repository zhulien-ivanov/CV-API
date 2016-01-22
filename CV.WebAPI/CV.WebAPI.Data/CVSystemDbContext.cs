namespace CV.WebAPI.Data
{
    using System.Data.Entity;

    using CV.WebAPI.Data.Migrations;
    using CV.WebAPI.Models;

    public class CVSystemDbContext : DbContext
    {
        public CVSystemDbContext() : base("CVSystemDb")
        {
            Database.SetInitializer<CVSystemDbContext>(new MigrateDatabaseToLatestVersion<CVSystemDbContext, Configuration>());
        }

        public IDbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public IDbSet<LanguageFramework> LanguageFrameworks { get; set; }

        public IDbSet<Certificate> Certificates { get; set; }
    }
}