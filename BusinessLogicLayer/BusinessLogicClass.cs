using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class BusinessLogicClass
    {
        BookCategoryClass bcc = new BookCategoryClass();
        BookClass bc = new BookClass();
        BookIssueClass bic = new BookIssueClass();
        BookReturnClass brc = new BookReturnClass();
        CompanyInfoClass cic = new CompanyInfoClass();
        MemberClass mc = new MemberClass();
        UserClass uc = new UserClass();
        public bool ManageUsers(int UserId,
           String UserName,
           String Password,
           String Role,
           int Mode)
        {
            try
            {
                bool result=false;
                int rs = uc.ManageUsers(UserId,
                    UserName,
                    Password, Role,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageMembers(int MemberId,
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
                bool result = false;
                int rs = mc.ManageMembers(MemberId,
                    MemberName,
                    ContactNumber,
                    Email,
                    Gender,
                    DOB,
                    DOJ,
                    MemberImage,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageCompanyInfo(int CompanyId,
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
                bool result = false;
                int rs = cic.ManageCompanyInfo(CompanyId,
                    CompanyName,
                    Address,
                    Contact,
                    Email,
                    VatRegistrationNumber,
                    PanNumber,
                    Logo, Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageBooksReturn(int ReturnId,
           int MemberId,
           String ISBN,
           String IssuedDate,
           String ReturnDate,
           String ActualReturnDate,
           int Mode)
        {
            try
            {
                bool result = false;
                int rs = brc.ManageBooksReturn(ReturnId,
                    MemberId, ISBN,
                    IssuedDate,
                    ReturnDate,
                    ActualReturnDate,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
        public bool ManageIssuedBooks(int IssueId,
           int MemberId,
           String ISBN,
           String IssuedDate,
           String ReturnDate,
           int Mode)
        {
            try
            {
                bool result = false;
                int rs = bic.ManageIssuedBooks(IssueId,
                    MemberId,
                    ISBN,
                    IssuedDate,
                    ReturnDate,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageBooks(int BookId,
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
                bool result = false;
                int rs = bc.ManageBooks(BookId,
                    CategoryId,
                    BookName,
                    ISBN,
                    AuthorName,
                    PublishedDate,
                    Edition,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool ManageBooksCategory(int CategoryId,
           String CategoryName,
           String Description,
           int Mode)
        {
            try
            {
                bool result = false;
                int rs = bcc.ManageBooksCategory(CategoryId,
                    CategoryName,
                    Description,
                    Mode);
                if (rs > 0)
                    result = true;
                else
                    result = false;
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
