using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.Contacts;
public class ContactMap : Profile
{
    public ContactMap()
    {
        CreateMap<ContactEntity, CreateContactCommand>().ReverseMap();
    }
}
