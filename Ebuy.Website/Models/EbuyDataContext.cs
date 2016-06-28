using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ebuy.Website.Models
{
    public class EbuyDataContext : DbContext
    {
        public EbuyDataContext()
            : base("name=EbuyDataContext")
        {

        }
        public DbSet<Auction> Auctions { get; set; }
    }
}