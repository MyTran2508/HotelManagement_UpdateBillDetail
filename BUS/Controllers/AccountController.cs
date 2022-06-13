using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DTO.Entities;

namespace BUS.Controllers
{
    public class AccountController
    {
        // Create Account
        private Account CreateAccount(string EmployeeId, string Username, string Password)
        {
            Account acc = new Account();
            acc.EmployeeId = EmployeeId;
            acc.Username = Username;
            acc.Password = Password;
            return acc;
        }

        // Get Accounts
        public List<Account> GetAllAccounts(ref string error)
        {

            try
            {
                using (var context = new Context())
                {
                    var accounts = context.Accounts.ToList();
                    foreach (var account in accounts)
                    {
                        context.Entry(account).Reference("Employee").Load();
                    }
                    error = "Get Accounts Success!!!";
                    return accounts;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
            
        }

        public bool HandleLogin(string Username, string Password, ref string error)
        {
            try
            {
                Username = Username.Trim();
                Password = Password.Trim(); 
                using (var context = new Context())
                {
                    var acc = context.
                        Accounts.SingleOrDefault(a => a.Username == Username);

                    if (acc != null)
                    {
                        if (acc.Password == Password)
                        {
                            error = "Login Success!!!";
                            return true;
                        }
                        error = "Password Invalid";
                        return false;
                    }
                    error = "Username Is Not Exist";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong!!!";
                return false;
            }
        }

        public bool UpdateAccountByEmployeeId(string Id, string NewPassWord, ref string error)
        {
            try
            {
                using (var context = new Context())
                {
                    var account = context.
                        Accounts.SingleOrDefault(a => a.EmployeeId == Id);
                    if (account != null)
                    {
                        account.Password = NewPassWord;
                        context.SaveChanges();
                        error = "Update Account Success!!!";
                        return true;
                    }
                    error = "Account Is Not Exsit!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Update Account!!!";
                return false;
            }
        }
    
        // Insert Account
        public bool InsertAccount
        (
            string EmployeeId, 
            string Username, 
            string Password, 
            ref string error
        )
        {
            try
            {
                using (var context = new Context())
                {

                    var ac = this.
                        CreateAccount(EmployeeId, Username, Password);

                    if (ac != null)
                    {
                        context.Accounts.Add(ac);
                        context.SaveChanges();
                        error = $"Add Account Success!!!";
                        return true;
                    }
                    error = "Account Invalid!!!";
                    return false;
                }
            }
            catch
            {
                error = "Something Was Wrong When Add Account!!!";
                return false;
            }
        }
    }
}
