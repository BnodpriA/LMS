using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public class BookClass
    {
       SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
       public int ManageBooks(int BookId,
           int CategoryId,
           String BookName,
           String ISBN,
           String AuthorName,
           String PublishedDate,
           String Edition,
           int Mode)
       {
           try
           {
               int result = 0;
               SqlCommand cmd = new SqlCommand("SP_ManageBooks", conn);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@BookId", BookId);
               cmd.Parameters.AddWithValue("@CategoryId", CategoryId);
               cmd.Parameters.AddWithValue("@BookName", BookName);
               cmd.Parameters.AddWithValue("@ISBN", ISBN);
               cmd.Parameters.AddWithValue("@AuthorName", AuthorName);
               cmd.Parameters.AddWithValue("@PublishedDate", PublishedDate);
               cmd.Parameters.AddWithValue("@Edition", Edition);
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
       public DataTable GetAllBooks()
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select b.BookId,bc.CategoryName,b.BookName,b.ISBN,b.AuthorName,b.PublishedDate,b.Edition from BookTable b,BooksCategoryTable bc where b.CategoryId=bc.CategoryId", conn);
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
       public String BookName(String ISBN)
       {
           try
           {
               String bookName = "";
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select BookName from BookTable where ISBN=@isbn", conn);
               cmd.Parameters.AddWithValue("@isbn", ISBN);
               conn.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               dt.Load(dr);
               conn.Close();
               bookName = dt.Rows[0]["BookName"].ToString();
               return bookName;
           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally { conn.Close(); }
       }

       public String AvaibleDate(String ISBN)
       {
           try
           {
               String availabeDate = "";
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select ReturnDate from BookReturn where ISBN=@isbn", conn);
               cmd.Parameters.AddWithValue("@isbn", ISBN);
               conn.Open();
               SqlDataReader dr = cmd.ExecuteReader();
               dt.Load(dr);
               conn.Close();
               availabeDate = dt.Rows[0]["BookName"].ToString();
               return availabeDate;
           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally { conn.Close(); }
       }
       public DataTable GetBookDetailsByBookName(String BookName)
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select b.BookName,c.CategoryName, b.ISBN,b.AuthorName,b.PublishedDate,b.Edition from BookTable b, BooksCategoryTable c where b.CategoryId=c.CategoryId and  BookName like  @BookName + '%'", conn);
               cmd.Parameters.AddWithValue("@BookName", BookName);
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
