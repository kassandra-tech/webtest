using KassandraWebTest.Framework;

namespace KassandraWebTest.Steps
{
    /// <summary>
    /// Common setup for Step classes.
    /// </summary>
    public abstract class StepsBase
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public StepsBase(Browser browser)
        {
            Browser = browser;
        }

        /// <summary>
        /// Allows interacting with elements.
        /// </summary>
        public Browser Browser { get; }
    }
}
