using CoreFramework.DriverCore;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.PageObject
{
    public class ManagaUserPage : WebDriverAction
    {
        public ManagaUserPage(IWebDriver driver) : base(driver)
        {
        }
        private readonly string detaiPopup = "//div[contains(text(),'Detailed User Information')]";
        private readonly string listUser = "//div[@id='root']//tr[@class='ant-table-row ant-table-row-level-0']";
        private readonly string pageTitle = "//div[contains(text(),'Manage Users')]";



        public void VerifyManageUserPageDisplay()
        {
            IsElementDisplay(pageTitle);
        }



        public IList<IWebElement> GetUserList()
        {
            IList<IWebElement> randomUsers = FindElementsByXpath(listUser);
            return randomUsers;
        }
        public void GetDetailOfRandomUser()
        {
            IList<IWebElement> randomUsers = GetUserList();
            foreach (var user in randomUsers)
            {
                Console.WriteLine(user.Text);
            }
            var random = new Random();
            int index = random.Next(randomUsers.Count);
            Click(randomUsers[index]);
            TestContext.WriteLine(randomUsers[index].Text);
        }



        public void VerifyPopupDisplay()
        {
            IsElementDisplay(detaiPopup);
        }













    }
}
