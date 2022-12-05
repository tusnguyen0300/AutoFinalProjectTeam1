using CoreFramework.DriverCore;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.Network;
using Scenario_Team1_Auto.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.PageObject
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver driver) : base(driver)
        { 
        }

        private readonly String tfUserName = "//input[@id='login_username']"; 
        private readonly String tfPassWord = "//input[@id='login_password']";
        private readonly String btnLogin = "//button[@type='submit']";
        private readonly String tfPasswordFirtTime = "//*[@id='change-password-first-time_newPassword']";
        private readonly String btnSave = "//*[@type='submit']";


        public void Login(string username, string password)
        {
            IsElementDisable(btnLogin);
            SendKeys_(tfUserName, username);
            SendKeys_(tfPassWord, password);
            IsElementEnable(btnLogin);
            Clicks(btnLogin);
        }
        public void ChangePasswordForTheFirstTime(string newPassword)
        {
            IsElementDisable(btnSave);
            SendKeys_(tfPasswordFirtTime, newPassword);
            IsElementEnable(btnSave);
            Clicks(btnSave);
        }
    }
}

