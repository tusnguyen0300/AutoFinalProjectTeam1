using OpenQA.Selenium;

namespace CoreFramework.DriverCore
{
    public class WebDriverManager_
    {
        private static AsyncLocal<IWebDriver> driver = new AsyncLocal<IWebDriver>();
        //AsyncLocal to run parallel test

        public static void InitDriver(string Browser, int Width, int Height)
        {
            IWebDriver newDriver = null;
            /*
            if (frameworkConfiguration.ExecuteLocation.Equals("local"))
            {
                newDriver = WebDriverCreator.CreateLocalDriver(Browser, Width, Height);
            }
            else if (frameworkConfiguration.ExecuteLocation.Equals("browserstack"))
            {
                newDriver = WebDriverCreator.CreateBrowserStackDriver(Browser, Width, Height);
            }
            */

            newDriver = WebDriverCreator.CreateLocalDriver(Browser, Width, Height);

            if (newDriver == null)
                throw new Exception($"{Browser} browser is not supported)");
            driver.Value = newDriver;
        }

        public static IWebDriver GetCurrentDriver()
        {
            return driver.Value;
        }

        public static void CloseDriver()
        {
            if (driver.Value != null)
            {
                driver.Value.Quit();
                driver.Value.Dispose();
            }
        }
    }
}
