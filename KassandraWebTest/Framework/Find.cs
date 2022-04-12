using System.Collections.Generic;
using System.Linq;

using FluentAssertions;

using OpenQA.Selenium;

namespace KassandraWebTest.Framework
{
    /// <summary>
    /// Allows finding elements by provided location strategies.
    /// </summary>
    public class Find
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="driver"></param>
        public Find(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement Element(string id)
        {
            IWebElement element = null;

            try
            {
                element = Driver.FindElement(By.CssSelector($"#{id}"));
            }
            catch
            {
                element.Should().NotBeNull($"Unable to find an element by id '{id}' on the current screen");
            }

            return element;
        }

        /// <summary>
        /// Locate an element by its CSS selector.
        /// </summary>
        /// <param name="selector">Value to locate an element by CSS.</param>
        /// <returns></returns>
        public IWebElement ElementByCss(string selector)
        {
            IWebElement element = null;

            try
            {
                element = Driver.FindElement(By.CssSelector(selector));
            }
            catch
            {
                element.Should().NotBeNull($"Unable to find an element by css selector '{selector}' on the current screen");
            }

            return element;
        }

        /// <summary>
        /// Locate elements by its CSS selector.
        /// </summary>
        /// <param name="selector">Value to locate elements by CSS.</param>
        /// <returns></returns>
        public List<IWebElement> ElementsByCss(string selector)
        {
            List<IWebElement> elements = new();

            try
            {
                elements = Driver.FindElements(By.CssSelector(selector)).ToList();
            }
            catch
            {
                elements.Should().NotBeEmpty($"Unable to find elements by css selector '{selector}' on the current screen");
            }

            return elements;
        }

        /// <summary>
        /// Locate an element by its XPath selector.
        /// </summary>
        /// <param name="selector">Value to locate an element by XPath.</param>
        /// <returns></returns>
        public IWebElement ElementByXpath(string selector)
        {
            IWebElement element = null;

            try
            {
                element = Driver.FindElement(By.XPath(selector));
            }
            catch
            {
                element.Should().NotBeNull($"Unable to find an element by xpath selector '{selector}' on the current screen");
            }

            return element;
        }

        /// <summary>
        /// Locate elements by XPath selector.
        /// </summary>
        /// <param name="selector">Value to locate elements by XPath.</param>
        /// <returns></returns>
        public List<IWebElement> ElementsByXpath(string selector)
        {
            List<IWebElement> elements = new();

            try
            {
                elements = Driver.FindElements(By.XPath(selector)).ToList();
            }
            catch
            {
                elements.Should().NotBeEmpty($"Unable to find elements by xpath with '{selector}' on the current screen");
            }

            return elements;
        }

        /// <summary>
        /// Find an element by the text.
        /// </summary>
        /// <param name="text">Expected text of the element to find.</param>
        /// <returns></returns>
        public IWebElement ElementByText(string text)
        {
            IWebElement element = null;

            try
            {
                element = Driver.FindElement(By.XPath($"[text()='{text}']"));
            }
            catch
            {
                element.Should().NotBeNull($"Unable to find an element by text '{text}' on the current screen");
            }

            return element;
        }

        /// <summary>
        /// Find elements by text.
        /// </summary>
        /// <param name="text">Expected text of the elements to find.</param>
        /// <returns></returns>
        public List<IWebElement> ElementsByText(string text)
        {
            List<IWebElement> elements = new();

            try
            {
                elements = Driver.FindElements(By.XPath($"[text()='{text}']")).ToList();
            }
            catch
            {
                elements.Should().NotBeEmpty($"Unable to find an elements by text '{text}' on the current screen");
            }

            return elements;
        }

        /// <summary>
        /// Find an element by contained text.
        /// </summary>
        /// <param name="text">Expected text contained in an element to find.</param>
        /// <returns></returns>
        public IWebElement ElementByContainedText(string text)
        {
            IWebElement element = null;

            try
            {
                element = Driver.FindElement(By.XPath($"[contains(text()='{text}')]"));
            }
            catch
            {
                element.Should().NotBeNull($"Unable to find an element by contained text '{text}' on the current screen");
            }

            return element;
        }

        /// <summary>
        /// Find elements by contained text.
        /// </summary>
        /// <param name="text">Expected text contained in the elements to find.</param>
        /// <returns></returns>
        public List<IWebElement> ElementsByContainedText(string text)
        {
            List<IWebElement> elements = new();

            try
            {
                elements = Driver.FindElements(By.XPath($"[contains(text()='{text}')]")).ToList();
            }
            catch
            {
                elements.Should().NotBeEmpty($"Unable to find elements by contained text '{text}' on the current screen");
            }

            return elements;
        }

        private IWebDriver Driver { get; }
    }
}
