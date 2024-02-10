using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EntityTeacher
    {
        private string teacherName;
        private int id;
        private string teacherBranch;

        public string TeacherName { get => teacherName; set => teacherName = value; }
        public int Id { get => id; set => id = value; }
        public string TeacherBranch { get => teacherBranch; set => teacherBranch = value; }
    }
}
