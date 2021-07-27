using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Investment.UI.Models
{
    public class PaymentMade
    {

        [Key]
        [Display(Name = "Ref Index")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int payMadeId { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Date created")]
        [DataType(DataType.Date)]
        public DateTime dateCreate { get; set; }
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime dueDate { get; set; }
        [Required]
        [Display(Name = "pH Amount")]
        public double amtPaid { get; set; }
        [Required]
        [Display(Name = "userName")]
        public string userName { get; set; }
        [Required]
        //[ForeignKey("Phone number")]
        public double cell;
        [Required]
        //[ForeignKey("Email")]
        [DataType(DataType.EmailAddress)]
        public string email;
        [Required]
       // [ForeignKey("Registration Fee")]
        public bool regFee;
        [Required]
       // [ForeignKey("Bank name")]
        public string bankName;
        [Required]
       // [ForeignKey("Account Type")]
        public string actType;
        [Required]
       // [ForeignKey("Account num")]
        public int actNum;
        [Required]
        //[ForeignKey("Branch Code")]
        public int branchCode;

        //[ForeignKey("clients")]
        //public int userid { get; set; }
        //public Client clients { get; set; }


        public List<PaymentReceived> PaymentReceived { get; set; }
    }
}