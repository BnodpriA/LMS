using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class BookIssueClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageIssuedBooks(int IssueId,
            int MemberId,
            String ISBN,
            String IssuedDate,
            String ReturnDate,
            int Mode)
        {
            try
            {
                int result = 0;
                SqlCommand cmd = new SqlCommand("SP_ManageBookIssues", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IssueId", IssueId);
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@IssuedDate", IssuedDate);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetAllIssuedBooks()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select i.IssueId, i.MemberId, b.BookName,b.ISBN, i.IssuedDate, i.ReturnDate from BookIssueTable i, BookTable b where b.ISBN = i.ISBN ", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public String bookIssuedStatus(String ISBN)
        {
            try
            {
                String ReturnDate="";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select ReturnDate from BookIssueTable where ISBN=@isbn",conn);
                cmd.Parameters.AddWithValue("@isbn", ISBN);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                if (dt.Rows.Count > 0)

                {
                    ReturnDate = dt.Rows[0]["ReturnDate"].ToString();
                }
                else
                { ReturnDate = "AVAILABLE"; }
                return ReturnDate;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }

        public DataTable GetAllIssuedBookByMemeberId(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select i.MemberId, b.BookName,i.ISBN, i.IssuedDate, i.ReturnDate from BookTable b, BookIssueTable i where b.ISBN = i.ISBN and i.MemberId = @MemberId", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();

                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
