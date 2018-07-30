using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Utils.Datas.EF
{
    public class EFDbContextBuilderFactory
    {
        public static IEFDbContextBuilder CreateBuilder(EFDataOptions eFDataOptions)
        {
            switch (eFDataOptions.DbType)
            {
                case DatabaseType.Sqlite:
                    return new SqliteDbContextBuilder();
                case DatabaseType.MsSql:
                    return new MsSqlDbContextBuilder();
                default:
                    throw new ArgumentOutOfRangeException("don't support db type!");
            }
        }
    }
}
