using CoreFramework.DriverCore;
using OpenQA.Selenium;
using Scenario_Team1_Auto.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.PageObject
{
    public class HomePage : WebDriverAction 
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        private readonly String btnHome = "//a[@href='/home']";
        private readonly String btnHomePage = "//a[@href='/homepage']"; // homepage for staff
        private readonly String btnManageUser = "//a[@href='/manage-users']";
        private readonly String btnManageAssets = "//a[@href='/manage-assets']";
        private readonly String btnManageAassignments = "//a[@href='/manage-assignments']";
        
        private readonly String btnConfigUser = "//div[@role='menuitem']";
        private readonly String btnChangePassword = "//ul[@class='ant-menu ant-menu-sub ant-menu-vertical']/li[@role='menuitem'][1]";         
        private readonly String btnLogout = "//ul[@class='ant-menu ant-menu-sub ant-menu-vertical']/li[@role='menuitem'][2]";   

        private readonly String btnConfirmLogout = "//button[@class='ant-btn ant-btn-primary ant-btn-dangerous']";

        private readonly String tfOldPassword = "//input[@placeholder='Old Password']";
        private readonly String tfNewPassword = "//input[@placeholder='New Password']";
        private readonly String btnSave = "//button[@type='submit']";

        public void VerifyAdminAccessAuthority()
        {
            IsElementDisplay(btnHome);
            IsElementDisplay(btnManageUser);
            IsElementDisplay(btnManageAssets);
            IsElementDisplay(btnManageAassignments);
        }
        public void VerifyStaffAccessAuthority()
        {
            IsElementDisplay(btnHomePage);
        }

        public void ChangePassword(string user,string oldPassword,string newPassword)
        {
            Clicks("//span[contains(text(),'"+user+"')]");
            Clicks(btnChangePassword);

            IsElementDisable(btnSave);

            SendKeys_(tfOldPassword, oldPassword);
            SendKeys_(tfNewPassword, newPassword);

            Clicks(btnSave);
        }
        public void Logout()
        {
            Clicks(btnConfigUser);
            Clicks(btnLogout);
            Clicks(btnConfirmLogout);
        }

        public void GetManageAassignmentsPage()
        {
            Clicks(btnManageAassignments);
        }
        public void GetManageUserPage()
        {
            Clicks(btnManageUser);
        }
    }
}
