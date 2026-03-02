using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_entityframework.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        // FK
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }

}
