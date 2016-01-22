namespace CV.WebAPI.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Certificate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImageLocation { get; set; }

        [Required]
        public string URL { get; set; }
    }
}