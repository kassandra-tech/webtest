using System;

using KassandraWebTest.Framework;
using KassandraWebTest.Kassandra;

using FluentAssertions;

using TechTalk.SpecFlow;

namespace KassandraWebTest.Steps
{
    /// <summary>
    /// Methods to help with site navigation.
    /// </summary>
    [Binding]
    public class NavigationSteps : StepsBase
    {
        /// <summary>
        /// Constructor.
        /// <param name="browser">Allows interacting with elements.</param>
        /// </summary>
        public NavigationSteps(Browser browser) : base(browser)
        {
        }

        /// <summary>
        /// Navigate to a URL.
        /// NOTE: this requires a prefix of 'http://' or 'https://'
        /// </summary>
        /// <param name="url">URL to navigate to</param>
        [StepDefinition(@"the user navigates to ""(.*)""")]
        public void ToUrl(string url)
        {
            try
            {
                Browser.Driver.Navigate().GoToUrl(url);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Navigate to Kassandra screens.
        /// </summary>
        /// <param name="screenName">Screen to navigate to.</param>
        [StepDefinition(@"the user navigates to the ""(.*)"" screen")]
        public void UserNavigatesToScreen(string screenName)
        {
            var url = SiteMap.GetPageUrl(screenName);
            try
            {
                if (url != SiteMap.UnknownScreen)
                {
                    Browser.Driver.Navigate().GoToUrl(url);
                    Browser.Driver.Title.Should().BeEquivalentTo(screenName);
                }
                else
                {
                    throw new Exception($"{screenName} is not a valid Kassandra screen");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Navigate back to the previous page.
        /// </summary>
        public void Back()
        {
            try
            {
                Browser.Driver.Navigate().Back();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Navigate forward to the previous page.
        /// </summary>
        public void Forward()
        {
            try
            {
                Browser.Driver.Navigate().Forward();
            }
            catch
            {
                throw;
            }
        }
    }
}
