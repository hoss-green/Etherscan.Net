namespace EthScanNet.Lib.Models.Interfaces
{
    public interface IPaginationResponse
    {
        public int? Page { get; set; }
        public int? Offset { get; set; }
    }
}