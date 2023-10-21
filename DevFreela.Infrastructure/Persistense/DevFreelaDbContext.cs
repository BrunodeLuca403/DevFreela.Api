using DevFreela.Core.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DevFreela.Infrastructure.Persistense
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
                
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UsersSkill { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Project>()
            //    .HasKey(p => p.Id);

            //modelBuilder.Entity<Project>()
            //    .HasOne(p => p.Freelancer)
            //    .WithMany(p => p.FreelancerProjects)
            //    .HasForeignKey(p => p.IdFreelancer)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Project>()
            //     .HasOne(p => p.Client)
            //     .WithMany(p => p.OwnedProjects)
            //     .HasForeignKey(p => p.IdCliente)
            //     .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ProjectComment>()
            //   .HasKey(p => p.Id);

            //modelBuilder.Entity<ProjectComment>()
            //    .HasOne(p => p.Project)
            //    .WithMany(p => p.Comments)
            //    .HasForeignKey(p => p.IdProject);

            //modelBuilder.Entity<ProjectComment>()
            //    .HasOne(p => p.User)
            //    .WithMany(p => p.Comments)
            //    .HasForeignKey(p => p.IdUser);

            //modelBuilder.Entity<UserSkill>()
            //  .HasKey(p => p.Id);

            //modelBuilder.Entity<Skill>()
            //   .HasKey(p => p.Id);

            //modelBuilder.Entity<User>()
            //  .HasKey(p => p.Id);

            //modelBuilder.Entity<User>()
            // .HasMany(u => u.Skills)
            // .WithOne()
            // .HasForeignKey(u => u.IdSkill)
            // .OnDelete(DeleteBehavior.Restrict);
        }

        //public DevFreelaDbContext()
        //{
        //    Projects = new List<Project>
        //    {
        //        new Project("Meu Projeto 1 ", "Minha Descricao 1", 1, 1, 10000),
        //        new Project("Meu Projeto 2", "Minha Descricao 2", 1, 1, 20000),
        //        new Project("Meu Projeto 3", "Minha Descricao 3", 1, 1, 20000)
        //    };

        //    Users = new List<User>
        //    {
        //        new User("Luis Felipe", "luis@gmail.com", new DateTime(2000, 1,1)),
        //        new User("Bruno", "Bruno@gmail.com", new DateTime(1995, 1,1)),
        //        new User("Jose", "jose@gmail.com", new DateTime(1992, 1,1)),
        //    };

        //    Skills = new List<Skill>
        //    {
        //        new Skill(".Net Core"),
        //        new Skill("Angular")

        //    };
        //}

        //public List<Project> Projects { get; set; }
        //public List<User> Users { get; set; }
        //public List<Skill> Skills { get; set; }
        //public List<ProjectComment> ProjectComments { get; set; }
    }
}
