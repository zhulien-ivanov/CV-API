namespace CV.WebAPI.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using CV.Common.ViewModels;

    using CV.WebAPI.Data.Contracts.Repositories;

    using CV.WebAPI.Models;

    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        private readonly CVSystemDbContext dbContext;

        public ProgrammingLanguageRepository(CVSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<ProgrammingLanguageIconViewModel> GetAll()
        {
            return this.dbContext.ProgrammingLanguages
                .Select(x => new ProgrammingLanguageIconViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageLocation = x.ImageLocation
                    })
                .ToList();
        }

        public ProgrammingLanguageDetailedViewModel GetById(int id)
        {
            var item = this.dbContext.ProgrammingLanguages.Find(id);

            return new ProgrammingLanguageDetailedViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                ImageLocation = item.ImageLocation,
                ProblemsSolvedScore = item.ProblemsSolvedScore,
                TutorialsWatchedScore = item.TutorialsWatchedScore,
                WorkOnBiggerProjectsScore = item.WorkOnBiggerProjectsScore
            };
        }
    }
}