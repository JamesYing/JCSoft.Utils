using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace JCSoft.Utils.Commons
{
    public class PagedResponse<TEntity>
    {
        public PagedResponse(int total, IReadOnlyCollection<TEntity> items)
        {
            Total = total;
            Items = items;
        }

        public PagedResponse(int total, IList<TEntity> items)
        {
            Total = total;
            Items = new ReadOnlyCollection<TEntity>(items);
        }



        public int Total { get; set; }

        public IReadOnlyCollection<TEntity> Items { get; set; }
    }
}