﻿namespace CV.WebAPI.Data.Contracts.Repositories
{
    using System.Collections.Generic;

    using CV.Common.ViewModels;

    using CV.WebAPI.Models;

    public interface ILanguageFrameworkRepository
    {
        IEnumerable<LanguageFrameworkIconViewModel> GetAll();

        LanguageFrameworkDetailedViewModel GetById(int id);

        IEnumerable<LanguageFrameworkDetailedViewModel> GetByLanguage(int id);
    }
}