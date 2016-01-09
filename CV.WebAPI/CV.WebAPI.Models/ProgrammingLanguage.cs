namespace CV.WebAPI.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ProgrammingLanguage
    {
        private ICollection<LanguageFramework> frameworks;

        public ProgrammingLanguage()
        {
            this.Frameworks = new HashSet<LanguageFramework>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageLocation { get; set; }

        [Required]
        [Range(0, 10)]
        public int TutorialsWatchedScore { get; set; }

        [Required]
        [Range(0, 10)]
        public int ProblemsSolvedScore { get; set; }

        [Required]
        [Range(0, 10)]
        public int WorkOnBiggerProjectsScore { get; set; }

        public virtual ICollection<LanguageFramework> Frameworks
        {
            get { return this.frameworks; }
            set { this.frameworks = value; }
        }
    }
}