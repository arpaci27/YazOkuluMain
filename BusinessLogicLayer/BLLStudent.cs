using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer.Concrete;

namespace BusinessLogicLayer
{
    public class BLLStudent
    {
        public static int AddStudentBLL(EntityStudent student)
        {
            if(student.Name!= null && student.SurName!= null
                && student.Number != null && student.Password != null && student.Image !=null) {
                return DALStudent.AddStudent(student);
            }
            return -1;
        }
        public static List<EntityStudent> BllList()
        {
            return DALStudent.StudentList();
        }
        public static bool RemoveStudent(int p)
        {
            if(p>=0)
            {
                return DALStudent.RemoveStudent(p);
            }
            return false;
        }
        public static List<EntityStudent> BllDetail(int p)
        {
            return DALStudent.StudentDetails(p);
        }

        public static bool UpdateStudentBLL(EntityStudent student)
        {

            if (student.Name != null && student.SurName != null
               && student.Number != null && student.Password != null && student.Image != null && student.Id > 0)
            {
                return DALStudent.StudentUpdate(student);
            }return false;
        }
    }
}
