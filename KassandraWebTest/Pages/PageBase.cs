using KassandraWebTest.Framework;

namespace KassandraWebTest.Pages
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

        /// <summary>
        /// Locate a button by text.
        /// </summary>
        /// <param name="text">Button element text.</param>
        /// <returns></returns>
        public static string ButtonElementName(string text) => $"{GetFormattedElementName(text)}{ElementType.Button}";

        /// <summary>
        /// Locate a checkbox by name.
        /// </summary>
        /// <param name="name">Checkbox element name.</param>
        /// <returns></returns>
        public static string CheckboxElementName(string name) => $"{GetFormattedElementName(name)}{ElementType.Checkbox}";

        /// <summary>
        /// Locate a dropdown by name.
        /// </summary>
        /// <param name="name">Dropdown element name</param>
        /// <returns></returns>
        public static string DropdownElementName(string name) => $"{GetFormattedElementName(name)}{ElementType.Dropdown}";

        /// <summary>
        /// Locate a dropdown by name.
        /// </summary>
        /// <param name="name">Dropdown element name</param>
        /// <returns></returns>
        public static string SortableDropdownElementName(string name) => $"{GetFormattedElementName(name)}{ElementType.SortableDropdown}";

        /// <summary>
        /// Locate a field by name.
        /// </summary>
        /// <param name="name">Field element name.</param>
        /// <returns></returns>
        public static string FieldElementName(string name) => $"{GetFormattedElementName(name)}{ElementType.Field}";

        /// <summary>
        /// Locate an icon by name.
        /// </summary>
        /// <param name="name">Icon element name.</param>
        /// <returns></returns>
        public static string IconElementName(string name) => $"{GetFormattedElementName(name)}{ElementType.Icon}";

        /// <summary>
        /// Locate a Label by text.
        /// </summary>
        /// <param name="text">Label element text.</param>
        /// <returns></returns>
        public static string LabelElementName(string text) => $"{GetFormattedElementName(text)}{ElementType.Label}";

        /// <summary>
        /// Locate a link by text.
        /// </summary>
        /// <param name="text">Link element text.</param>
        /// <returns></returns>
        public static string LinkElementName(string text) => $"{GetFormattedElementName(text)}{ElementType.Link}";

        private static string GetFormattedElementName(string name)
        {
            return name.Replace(@"/", string.Empty)
                       .Replace("?", string.Empty)
                       .Replace("!", string.Empty)
                       .Replace(" ", string.Empty);
        }
    }
}
