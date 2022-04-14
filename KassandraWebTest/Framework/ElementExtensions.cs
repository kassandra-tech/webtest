using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;

namespace KassandraWebTest.Framework
{
    /// <summary>
    /// Extension methods to provide additional capabilities to Elements.
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// Find child element by CSS selector.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static IWebElement FindElementByCss(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElement(By.CssSelector(locator));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child elements by CSS selector.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static List<IWebElement> FindElementsByCss(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElements(By.CssSelector(locator)).ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child element by id.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static IWebElement FindElementById(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElement(By.Id(locator));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child elements by id.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static List<IWebElement> FindElementsById(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElements(By.Id(locator)).ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child element by text.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static IWebElement FindElementByText(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElement(By.LinkText(locator));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child elements by text.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static List<IWebElement> FindElementsByText(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElements(By.LinkText(locator)).ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child element by contained text.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static IWebElement FindElementByContainedText(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElement(By.PartialLinkText(locator));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child elements by contained text.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="locator">String to locate child elements.</param>
        /// <returns></returns>
        public static List<IWebElement> FindElementsByContainedText(this IWebElement element, string locator)
        {
            try
            {
                return element.FindElements(By.PartialLinkText(locator)).ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child element by attribute.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="attribute">String to locate child elements.</param>
        /// <returns></returns>
        public static IWebElement FindElementByAttribute(this IWebElement element, string attribute)
        {
            try
            {
                return element.FindElement(By.CssSelector($"[{attribute}]"));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child elements by attribute.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="attribute">String to locate child elements.</param>
        /// <returns></returns>
        public static List<IWebElement> FindElementsByAttribute(this IWebElement element, string attribute)
        {
            try
            {
                return element.FindElements(By.CssSelector($"[{attribute}]")).ToList();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child element by attribute.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="attribute">String to locate child elements.</param>
        /// <param name="attributeValue">Expected attribute value.</param>
        /// <returns></returns>
        public static IWebElement FindElementByAttributeValue(this IWebElement element, string attribute, string attributeValue)
        {
            try
            {
                return element.FindElement(By.CssSelector($"{attribute}={attributeValue}"));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Find child elements by attribute.
        /// </summary>
        /// <param name="element">Parent element to find children of.</param>
        /// <param name="attribute">String to locate child elements.</param>
        /// <param name="attributeValue">Expected attribute value.</param>
        /// <returns></returns>
        public static List<IWebElement> FindElementsByAttributeValue(this IWebElement element, string attribute, string attributeValue)
        {
            try
            {
                return element.FindElements(By.CssSelector($"{attribute}={attributeValue}")).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
