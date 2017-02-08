using SP.Metadata.CustomValidators;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SP.Metadata
{    
	public class ParticipantMetadata
    {
        [Phone]
        [StringLength(32)]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(256)]
        [DisplayName("Work Email")]
        public string Email { get; set; }
        [EmailAddress]
        [StringLength(256)]
        [DisplayName("Personal Email")]
        public string AlternateEmail { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }
        [Required]
        [StringLength(256)]
        [PersonFullName]
        public string FullName { get; set; }
        [StringLength(256)]
        public string DietNotes { get; set; }
    }
}
