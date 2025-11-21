namespace FutureWorkAPI.Models
{
    public class Career
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int SkillLevel { get; set; }
        public required string Category { get; set; }
    }
}
