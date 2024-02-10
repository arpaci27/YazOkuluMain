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
    public class DALStudent
    {
        public static int AddStudent(EntityStudent student)
        {
            SqlCommand cmd1 = 
            new SqlCommand("INSERT INTO TBLSTUDENT (STDNAME,STDSURNAME,STDNUMBER,STDIMAGE,STDPASS) values (@p1,@p2,@p3,@p4,@p5)", Connection.connector);
            if(cmd1.Connection.State != ConnectionState.Open) {
            cmd1.Connection.Open();
            }

            cmd1.Parameters.AddWithValue("@p1", student.Name);
            cmd1.Parameters.AddWithValue("@p2", student.SurName);
            cmd1.Parameters.AddWithValue("@p3", student.Number);
            cmd1.Parameters.AddWithValue("@p4", student.Image);
            cmd1.Parameters.AddWithValue("@p5", student.Password);
            return cmd1.ExecuteNonQuery();


        }
        public static List<EntityStudent> StudentList()
        {
            List<EntityStudent> studentValues = new List<EntityStudent>();
            SqlCommand cmd2 = new SqlCommand("Select * From TBLSTUDENT", Connection.connector);
            if(cmd2.Connection.State != ConnectionState.Open)
            {
                cmd2.Connection.Open();
            }
            SqlDataReader dr = cmd2.ExecuteReader();
            while(dr.Read())
            {
                EntityStudent student = new EntityStudent();
                student.Id = Convert.ToInt32(dr["STDID"].ToString());
                student.Name = dr["STDNAME"].ToString();
                student.SurName = dr["STDSURNAME"].ToString();
                student.Number = dr["STDNUMBER"].ToString();
                student.Image = dr["STDIMAGE"].ToString();
                student.Password = dr["STDPASS"].ToString();
                student.Balance = Convert.ToDouble(dr["STDBALANCE"].ToString());
                studentValues.Add(student);
            }
            dr.Close();
            return studentValues;
        }
        public static bool RemoveStudent(int param)
        {
            SqlCommand cmd3 = new SqlCommand("Delete From TBLSTUDENT where STDID=@P1", Connection.connector);
            if (cmd3.Connection.State != ConnectionState.Open)
            {
                cmd3.Connection.Open();
            }
            cmd3.Parameters.AddWithValue("@P1", param);
            return cmd3.ExecuteNonQuery() > 0;
        }
        public static List<EntityStudent> StudentDetails(int id)
        {
            List<EntityStudent> studentValues = new List<EntityStudent>();
            SqlCommand cmd4 = new SqlCommand("Select * From TBLSTUDENT Where STDID=@P1", Connection.connector);
            cmd4.Parameters.AddWithValue("@P1", id);
            if (cmd4.Connection.State != ConnectionState.Open)
            {
                cmd4.Connection.Open();
            }
            SqlDataReader dr = cmd4.ExecuteReader();
            while (dr.Read())
            {
                EntityStudent student = new EntityStudent();
                student.Id = Convert.ToInt32(dr["STDID"].ToString());
                student.Name = dr["STDNAME"].ToString();
                student.SurName = dr["STDSURNAME"].ToString();
                student.Number = dr["STDNUMBER"].ToString();
                student.Image = dr["STDIMAGE"].ToString();
                student.Password = dr["STDPASS"].ToString();
                student.Balance = Convert.ToDouble(dr["STDBALANCE"].ToString());
                studentValues.Add(student);
            }
            dr.Close();
            return studentValues;
        }

        public static bool StudentUpdate(EntityStudent student)
        {
            SqlCommand cmd5 = new SqlCommand("Update TBLSTUDENT Set STDNAME=@P1, STDSURNAME=@P2, STDNUMBER=@P3, STDIMAGE=@P4,STDPASS=@P5 WHERE STDID=@P6", Connection.connector);
            if (cmd5.Connection.State != ConnectionState.Open)
            {
                cmd5.Connection.Open();
            }
            cmd5.Parameters.AddWithValue("@P1", student.Name);
            cmd5.Parameters.AddWithValue("@P2", student.SurName);
            cmd5.Parameters.AddWithValue("@P3", student.Number);
            cmd5.Parameters.AddWithValue("@P4", student.Image);
            cmd5.Parameters.AddWithValue("@P5", student.Password);
            cmd5.Parameters.AddWithValue("@P6", student.Id);
            return cmd5.ExecuteNonQuery() > 0;

        }
    }
}
