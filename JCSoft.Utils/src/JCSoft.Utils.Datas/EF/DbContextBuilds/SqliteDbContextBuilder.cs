using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace JCSoft.Utils.Datas.EF
{
    public class SqliteDbContextBuilder : IEFDbContextBuilder
    {
        public void Build(DbContextOptionsBuilder contextOptionsBuilder, EFDataOptions eFDataOptions)
        {
            contextOptionsBuilder.UseSqlite(eFDataOptions.Connection);
        }
    }
}
