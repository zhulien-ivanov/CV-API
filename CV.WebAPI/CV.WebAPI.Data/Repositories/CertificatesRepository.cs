namespace CV.WebAPI.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using CV.Common.ViewModels.Certificate;

    using CV.WebAPI.Data.Contracts.Repositories;

    using CV.WebAPI.Models;

    public class CertificatesRepository : ICertificatesRepository
    {
        private readonly CVSystemDbContext dbContext;

        public CertificatesRepository(CVSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<CertificateViewModel> GetAll()
        {
            return this.dbContext.Certificates
                .Select(x => new CertificateViewModel()
                    {
                        Name = x.Name,
                        ImageLocation = x.ImageLocation,
                        URL = x.URL
                    })
                .ToList();
        }
    }
}