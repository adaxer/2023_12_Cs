namespace ApiService;

public class ResultPage<T>
{
    public int TotalCount { get; set; }
    public int PageNo { get; set; }
    public int PageSize { get; set; }

    public IEnumerable<T> Data { get; set; } = new List<T>();

    public ResultPage(int total, int no, int size, IEnumerable<T>? data=null)
    {
        TotalCount = total;
        PageNo = no;
        PageSize = size;
        Data = data ?? new List<T>();
    }
}
