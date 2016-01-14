namespace CV.WebAPI.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using CV.Common.ViewModels;

    using CV.WebAPI.Data.Contracts.Repositories;

    using CV.WebAPI.Models;

    public class LanguageFrameworkRepository : ILanguageFrameworkRepository
    {
        private readonly CVSystemDbContext dbContext;

        public LanguageFrameworkRepository(CVSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<LanguageFrameworkDetailedViewModel> GetAll()
        {
            return this.dbContext.LanguageFrameworks
                .Select(x => new LanguageFrameworkDetailedViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ProblemsSolvedScore = x.ProblemsSolvedScore,
                        TutorialsWatchedScore = x.TutorialsWatchedScore,
                        WorkOnBiggerProjectsScore = x.WorkOnBiggerProjectsScore
                    })
                .ToList();
        }

        public IEnumerable<LanguageFrameworkIconViewModel> GetAllByPartialViewModel()
        {
            return this.dbContext.LanguageFrameworks
                    .Select(x => new LanguageFrameworkIconViewModel()
                        {
                            Id = x.Id,
                            Name = x.Name
                        })
                    .ToList();
        }

        public LanguageFrameworkDetailedViewModel GetById(int id)
        {
            var item = this.dbContext.LanguageFrameworks.Find(id);

            return new LanguageFrameworkDetailedViewModel()
            {
                Id = item.Id,
                Name = item.Name,
                ProblemsSolvedScore = item.ProblemsSolvedScore,
                TutorialsWatchedScore = item.TutorialsWatchedScore,
                WorkOnBiggerProjectsScore = item.WorkOnBiggerProjectsScore
            };
        }

        public IEnumerable<LanguageFrameworkDetailedViewModel> GetByLanguage(int id)
        {
            return this.dbContext.ProgrammingLanguages.Find(id).Frameworks
                .Select(x => new LanguageFrameworkDetailedViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ProblemsSolvedScore = x.ProblemsSolvedScore,
                        TutorialsWatchedScore = x.TutorialsWatchedScore,
                        WorkOnBiggerProjectsScore = x.WorkOnBiggerProjectsScore
                    })
                .ToList();
        }


        public IEnumerable<LanguageFrameworkIconViewModel> GetByLanguagePartialViewModel(int id)
        {
            return this.dbContext.ProgrammingLanguages.Find(id).Frameworks
                .Select(x => new LanguageFrameworkIconViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name
                    })
                .ToList();
        }
    }
}