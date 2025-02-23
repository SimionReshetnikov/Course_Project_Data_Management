using Microsoft.EntityFrameworkCore;


namespace CourseProject
{
    internal class MyDbContext : DbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<Attraction> Attraction { get; set; }
        public DbSet<PriceTicket> PriceTicket { get; set; }
        public DbSet<RouteContent> RouteContent { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<UserStatuses> UserStatuses { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<WorkingShedule> WorkingShedule { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;database=course_project;user=root;password=Grave1ot243!;",
                new MySqlServerVersion(new Version(9, 2, 0)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attraction>().HasOne(a => a.City)
                .WithMany(c => c.Attraction).HasForeignKey(a => a.CityId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PriceTicket>().HasOne(p => p.UserStatus)
                .WithMany(u => u.PriceTickets).HasForeignKey(p => p.UserStatusId);

            modelBuilder.Entity<PriceTicket>().HasOne(p => p.Attraction)
                .WithMany(u => u.PriceTickets).HasForeignKey(p => p.AttractionId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RouteContent>().HasOne(rc => rc.Route)
                .WithMany(r => r.RouteContents).HasForeignKey(r => r.RouteId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RouteContent>().HasOne(rc => rc.Attraction)
                .WithMany(r => r.RouteContents).HasForeignKey(r => r.AttractionId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Routes>().HasOne(r => r.User)
                .WithMany(a => a.Routes).HasForeignKey(r => r.UserId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Routes>().HasOne(r => r.City)
                .WithMany(a => a.Routes).HasForeignKey(r => r.CityId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Users>().HasOne(u => u.Status)
                .WithMany(a => a.User).HasForeignKey(u => u.StatusId);

            modelBuilder.Entity<WorkingShedule>().HasOne(ws => ws.Attraction)
                .WithMany(a => a.WorkingSchedules).HasForeignKey(ws => ws.AttractionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
