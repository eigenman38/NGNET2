namespace NGNET2.DAO
{
    public class LogApiData
    {
        public string? ApiCall { get; set; }
        public int RecordsReturned { get; set; }
        public string? ServiceThatMadeCall { get; set; }
        public string? CallerDateTime { get; set; }
        public bool Success { get; set; }
    }
}
