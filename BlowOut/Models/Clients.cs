//Authors: Corbin King, Jake Saylor, Mikey Jenkins, Peter Madsen

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Clients")]
    public class Clients
    {
        //Attributes for clients matching the DB object
        [Key]
        public int clientID { get; set; }

        [Display(Name = "Client First Name")]
        [Required(ErrorMessage = "Client First Name is Required")]
        public string clientFirstName { get; set; }

        [Display(Name = "Client First Name")]
        [Required(ErrorMessage = "Client First Name is Required")]
        public string clientLastName { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Client Address is Required")]
        public string clientAddress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Client City is Required")]
        public string clientCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Client State is Required")]
        public string clientState { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Client Zip Code is Required")]
        [StringLength(5)]
        public string clientZip { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Client Email is Required")]
        [EmailAddress(ErrorMessage = "Must be a valid email format")]
        public string clientEmail { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Client Phone Number is Required")]
        [Phone(ErrorMessage = "Must be a phone number in the following format: (XXX) XXX-XXXX")]
        public string clientPhone { get; set; }
    }
}