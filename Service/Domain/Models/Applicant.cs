using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    [Table("applicant")]
    public class Applicant
    {
        public Guid ApplicantId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name should be in between 5-60 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Family Name is required")]
        [StringLength(60, ErrorMessage = "Family Name should be in between 5-60 characters")]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(100, ErrorMessage = "Address should be in between 5-100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Country Of Origin is required")]
        [StringLength(100, ErrorMessage = "Should be a valid country")]
        public string CountryOfOrigin { get; set; }

        [Required(ErrorMessage = "EMail Address is required")]
        [StringLength(100, ErrorMessage = "Should be a valid EMailAddress")]
        public string EMailAddress { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        public bool Hired { get; set; }
    }
}
