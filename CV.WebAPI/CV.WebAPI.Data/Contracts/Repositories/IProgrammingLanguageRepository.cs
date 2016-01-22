namespace CV.WebAPI.Data.Contracts.Repositories
{
    using System.Collections.Generic;

    using CV.Common.ViewModels.ProgrammingLanguage;

    using CV.WebAPI.Models;

    public interface IProgrammingLanguageRepository
    {
        IEnumerable<ProgrammingLanguageDetailedViewModel> GetAll();

        IEnumerable<ProgrammingLanguageIconViewModel> GetAllByPartialViewModel();
        
        ProgrammingLanguageDetailedViewModel GetById(int id);
    }
}