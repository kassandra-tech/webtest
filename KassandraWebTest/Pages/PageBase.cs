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
        public static string ButtonElementName(string text) => $"{FormatName(text)}-{ElementType.button}";

        /// <summary>
        /// Locate a checkbox by name.
        /// </summary>
        /// <param name="name">Checkbox element name.</param>
        /// <returns></returns>
        public static string CheckboxElementName(string name) => $"{FormatName(name)}-{ElementType.checkbox}";

        /// <summary>
        /// Locate a dropdown by name.
        /// </summary>
        /// <param name="name">Dropdown element name</param>
        /// <returns></returns>
        public static string DropdownElementName(string name) => $"{FormatName(name)}-{ElementType.dropdown}";

        /// <summary>
        /// Locate a dropdown by name.
        /// </summary>
        /// <param name="name">Dropdown element name</param>
        /// <returns></returns>
        public static string SortableDropdownElementName(string name) => $"{FormatName(name)}-{ElementType.sortableDropdown}";

        /// <summary>
        /// Locate a field by name.
        /// </summary>
        /// <param name="name">Field element name.</param>
        /// <returns></returns>
        public static string FieldElementName(string name) => $"{FormatName(name)}-{ElementType.field}";

        /// <summary>
        /// Locate an icon by name.
        /// </summary>
        /// <param name="name">Icon element name.</param>
        /// <returns></returns>
        public static string IconElementName(string name) => $"{FormatName(name)}-{ElementType.icon}";

        /// <summary>
        /// Locate an image by name.
        /// </summary>
        /// <param name="name">Image element name.</param>
        /// <returns></returns>
        public static string ImageElementName(string name) => $"{FormatName(name)}-{ElementType.image}";

        /// <summary>
        /// Locate a Label by text.
        /// </summary>
        /// <param name="text">Label element text.</param>
        /// <returns></returns>
        public static string LabelElementName(string text) => $"{FormatName(text)}-{ElementType.label}";

        /// <summary>
        /// Locate a link by text.
        /// </summary>
        /// <param name="text">Link element text.</param>
        /// <returns></returns>
        public static string LinkElementName(string text) => $"{FormatName(text)}-{ElementType.link}";

        /// <summary>
        /// Locate a message label by text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string MessageLabelName(string text) => $"{FormatName(text)}-message-{ElementType.label}";

        /// <summary>
        /// Locate a data row by text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string DataRowElementName(string text) => $"{FormatName(text)}-{ElementType.dataRow}";

        /// <summary>
        /// Locate a data view by text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string DataViewElementName(string text) => $"{FormatName(text)}-{ElementType.dataView}";

        private static string FormatName(string name)
        {
            return name.Replace(" ", "-")
                       .ToLower();
        }
    }
}
