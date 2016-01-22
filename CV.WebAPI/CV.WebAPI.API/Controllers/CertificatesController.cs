namespace CV.WebAPI.API.Controllers
{
    using System.Web.Http;

    using CV.WebAPI.Data;
    using CV.WebAPI.Data.Contracts.Repositories;
    using CV.WebAPI.Data.Repositories;

    public class CertificatesController : ApiController
    {
        private readonly ICertificatesRepository certificates;

        public CertificatesController()
            : this(new CertificatesRepository(new CVSystemDbContext()))
        {
        }

        public CertificatesController(ICertificatesRepository certificatesRepository)
        {
            this.certificates = certificatesRepository;
        }

        [HttpGet]
        [Route("api/certificates")]
        public IHttpActionResult GetAll()
        {
            return this.Ok(this.certificates.GetAll());
        }
    }
}