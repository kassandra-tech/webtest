using KassandraWebTest.Framework;

namespace KassandraAccountUserActions.Pages
{
    /// <summary>
    /// Base for all pages to provide common functionality and behavior.
    /// </summary>
    public abstract class PageBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="browser">Allows interacting with elements.</param>
        public PageBase(Browser browser)
        {
            Browser = browser;
        }

        /// <summary>
        /// Title of the page.
        /// </summary>
        public abstract string Title { get; }

        /// <summary>
        /// Allows interacting with elements.
        /// </summary>
        public Browser Browser { get; }
    }
}
