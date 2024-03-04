using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LoginForm.Model;

namespace LoginForm.DAO
{
    public class DataAccessLayer
    {
        private string connectionString = "Data Source=SQLLISTENER;Initial Catalog=DIT-Training;Integrated Security=True";

        //public void SaveFormData(string name, string address, string gender, string state, string phone, decimal total, List<string> courses)
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand("Dit_proc_FormData", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@Name", name);
        //            command.Parameters.AddWithValue("@Address", address);
        //            command.Parameters.AddWithValue("@Gender", gender);
        //            command.Parameters.AddWithValue("@State", state);
        //            command.Parameters.AddWithValue("@Phone", phone);
        //            command.Parameters.AddWithValue("@Total", total);
        //            string coursesString = string.Join(",", courses);
        //            command.Parameters.AddWithValue("@Courses", coursesString);

        //            connection.Open();
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}

        public int SaveFormData(LoginData obj)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("Mak_Procc_InsertStudentInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", obj.Name);
                    command.Parameters.AddWithValue("@Address", obj.Address);
                    command.Parameters.AddWithValue("@Gender", obj.Gender);
                    command.Parameters.AddWithValue("@State", obj.State);
                    command.Parameters.AddWithValue("@Phone", obj.Phone);
                    command.Parameters.AddWithValue("@Total", obj.Total);
                    string coursesString = string.Join(",", obj.Courses);
                    command.Parameters.AddWithValue("@Courses", coursesString);
                    command.Parameters.AddWithValue("@Email", obj.Email);
                    command.Parameters.AddWithValue("@Password", obj.Password);
                    command.Parameters.AddWithValue("@ConfirmPassword", obj.ConfirmPassword);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        //public int SaveFormData(LoginData formData)
        //{
        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand("sp_registerdata", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@name", formData.Name);
        //            command.Parameters.AddWithValue("@address", formData.Address);
        //            command.Parameters.AddWithValue("@gender", formData.Gender);
        //            command.Parameters.AddWithValue("@state", formData.State);
        //            command.Parameters.AddWithValue("@phone", formData.Phone);
        //            //command.Parameters.AddWithValue("@course", formData.Course);
        //           // command.Parameters.AddWithValue("@price", formData.Price);

        //            connection.Open();
        //            int result = command.ExecuteNonQuery();
        //            return result;
        //        }
        //    }
        //}
    }
}
