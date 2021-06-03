using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class CountryModel
    {
        [Required(ErrorMessage = "Please Select Country")]
        public string CountryCode { get; set; }
        public string Country { get; set; }
    }
}
