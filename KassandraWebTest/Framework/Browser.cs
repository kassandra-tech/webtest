using System;
using System.IO;
using System.Reflection;

using KassandraWebTest.Steps;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace KassandraWebTest.Framework
{
    /// <summary>
    /// Allows interacting with websites.
    /// </summary>
    public class Browser
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Browser()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                Driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 1);
                Driver.Manage().Timeouts().PageLoad = new TimeSpan(0, 0, 10);
                Driver.Manage().Window.Maximize();

                Wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
                Find = new Find(Driver);
                Navigate = new NavigationSteps(this);
                Interaction = new ElementInteractionSteps(this);
                Verify = new VerificationSteps(this);
            }
        }

        /// <summary>
        /// Find elements on the current screen.
        /// </summary>
        public Find Find { get; }

        /// <summary>
        /// Binding methods for navigation related behavior.
        /// </summary>
        public NavigationSteps Navigate { get; }

        /// <summary>
        /// Binding methods for interacting with web elements.
        /// </summary>
        public ElementInteractionSteps Interaction { get; }

        /// <summary>
        /// Binding methods for verifying expected state and behavior.
        /// </summary>
        public VerificationSteps Verify { get; }

        /// <summary>
        /// Wait a specified amount of seconds.
        /// </summary>
        /// <param name="secondsToWait">Number of seconds to wait before the next driver action.</param>
        public void WaitForSeconds(int secondsToWait)
        {
            _ = new WebDriverWait(Driver, TimeSpan.FromSeconds(secondsToWait));
        }

        /// <summary> 
        /// Close the driver after test completion. 
        /// </summary> 
        public void Dispose()
        {
            Driver.Close();
            Driver.Dispose();
        }

        /// <summary>
        /// Provides ability to interact with websites.
        /// </summary>
        internal IWebDriver Driver { get; }

        /// <summary>
        /// Configure waits for locating elements and screen interaction.
        /// </summary>
        internal WebDriverWait Wait { get; }
    }
}
