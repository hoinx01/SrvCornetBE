using System;
using System.Collections.Generic;
using System.Text;

namespace SrvCornet.Dal.Mssql
{
    public interface IConnectionFactory
    {
        string GetConnectionString<T>();
    }
}
