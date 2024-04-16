using Microsoft.EntityFrameworkCore;
using vet_manager.Core;
using vet_manager.Core.Entities.Clients;
using vet_manager.Core.Entities.Consultations;
using vet_manager.Core.Entities.Money;

namespace vet_manager.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Consultation>()
            .HasKey(e => e.Id);
        modelBuilder.Entity<Consultation>()
            .HasOne(e => e.ParentConsultation)
            .WithMany(e => e.RelatedConsultations)
            .HasForeignKey(e => e.ParentConsultationId)
            .OnDelete(DeleteBehavior.Restrict);
        
        modelBuilder.Entity<Operation>()
            .HasKey(e => e.Id);
        modelBuilder.Entity<OperationAdditional>()
            .HasKey(e => e.Id);
    }

    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<ConsultationCategory> ConsultationCategories { get; set; }
    public DbSet<ConsultationType> ConsultationTypes { get; set; }
    
    public DbSet<Operation> Operations { get; set; }
    public DbSet<OperationAdditional> OperationAdditionals { get; set; }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<Animal> Animals { get; set; }
}
