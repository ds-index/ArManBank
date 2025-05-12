//ArMan DS
namespace ArManBank.Domain
{
    public interface IUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public decimal? Balance { get; set; }
        public TypeOfBalance TypeOfBalance { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
