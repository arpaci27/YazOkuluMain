using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EntityApplicationForm
    {
        private int id;
        private int applicationStudentId;
        private int ApplicationCourseID;

        public int Id { get => id; set => id = value; }
        public int ApplicationStudentId { get => applicationStudentId; set => applicationStudentId = value; }
        public int ApplicationCourseID1 { get => ApplicationCourseID; set => ApplicationCourseID = value; }
    }
}
