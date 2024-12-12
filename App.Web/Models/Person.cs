namespace App.Web.Models
{
    public class Person : BaseModel
    {
        public Person()
        {
            Id = Guid.Empty.ToString();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "{0} is required")]
        public string Id { get; set; }

        [Display(Name = "Person Name")]
        [StringLength(maximumLength: 20, ErrorMessage = "{0} length between {2} and {1}", MinimumLength = 3)]
        [Required(ErrorMessage = "{0} is required")]
        public string? Name { get; set; }


        [Display(Name = "Gender")]
        [StringLength(maximumLength: 20, ErrorMessage = "{0} length between {2} and {1}", MinimumLength = 3)]
        [Required(ErrorMessage = "{0} is required")]
        public string? Gender { get; set; }


        [Display(Name = "Height")]
        [StringLength(maximumLength: 20, ErrorMessage = "{0} length between {2} and {1}", MinimumLength = 3)]
        [Required(ErrorMessage = "{0} is required")]
        public string? Height { get; set; }

        public string? Weight { get; set; }
        public DateTime DOB { get; set; }
        public string? HairColor { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermanentAddress { get; set; }

        [NotMapped]

        public string? FullAddress { get; set; }
        //public byte[] timestamp { get; set; }
    }
}
