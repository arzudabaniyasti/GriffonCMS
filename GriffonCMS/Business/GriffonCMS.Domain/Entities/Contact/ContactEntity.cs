using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Contact;
public class ContactEntity:AuditableBaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public string ContactMail { get; set; }
    public string ContactName { get; set; }
    public string ContactMessage { get; set; }
}
