using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Utils.Datas.EF
{
    public interface IEFDbContextBuilder
    {
        void Build(DbContextOptionsBuilder contextOptionsBuilder, EFDataOptions eFDataOptions);
    }
}
