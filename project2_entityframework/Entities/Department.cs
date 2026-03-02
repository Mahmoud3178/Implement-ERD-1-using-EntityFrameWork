using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_entityframework.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

        // Manager (1:1)
        public int? ManagerId { get; set; }
        public Instructor Manager { get; set; }

        public DateTime? HiringDate { get; set; }
    }

}
