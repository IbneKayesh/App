using System.ComponentModel.DataAnnotations;

namespace App.DMO.Setup
{
    public class BRAND
    {
        public BRAND()
        {
            ID = Guid.Empty.ToString();
        }
        [Key]
        public string ID { get; set; }

        [Display(Name ="Brand Name")]
        [Required (ErrorMessage ="{0} is required")]
        [StringLength(50, ErrorMessage ="{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? BRAND_NAME { get; set; }

        [Display(Name = "Origin")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 3)]
        public string? BRAND_ORIGIN { get; set; }
    }
}
