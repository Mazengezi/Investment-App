using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Investment.UI.Models
{
    public class PaymentReceived
    {
        [Key]
        [Display(Name = "Ref Index")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int payReceivedId { get; set; }
        [Display(Name = "Status")]
        public string status { get; set; }
        [Display(Name = "Date created")]
        [DataType(DataType.Date)]
        public DateTime dateCreate = DateTime.Now;

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime dueDate { get; set; }
        [Required]
        [Display(Name = "Amount")]
        public double amtRec { get; set; }
        [Required]
        //[ForeignKey("Username")]

        public string userName;
        [Required]
        // [ForeignKey("payMade")]

        public double amtPaid;
        [Required]
        //[ForeignKey("users")]

        public double cell;
        [Required]
       // [ForeignKey("users")]

        [DataType(DataType.EmailAddress)]
        public string email;

        [ForeignKey("clients")]
        public int userid { get; set; }
        [ForeignKey("PaymentsMade")]
        public int payMadeId { get; set; }

        public Client clients { get; set; }
        public virtual PaymentMade PaymentsMade { get; set; }

    }
}