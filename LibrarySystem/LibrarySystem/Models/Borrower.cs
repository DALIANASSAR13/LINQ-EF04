
namespace LibrarySystem.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
