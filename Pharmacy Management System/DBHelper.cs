
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Pharmacy_Management_System
//{
//    public class Result
//    {
//        public DataTable Data { get; set; }
//        public bool HasError { get; set; }
//        public string Message { get; set; }
//    }
//    internal class DBHelper
//    {
//        public static SqlConnection con =
//   new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True;TrustServerCertificate=True");

//        public static Result GetQueryData(string query)
//        {
//            var result = new Result();
//            try
//            {
//                con.Open();
//                //string query = "select * from UserInfo";

//                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
//                DataSet ds = new DataSet();
//                adapter.Fill(ds);
//                DataTable dt = ds.Tables[0];//0 as there is only one table

//                con.Close();
//                result.Data = dt;
//                //return dt;
//            }
//            catch (Exception ex)
//            {
//                result.HasError = true;
//                result.Message = "Error: DB realted error!" + ex.Message;
//            }
//            return result;
//        }
//        public static Result ExecuteNonResultQuery(string query)
//        {
//            //for insert, update, delete
//            var result = new Result();
//            try
//            {
//                con.Open();
//                //string query = "select * from UserInfo";

//                SqlCommand cmd = new SqlCommand(query, con);//passing query to DB
//                cmd.ExecuteNonQuery();//will be used to update,delete and insert only as it never returns anything

//                con.Close();

//            }
//            catch (Exception ex)
//            {
//                result.HasError = true;
//                result.Message = "Error: DB realted error!" + ex.Message;
//            }
//            return result;
//        }
//    }
//}
