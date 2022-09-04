using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Tag;
using Microsoft.EntityFrameworkCore;

namespace GriffonCMS.Core.Context.EFContext;
public class GriffonEFContext : DbContext
{
    public GriffonEFContext(DbContextOptions<GriffonEFContext> options) : base(options)
    {

    }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    #region Validation

    #endregion

    #region DBSets
    public DbSet<Tag> Tag { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Admin> Admin { get; set; }
    #endregion
}
