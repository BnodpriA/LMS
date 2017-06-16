using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class BookReturnClass
    {
        SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
        public int ManageBooksReturn(int ReturnId,
            int MemberId,
            String ISBN,
            String IssuedDate,
            String ReturnDate,
            String ActualReturnDate,
            int Mode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_ManageBookReturn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ReturnId", ReturnId);
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@IssuedDate", IssuedDate);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                cmd.Parameters.AddWithValue("@ActualReturnDate", ActualReturnDate);
                cmd.Parameters.AddWithValue("@Mode", Mode);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable GetReturnedBooks()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select r.ReturnId, m.MemberName, b.BookName, r.IssuedDate, r.ReturnDate, r.ActualReturnDate from BookReturn r, BookTable b, MemberTable m where m.MemberId =  r.MemberId  and b.ISBN = r.ISBN", conn);
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

        public DataTable GetReturnedBooksByMemberId(int MemberId)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select r.ReturnId, m.MemberName, b.BookName, b.ISBN, r.IssuedDate, r.ReturnDate, r.ActualReturnDate from BookReturn r, BookTable b, MemberTable m where m.MemberId =  r.MemberId  and b.ISBN = r.ISBN and m.MemberId = @MemberId", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@MemberId", MemberId);
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

        public DataTable GetReturnedBooksByDate( DateTime ReturnDate)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select r.ReturnId, m.MemberName, b.BookName, r.IssuedDate, r.ReturnDate, r.ActualReturnDate from BookReturn r, BookTable b, MemberTable m where m.MemberId =  r.MemberId  and b.ISBN = r.ISBN and r.ReturnDate = @ReturnDate", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
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
