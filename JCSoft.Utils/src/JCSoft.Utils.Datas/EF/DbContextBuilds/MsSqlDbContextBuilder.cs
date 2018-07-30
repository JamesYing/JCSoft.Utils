using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Utils.Datas.EF
{
    public class MsSqlDbContextBuilder : IEFDbContextBuilder
    {
        public void Build(DbContextOptionsBuilder contextOptionsBuilder, EFDataOptions eFDataOptions)
        {
            contextOptionsBuilder.UseSqlServer(eFDataOptions.Connection);
        }
    }
}
