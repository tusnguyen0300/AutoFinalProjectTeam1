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
        private readonly String btnChangePassword = "//ul[@class='ant-menu ant-menu-sub ant-menu-vertical']/li[@role='menuitem'][1]";         // "//div[contains(@style, 'position')]//li[1]"; //for admin
        private readonly String btnLogout = "//ul[@class='ant-menu ant-menu-sub ant-menu-vertical']/li[@role='menuitem'][2]";                 //   "//div[contains(@style, 'position')]//li[2]"; // for admin

        //ul[@id='rc-menu-uuid-16799-3-username-popup']/li[@role='menuitem']

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
            //IsElementNotDisplay(btnManageUser);
            //IsElementNotDisplay(btnManageAssets);
            //IsElementNotDisplay(btnManageAassignments);
        }

        public void ChangePassword(string oldPassword,string newPassword)
        {
            Clicks(btnConfigUser);
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
