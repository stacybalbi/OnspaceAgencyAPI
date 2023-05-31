using Microsoft.EntityFrameworkCore;
using OnspaceAgency.Domain.Entities;
using OnspaceAgency.Infrastructure.Context.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Infrastructure.Context
{
    public interface IOnspaceAgencyDbContext : IDisposable
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
    public class OnspaceAgencyDbContext : DbContext, IOnspaceAgencyDbContext
    {
        public DbSet<T> GetDbSet<T>() where T : BaseEntity => Set<T>();

        public DbSet<Company> Company { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }







        public OnspaceAgencyDbContext(DbContextOptions<OnspaceAgencyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(type.ClrType))
                {
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
                }
            }
        }

        public void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.State != EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.Deleted = true;
                }
            }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
