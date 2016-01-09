namespace CV.WebAPI.API.Controllers
{
    using System.Web.Http;

    using CV.WebAPI.Data;
    using CV.WebAPI.Data.Contracts.Repositories;
    using CV.WebAPI.Data.Repositories;

    public class LanguagesController : ApiController
    {
        private readonly IProgrammingLanguageRepository languages;

        public LanguagesController()
            : this(new ProgrammingLanguageRepository(new CVSystemDbContext()))
        {
        }

        public LanguagesController(ProgrammingLanguageRepository languagesRepository)
        {
            this.languages = languagesRepository;
        }

        [HttpGet]
        [Route("api/languages")]
        public IHttpActionResult GetAll()
        {
            return this.Ok(this.languages.GetAll());
        }

        [HttpGet]
        [Route("api/languages/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return this.Ok(this.languages.GetById(id));
        }
    }
}