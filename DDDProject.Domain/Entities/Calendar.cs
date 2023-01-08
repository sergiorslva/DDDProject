namespace DDDProject.Domain.Entities
{
    public class Calendar : BaseEntity
    {        
        public string Description { get; set; } = string.Empty;
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Location { get; set; }

    }
}
