using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Domain.Entities.User;
using GriffonCMS.Domain.Entities.WorkExperience;
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
    public DbSet<TagEntity> Tag { get; set; }
    public DbSet<CategoryEntity> Category { get; set; }
    public DbSet<AdminEntity> Admin { get; set; }
    public DbSet<AboutEntity> About { get; set; }
    public DbSet<BlogEntity> Blog { get; set; }
    public DbSet<CommentEntity> Comment { get; set; }
    public DbSet<ContactEntity> Contact { get; set; }
    public DbSet<InterestEntity> Interest { get; set; }
    public DbSet<ProjectEntity> Project { get; set; }
    public DbSet<ReferenceEntity> Reference { get; set; }
    public DbSet<SkillEntity> Skill { get; set; }
    public DbSet<UserEntity> User { get; set; }
    public DbSet<WorkExperienceEntity> WorkExperience { get; set; }

    #endregion
}
