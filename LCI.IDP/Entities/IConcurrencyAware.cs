namespace LCI.IDP.Entities
{
    public interface IConcurrencyAware
    {
        string ConcurrencyStamp { get; set; }

    }
}
