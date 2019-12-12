////Authors: Corbin King, Jake Saylor, Mikey Jenkins, Peter Madsen

using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlowOut.DAL
{
    public class InstrumentContext :DbContext
    {
        //Create Context class to configure with DB
        public InstrumentContext() : base("InstrumentContext")
        {

        }

        public DbSet<Clients> Clients { get; set; }
        public DbSet <Instruments> Instruments { get; set; }
    }
}