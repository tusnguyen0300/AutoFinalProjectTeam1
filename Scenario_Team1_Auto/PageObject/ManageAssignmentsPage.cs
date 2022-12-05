using CoreFramework.DriverCore;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Team1_Auto.PageObject
{
    public class ManageAssignmentsPage : WebDriverAction
    {
        public ManageAssignmentsPage(IWebDriver driver) : base(driver)
        {
        }


        public string pageTitle = "//div[contains(text(),'Manage Assignment')]";
        public string btnState = "//input[@id='rc_select_12']";
        public string btnSelectDate = "//input[@id='datepicker']";
        public string tfSearchButton = "//input[@placeholder=\'Search\']";
        public string btnCreateNewAsset = "//span[contains(text(),'Create new asset')]";
        public string listAssignment = "//tr[@class='ant-table-row ant-table-row-level-0']";
        public string popupDetailAssignment = "//div[contains(text(),'Detailed Assignment Information')]";

        //tr[@data-row-key='1']/td[8]/preceding-sibling::td

        public void VerifyManageAssignmentsPageDisplay()
        {
            IsElementDisplay(pageTitle);
        }

        public IList<IWebElement> GetAssignmentList()
        {
            IList<IWebElement> randomAssignment = FindElementsByXpath(listAssignment);
            return randomAssignment;
        }

        public void GetDetailOfRandomAssignment()
        {
            IList<IWebElement> randomAssignment = GetAssignmentList();
            foreach (var assignment in randomAssignment)
            {
                Console.WriteLine(assignment.Text);
            }
            var random = new Random();
            int index = random.Next(randomAssignment.Count);
            Click(randomAssignment[index]);
            TestContext.WriteLine(randomAssignment[index].Text);
        }
        public void VerifyAssignmentPopupDisplay()
        {
            IsElementDisplay(popupDetailAssignment);
        }



    }
}
