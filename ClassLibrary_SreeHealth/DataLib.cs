using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_SreeHealth
{
    class DataLib
    {
        string Connection = "Server=tcp:ittalenthub.database.windows.net,1433;Initial Catalog=ittalenthub;Persist Security Info=False;User ID=ittalenthub;Password=London12$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DataTable LoadData(string sp)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }

        public void Insert_T01(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Department", plib.Department);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Insert_T02(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DepartmentID", plib.DepartmentID);
                    cmd.Parameters.AddWithValue("@Doctor", plib.Doctor);
                    cmd.Parameters.AddWithValue("@Qualification", plib.Qualification);
                    cmd.Parameters.AddWithValue("@Note", plib.Note);
                    cmd.Parameters.AddWithValue("@Mail", plib.Mail);
                    cmd.Parameters.AddWithValue("@Contact", plib.Contact);
                    cmd.Parameters.AddWithValue("@Address", plib.Address);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }

            }
        }
        public void Insert_T03(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Patient", plib.Patient);
                    cmd.Parameters.AddWithValue("@Age", plib.Age);
                    cmd.Parameters.AddWithValue("@Gender", plib.Gender);
                    cmd.Parameters.AddWithValue("@Mail", plib.Mail);
                    cmd.Parameters.AddWithValue("@Contact", plib.Contact);
                    cmd.Parameters.AddWithValue("@Address", plib.Address);
                    cmd.Parameters.AddWithValue("@Note", plib.Note);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Insert_T04(string sp, PropertyLib plib)
        {
            using (SqlConnection con = new SqlConnection(Connection))
            {
                using (SqlCommand cmd = new SqlCommand(sp, con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@DepartmentID", plib.DepartmentID);
                    cmd.Parameters.AddWithValue("@DoctorID", plib.DoctorID);
                    cmd.Parameters.AddWithValue("@PatientID", plib.PatientID);
                    cmd.Parameters.AddWithValue("@Date", plib.Date);
                    cmd.Parameters.AddWithValue("@Note", plib.Note);
                    cmd.Parameters.AddWithValue("@Status", plib.Status);
                    cmd.Parameters.AddWithValue("@UserID", plib.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
