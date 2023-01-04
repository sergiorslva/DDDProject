namespace DDDProject.Application.DTO
{
    public class CalendarDTO : BaseDTO
    {
        public string Description { get; set; } = string.Empty;
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}
