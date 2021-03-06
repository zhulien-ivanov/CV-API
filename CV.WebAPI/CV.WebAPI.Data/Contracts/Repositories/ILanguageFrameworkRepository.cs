﻿namespace CV.WebAPI.Data.Contracts.Repositories
{
    using System.Collections.Generic;

    using CV.Common.ViewModels.LanguageFramework;

    using CV.WebAPI.Models;

    public interface ILanguageFrameworkRepository
    {
        IEnumerable<LanguageFrameworkDetailedViewModel> GetAll();

        IEnumerable<LanguageFrameworkIconViewModel> GetAllByPartialViewModel();

        LanguageFrameworkDetailedViewModel GetById(int id);

        IEnumerable<LanguageFrameworkDetailedViewModel> GetByLanguage(int id);

        IEnumerable<LanguageFrameworkIconViewModel> GetByLanguagePartialViewModel(int id);
    }
}