using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public  class CompanyInfoClass
    {
       SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
       public int ManageCompanyInfo(int CompanyId,
           String CompanyName,
           String Address,
           String Contact,
           String Email,
           String VatRegistrationNumber,
           String PanNumber,
           byte[] Logo,
           int Mode)
       {
           try
           {
               int result = 0;
               SqlCommand cmd = new SqlCommand("SP_ManageCompanyInfo", conn);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@CompanyId", CompanyId);
               cmd.Parameters.AddWithValue("@CompanyName", CompanyName);
               cmd.Parameters.AddWithValue("@Address", Address);
               cmd.Parameters.AddWithValue("@Contact", Contact);
               cmd.Parameters.AddWithValue("@Email", Email);
               cmd.Parameters.AddWithValue("@VatRegistrationNumber", VatRegistrationNumber);
               cmd.Parameters.AddWithValue("@PanNumber", PanNumber);
               cmd.Parameters.AddWithValue("@Logo", Logo);
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
       public DataTable GetCompanyInfo()
       {
           try
           {
               DataTable dt = new DataTable();
               SqlCommand cmd = new SqlCommand("Select * from CompanyInfoTable where CompanyId=(Select max(CompanyId) from CompanyInfoTable)", conn);
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
