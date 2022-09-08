using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.WorkExperiences;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.WorkExperiences;
public class GetWorkExperienceQuery : IRequest<List<GetWorkExperienceDto>>
{
}
