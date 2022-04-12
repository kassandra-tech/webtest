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

        /// <summary>
        /// Locate a button by text.
        /// </summary>
        /// <param name="text">Button element text.</param>
        /// <returns></returns>
        public static string ButtonElementName(string text) => $"{GetFormattedElementName(text)}{KassandraElementType.Button}";

        /// <summary>
        /// Locate a checkbox by name.
        /// </summary>
        /// <param name="name">Checkbox element name.</param>
        /// <returns></returns>
        public static string CheckboxElementName(string name) => $"{GetFormattedElementName(name)}{KassandraElementType.Checkbox}";

        /// <summary>
        /// Locate a dropdown by name.
        /// </summary>
        /// <param name="name">Dropdown element name</param>
        /// <returns></returns>
        public static string DropdownElementName(string name) => $"{GetFormattedElementName(name)}{KassandraElementType.Dropdown}";

        /// <summary>
        /// Locate a field by name.
        /// </summary>
        /// <param name="name">Field element name.</param>
        /// <returns></returns>
        public static string FieldElementName(string name) => $"{GetFormattedElementName(name)}{KassandraElementType.Field}";

        /// <summary>
        /// Locate an icon by name.
        /// </summary>
        /// <param name="name">Icon element name.</param>
        /// <returns></returns>
        public static string IconElementName(string name) => $"{GetFormattedElementName(name)}{KassandraElementType.Icon}";

        /// <summary>
        /// Locate a Label by text.
        /// </summary>
        /// <param name="text">Label element text.</param>
        /// <returns></returns>
        public static string LabelElementName(string text) => $"{GetFormattedElementName(text)}{KassandraElementType.Label}";

        /// <summary>
        /// Locate a link by text.
        /// </summary>
        /// <param name="text">Link element text.</param>
        /// <returns></returns>
        public static string LinkElementName(string text) => $"{GetFormattedElementName(text)}{KassandraElementType.Link}";

        private static string GetFormattedElementName(string name)
        {
            return name.Replace(@"/", string.Empty)
                       .Replace("?", string.Empty)
                       .Replace("!", string.Empty)
                       .Replace(" ", string.Empty);
        }
    }
}
