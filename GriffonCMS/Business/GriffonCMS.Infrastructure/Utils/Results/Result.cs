using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonCMS.Infrastructure.Utils.Results;
public class Result : IResult
{
    public Result(bool success, string message) : this(success)
    {
        Message = message;
    }
    public Result(bool success)
    {
        Success = success;
    }
    public bool Success { get; }
    public string Message { get; }

  //  bool IResult.Success => throw new NotImplementedException();

   // string IResult.Message => throw new NotImplementedException();
}
