using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonCMS.Application.Interfaces;
public interface IGenericRepositoryAsync<T> where T : class
{
    void AddAsync(T entity);
    void UpdateAsync(T entity);
 
}
