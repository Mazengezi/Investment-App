using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Investment.UI.Models
{
    public class Client
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User Index")]
        public int userId { get; set; }
        [Required]
        [Display(Name = "First name")]
        [RegularExpression(pattern: @"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed.")]
        [StringLength(maximumLength: 35, ErrorMessage = "Fist Name must be atleast 3 characters long", MinimumLength = 3)]
        public string fName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(pattern: @"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Numbers and special characters are not allowed.")]
        [StringLength(maximumLength: 35, ErrorMessage = "Fist Name must be atleast 3 characters long", MinimumLength = 3)]
        public string lName { get; set; }
        [Required]
        [Display(Name = "Bank name")]
        public string bankName { get; set; }
        [Required]
        [Display(Name = "Account type")]
        public string actType { get; set; }
        [Required]
        [Display(Name = "Blocked")]
        public bool block = false;
        [Required]

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(pattern: @"^\(?([0]{1})\)?[-. ]?([1-9]{1})[-. ]?([0-9]{8})$", ErrorMessage = "Entered phone format is not valid.")]
        [StringLength(maximumLength: 10, ErrorMessage = "SA Contact Number must be exactly 10 digits long", MinimumLength = 10)]
        public string cell { get; set; }
        [Required]
        [Display(Name = "Account num")]
        public int actNum { get; set; }
        [Required]
        [Display(Name = "Branch code")]
        public int branchCode { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.DateTime)]
        public DateTime dateCreate = DateTime.Now;

        [Display(Name = "Registration Fee")]
        public bool regFee = false;

        [ForeignKey("Matches")]
        public int matchId { get; set; }

        public Match Matches { get; set; }

       // public List<PaymentMade> PaymentMades { get; set; }

        public List<PaymentReceived> PaymentReceived { get; set; }
    }
}