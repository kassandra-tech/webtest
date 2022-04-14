using KassandraWebTest.Framework;
using KassandraWebTest.Pages;

using TechTalk.SpecFlow;

namespace KassandraWebTest.Steps
{
    /// <summary>
    /// Contains methods that help interact with web elements.
    /// </summary>
    [Binding]
    public class ElementInteractionSteps : StepsBase
    {
        /// <summary>
        /// Constructor.
        /// <param name="browser">Allows interacting with elements.</param>
        /// </summary>
        public ElementInteractionSteps(Browser browser) : base(browser)
        {
        }

        #region Button
        /// <summary>
        /// Click a button.
        /// </summary>
        /// <param name="buttonName">Name of the button.</param>
        [StepDefinition(@"the ""(.*)"" button is clicked")]
        public void ButtonIsClicked(string buttonName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.ButtonElementName(buttonName)).Click();
            }
            catch
            {
                throw;
            }
        }
        #endregion Button

        #region Icon
        /// <summary>
        /// Click the icon.
        /// </summary>
        /// <param name="iconName">Name of the icon.</param>
        [StepDefinition(@"the ""(.*)"" icon is clicked")]
        public void IconIsClicked(string iconName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.IconElementName(iconName)).Click();
            }
            catch
            {
                throw;
            }
        }
        #endregion Icon
        
        #region Dropdown
        /// <summary>
        /// Click a dropdown.
        /// </summary>
        /// <param name="dropdownName">Name of the dropdown.</param>
        [StepDefinition(@"the ""(.*)"" dropdown is clicked")]
        public void DropdownIsClicked(string dropdownName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.DropdownElementName(dropdownName)).Click();
            }
            catch
            {
                throw;
            }
        }
        #endregion Dropdown

        #region Field
        /// <summary>
        /// Enter text into a field.
        /// </summary>
        /// <param name="inputText">Text to enter into the field.</param>
        /// <param name="fieldName">Field identifier.</param>
        [StepDefinition(@"""(.*)"" is entered in the ""(.*)"" field")]
        public void EnteredInTheField(string inputText, string fieldName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.FieldElementName(fieldName)).SendKeys(inputText);
            }
            catch
            {
                throw;
            }
        }
        #endregion Field

        #region Filter
        /// <summary>
        /// Click the given filter.
        /// </summary>
        /// <param name="filter">Filter to click.</param>
        [StepDefinition(@"the ""(.*)"" filter is clicked")]
        public void FilterIsClicked(string filter)
        {
            try
            {
                Browser.Find.ElementByAttribute(filter, ElementType.Filter.ToString()).Click();
            }
            catch
            {
                throw;
            }
        }
        #endregion Filter
    }
}
