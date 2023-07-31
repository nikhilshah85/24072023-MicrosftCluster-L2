using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading.Channels;

namespace ADO_net_demo
{
    internal class AccountDetails
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
        public bool AccountisActive { get; set; }

        public string AddNewAccount(AccountDetails newAccount)
        {
            /* SqlConnection con = new SqlConnection("server=;database=;userid=;password=");*/ //for server authentication
            SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=bankingDB;integrated security=true");
            SqlCommand cmd_insertAccount = new SqlCommand("insert into AccountDetails values(@accNo,@accName,@accType,@accBalance,@accIsActive)", con);

            cmd_insertAccount.Parameters.AddWithValue("@accNo", newAccount.AccountNo);
            cmd_insertAccount.Parameters.AddWithValue("@accName", newAccount.AccountName);
            cmd_insertAccount.Parameters.AddWithValue("@accType", newAccount.AccountType);
            cmd_insertAccount.Parameters.AddWithValue("@accBalance", newAccount.AccountBalance);
            cmd_insertAccount.Parameters.AddWithValue("@accIsActive", newAccount.AccountisActive);

            try
            {
                con.Open();
                cmd_insertAccount.ExecuteNonQuery();
                return "New Account Added Successfully";
            }
            catch (SqlException es)
            {

                throw new Exception(es.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public string DeleteAccount(int accNo)
        {
            SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=bankingDB;integrated security=true");
            SqlCommand cmd_DeleteAccount = new SqlCommand("delete from accountDetails where accNo =@accNo", con);
            cmd_DeleteAccount.Parameters.AddWithValue("@accNo", accNo);

            try
            {
                con.Open();
                int delete = cmd_DeleteAccount.ExecuteNonQuery();
                if (delete == 1)
                {
                    return "Account Delete Successfully";
                }
                else
                {
                    return "Account Not Found";
                }
            }
            catch (SqlException es)
            {

                throw new Exception(es.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public string updateAccount(AccountDetails changes)
        {
            /* SqlConnection con = new SqlConnection("server=;database=;userid=;password=");*/ //for server authentication
            SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=bankingDB;integrated security=true");
            SqlCommand cmd_updateAccount = new SqlCommand("update accountDetails set accName=@accName,accType=@accType,accBalance=@accBalance,accIsActive=@accIsActive where accNo=@accNo", con);

            cmd_updateAccount.Parameters.AddWithValue("@accNo", changes.AccountName);
            cmd_updateAccount.Parameters.AddWithValue("@accName", changes.AccountName);
            cmd_updateAccount.Parameters.AddWithValue("@accType", changes.AccountType);
            cmd_updateAccount.Parameters.AddWithValue("@accBalance", changes.AccountBalance);
            cmd_updateAccount.Parameters.AddWithValue("@accIsActive", changes.AccountisActive);

            try
            {
                con.Open();
               int result =  cmd_updateAccount.ExecuteNonQuery();
                if (result == 1)
                {
                    return "Account Updated Successfully";
                }
                else
                {
                    return "Account Not Found";
                }
               
            }
            catch (SqlException es)
            {

                throw new Exception(es.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public AccountDetails ViewAccount(int accNo)
        {
            SqlConnection con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=bankingDB;integrated security=true");
            SqlCommand cmd_ViewAccount = new SqlCommand("select * from accountDetails where accNo=@accNo", con);

            cmd_ViewAccount.Parameters.AddWithValue("@accNo", accNo);
            SqlDataReader readAccount = null;

            try
            {
                con.Open();
                readAccount = cmd_ViewAccount.ExecuteReader();
                if(readAccount.Read())
                {
                    AccountDetails acc = new AccountDetails();
                    acc.AccountNo = Convert.ToInt32(readAccount[0]);
                    acc.AccountName = readAccount[1].ToString();
                    acc.AccountType = readAccount[2].ToString();
                    acc.AccountBalance =Convert.ToDouble(readAccount[3]);
                    acc.AccountisActive =Convert.ToBoolean(readAccount[4].ToString());
                    return acc;
                }
                else
                {
                    throw new Exception("Account Not Found");
                }

            }
            catch (SqlException es)
            {
                throw new Exception(es.Message);                
            }
            finally
            {
                readAccount.Close();
                con.Close();
            }
        }
    }
}
