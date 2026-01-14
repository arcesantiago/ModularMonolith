namespace Examples.Core.Models
{
    public class PagedResult<T>(IEnumerable<T> results, int rowsCount, int currentPage, int pageSize) where T : class
    {
        public IEnumerable<T> Results { get; set; } = results;
        public int RowsCount { get; set; } = rowsCount;
        public int PageCount { get; set; } = (int)Math.Ceiling(rowsCount / (double)pageSize);
        public int PageSize { get; set; } = pageSize;
        public int CurrentPage { get; set; } = currentPage;
    }

}
