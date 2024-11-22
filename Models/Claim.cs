namespace ClaimSystem.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerId { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string? FilePath { get; set; }
    }
}
