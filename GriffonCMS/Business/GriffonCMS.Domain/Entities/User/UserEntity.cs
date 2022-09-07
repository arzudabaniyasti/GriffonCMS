using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Domain.Entities.WorkExperience;

namespace GriffonCMS.Domain.Entities.User;
public class UserEntity:BaseEntity<Guid>
{
    public Guid AdminId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime Birthday { get; set; }
    public int Age { get; set; }
    public string CVLink { get; set; }
    public string Job { get; set; }
    public Guid ImageId { get; set; }
    public string Address { get; set; }
    public virtual ICollection<BlogEntity> Blogs { get; set; }
    public virtual ICollection<CategoryEntity> Categories  { get; set; }
    public virtual ICollection<ContactEntity> Contacts { get; set; }
    public virtual ICollection<InterestEntity> Interests { get; set; }
    public virtual ICollection<ProjectEntity> Projects { get; set; }
    public virtual ICollection<ReferenceEntity> References { get; set; }
    public virtual ICollection<SkillEntity> Skills { get; set; }
    public virtual ICollection<WorkExperienceEntity> WorkExperiences { get; set; }
}
