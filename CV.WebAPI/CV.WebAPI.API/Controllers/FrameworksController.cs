namespace CV.WebAPI.API.Controllers
{
    using System.Web.Http;

    using CV.WebAPI.Data;
    using CV.WebAPI.Data.Contracts.Repositories;
    using CV.WebAPI.Data.Repositories;

    public class FrameworksController : ApiController
    {
        private readonly ILanguageFrameworkRepository frameworks;

        public FrameworksController()
            : this(new LanguageFrameworkRepository(new CVSystemDbContext()))
        {
        }

        public FrameworksController(LanguageFrameworkRepository frameworksRepository)
        {
            this.frameworks = frameworksRepository;
        }

        [HttpGet]
        [Route("api/frameworks")]
        public IHttpActionResult GetAll()
        {
            return this.Ok(this.frameworks.GetAll());
        }

        [HttpGet]
        [Route("api/frameworks/partial")]
        public IHttpActionResult GetAllByPartialViewModel()
        {
            return this.Ok(this.frameworks.GetAllByPartialViewModel());
        }

        [HttpGet]
        [Route("api/frameworks/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return this.Ok(this.frameworks.GetById(id));
        }

        [HttpGet]
        [Route("api/frameworks/bylang/{id:int}")]
        public IHttpActionResult GetByLanguage(int id)
        {
            return this.Ok(this.frameworks.GetByLanguage(id));
        }

        [HttpGet]
        [Route("api/frameworks/bylang/{id:int}/partial")]
        public IHttpActionResult GetByLanguageByPartialViewModel(int id)
        {
            return this.Ok(this.frameworks.GetByLanguagePartialViewModel(id));
        }
    }
}