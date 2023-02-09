using System.Collections.Generic;

namespace FiveStarRepos.Application.Queries.Base
{
    public class PagedResultResponse<TEntity> where TEntity : class
    {
        public int Page { get; }
        public int PageSize { get; }
        public int Total { get; }
        public IEnumerable<TEntity> Data { get; }

        public PagedResultResponse(int page, int pageSize, int total, IEnumerable<TEntity> data)
        {
            Page = page;
            PageSize = pageSize;
            Total = total;
            Data = data;
        }
    }
}
