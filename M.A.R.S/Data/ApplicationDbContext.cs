using System;
using System.Collections.Generic;
using System.Text;
using M.A.R.S.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace M.A.R.S.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Request> Requests { get; set; }

        public DbSet<UserKPIConfig> KPIConfigs { get; set; }

        public DbSet<Campaign> Campaigns { get; set; }
    }
}
