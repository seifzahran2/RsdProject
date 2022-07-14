using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsdProject.Models
{
    public class RsdDbContext : DbContext
    {


        public RsdDbContext(DbContextOptions<RsdDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<medicineSall> medicineSall { get; set; }
        public virtual DbSet<medicineReSall> medicineReSall { get; set; }
        public virtual DbSet<Accept> Acceptance { get; set; }
        public virtual DbSet<El_Return> El_Return { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<DeTransport> DeTransport { get; set; }
        public virtual DbSet<DisableUnit> DisableUnit { get; set; }
        public virtual DbSet<DeDisableUnit> DeDisableUnit { get; set; }

    }
}
