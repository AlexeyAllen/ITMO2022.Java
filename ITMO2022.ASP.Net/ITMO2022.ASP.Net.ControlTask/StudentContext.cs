using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO2022.ASP.Net.ControlTask
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentScoreDB") { }

        public DbSet<StudentInfo> StudentInfos { get; set; }
        //public DbSet<Report> Reports { get; set; }
    }
}