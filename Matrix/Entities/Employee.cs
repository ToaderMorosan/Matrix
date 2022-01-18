using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Matrix.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Ocupation { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }

        public string address { get; set; }

        public string email { get; set; }
        public string github { get; set; }
        public string instagram { get; set; }


        public ICollection<Study> Studies { get; set; }
            = new List<Study>();
    }
}
