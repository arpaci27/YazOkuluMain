using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using EntityLayer.Concrete;

namespace BusinessLogicLayer
{
    public static class BLLCourse
    {
        public static List<EntityCourse> BLLCourseList()
        {
            return DALCourse.CourseList();
        }
        public static int AddRequestBLL(EntityApplicationForm form)
        {
            if(form.Id != null && form.ApplicationStudentId != null)
            {
                return DALCourse.AddRequest(form);
            }
            return -1;
        }
    }
}
