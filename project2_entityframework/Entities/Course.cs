using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2_entityframework.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }

        // FK
        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<InstructorCourse> InstructorCourses { get; set; }
    }

}
