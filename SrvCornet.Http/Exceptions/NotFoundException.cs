using System;
using System.Collections.Generic;
using System.Text;

namespace Iken.Common.Http.Exceptions
{
    public class NotFoundException : BaseCustomException
    {
        public NotFoundException(string message) : base(new List<string>() { message}, System.Net.HttpStatusCode.NotFound)
        {

        }
    }
}
