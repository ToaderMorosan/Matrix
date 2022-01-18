namespace Matrix.Models
{
    public class StudyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Interval { get; set; }

        public Guid EmployeeId { get; set; }
    }
}
