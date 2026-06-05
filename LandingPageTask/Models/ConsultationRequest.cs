using LandingPageTask.Models.Enums;

namespace LandingPageTask.Models
{
    public class ConsultationRequest
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public BudgetRange Budget { get; set; }
        public InterestType InterestType { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
