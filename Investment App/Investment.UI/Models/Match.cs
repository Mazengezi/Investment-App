using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Investment.UI.Models
{
    public class Match
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Match Index")]
        public int matchId { get; set; }

        [Required]
        //[ForeignKey("userId")]
        [Display(Name = "User Index")]
        public int userId;
        [Required]
       // [ForeignKey("Username")]
        [Display(Name = "Username")]
        public string userName;

        public List<Client> AmClients { get; set; }

    }
}