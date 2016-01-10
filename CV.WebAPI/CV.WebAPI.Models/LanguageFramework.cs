namespace CV.WebAPI.Models
{
    using System.ComponentModel.DataAnnotations;

    public class LanguageFramework
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ProgrammingLanguageId { get; set; }

        public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }

        [Required]
        [Range(0, 10)]
        public int TutorialsWatchedScore { get; set; }

        [Required]
        [Range(0, 10)]
        public int ProblemsSolvedScore { get; set; }

        [Required]
        [Range(0, 10)]
        public int WorkOnBiggerProjectsScore { get; set; }
    }
}