namespace KassandraWebTest.Kassandra
{
    /// <summary>
    /// Formatted attributes.
    /// </summary>
    public class Attributes
    {
        /// <summary>
        /// Highlited attribute string with value.
        /// </summary>
        /// <param name="isHighlighted">Should the highlight attribute be true?</param>
        /// <returns></returns>
        public static string Highlight(bool isHighlighted) => $"[highlight]={isHighlighted}";
    }
}
