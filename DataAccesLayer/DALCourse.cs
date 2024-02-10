using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EntityLayer;
using EntityLayer.Concrete;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DataAccesLayer
{
    public static class DALCourse
    {
        public static List<EntityCourse> CourseList()
        {
            List<EntityCourse> studentValues = new List<EntityCourse>();
            SqlCommand cmd2 = new SqlCommand("Select * From TBLCOURSES", Connection.connector);
            if (cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                EntityCourse course = new EntityCourse();
                course.Id = Convert.ToInt32(dr["COURSEID"].ToString());
                course.CourseName = dr["COURSENAME"].ToString();
                course.Max =int.Parse( dr["COURSEMINCAPACITY"].ToString());
                course.Min = int.Parse(dr["COURSEMAXCAPACITY"].ToString());
            
                studentValues.Add(course);
            }
            dr.Close();
            return studentValues;
        }
        public static int AddRequest(EntityApplicationForm entityApplicationForm)
        {
            SqlCommand cmd = new SqlCommand("insert into TBLAPPLICATIONFORM (STDID,COURSEID) values (@P1,@P2)",Connection.connector);
            cmd.Parameters.AddWithValue("@P1",entityApplicationForm.Id);
            cmd.Parameters.AddWithValue("@P2", entityApplicationForm.ApplicationStudentId);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
