using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public  class MemberClass
    {
       SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
       public int ManageMembers(int MemberId,
           String MemberName,
           String ContactNumber,
           String Email,
           String Gender,
           String DOB,
           String DOJ,
           byte[] MemberImage,
           int Mode)
       {
           try
           {
               int result = 0;
               SqlCommand cmd = new SqlCommand("SP_ManageMembers", conn);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@MemberId", MemberId);
               cmd.Parameters.AddWithValue("@MemberName", MemberName);
               cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
               cmd.Parameters.AddWithValue("@Email", Email);
               cmd.Parameters.AddWithValue("@Gender", Gender);
               cmd.Parameters.AddWithValue("@DOB", DOB);
               cmd.Parameters.AddWithValue("@DOJ", DOJ);
               cmd.Parameters.AddWithValue("@MemberImage", MemberImage);
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
       public DataTable GetAllMembers()
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select * from MemberTable", conn);
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
       public DataTable GetMemberById(int MemberId)
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select MemberName,MemberImage from MemberTable where MemberId=@MemberId", conn);
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

       public DataTable SearchMember(string MemberName)
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select * from MemberTable where MemberName like @MemberName + '%' ", conn);
               cmd.CommandType = CommandType.Text;
               cmd.Parameters.AddWithValue("@MemberName", MemberName);
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
       public DataTable SearchMember(int MemberId, string MemberName)
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select * from MemberTable where MemberId=@MemberId or MemberName like @MemberName + '%' ", conn);
               cmd.CommandType = CommandType.Text;
               cmd.Parameters.AddWithValue("@MemberId", MemberId);
               cmd.Parameters.AddWithValue("@MemberName", MemberName);
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
       public DataTable SearchMember(int MemberId)
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select * from MemberTable where MemberId=@MemberId", conn);
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
