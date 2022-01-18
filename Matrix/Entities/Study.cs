using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matrix.Entities
{
    public class Study
    {
        [Key]       
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public string Interval { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public Guid EmployeeId { get; set; }
    }
}
