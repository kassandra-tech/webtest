namespace KassandraWebTest.Kassandra
{
    /// <summary>
    /// Formatted attributes.
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Highlight
        /// </summary>
        public const string HighlightAttribute = "Highlight";

        /// <summary>
        /// Scrollable
        /// </summary>
        public const string ScrollableAttribute = "Scrollable";

        /// <summary>
        /// Highlited attribute string with value.
        /// </summary>
        /// <param name="isHighlighted">Should the highlight attribute be true?</param>
        /// <returns></returns>
        public static string Highlight(bool isHighlighted) => $"[{HighlightAttribute}]={isHighlighted}";

        /// <summary>
        /// Scrollable attribute string with value.
        /// </summary>
        /// <param name="isScrollable">Should the scrollable attribute be true?</param>
        /// <returns></returns>
        public static string Scrollable(bool isScrollable) => $"[{ScrollableAttribute}]={isScrollable}";
    }
}
