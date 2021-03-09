using BDD_Test_Framework.utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDD_Test_Framework.pages
{
    public class LoginPage : reusableMethods
    {
        public LoginPage enterUserName(String data)
        {
            enterById(repo.GetString("loginPage_Enter_UserName"), data);
            return this;
        }
        public LoginPage enterPassword(String data)
        {
            enterById(repo.GetString("loginPage_Enter_Password"), data);
            return this;
        }
        public LoginPage clickLoginButton()
        {
            clickById(repo.GetString("loginPage_Click_LoginButton"));
            return this;
        }
    }
}
