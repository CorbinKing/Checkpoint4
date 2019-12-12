//Authors: Corbin King, Jake Saylor, Mikey Jenkins, Peter Madsen

using BlowOut.Models.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    //Attributes for instruments matching the DB object
    [Table("Instruments")]
    public class Instruments
    {
        [Key]
        public int instrumentID { get; set; }

        [Display(Name ="Instrument Description")]
        [Required(ErrorMessage = "Instrument Description is Required")]
        //Custom validation
        [StringRange]
        public string instrumentDesc { get; set; }

        [Display(Name = "Instrument Type")]
        [Required(ErrorMessage = "Instrument Type is Required")]
        public string instrumentType { get; set; }

        [Display(Name = "Instrument Price")]
        [Required(ErrorMessage = "Instrument Price is Required")]
        [PriceRange]
        public string instrumentPrice { get; set; }

        public int clientID { get; set; }
    }
}