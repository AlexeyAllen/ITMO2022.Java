using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using static ITMO2022.ASP.Net.Lab03.Ex01to02.RSVP.GuestResponse;

namespace ITMO2022.ASP.Net.Lab03.Ex01to02.RSVP
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("SeminarBD") { }
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}