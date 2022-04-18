using System;

using KassandraWebTest.Framework;
using KassandraWebTest.Kassandra;
using KassandraWebTest.Pages;

using FluentAssertions;

using TechTalk.SpecFlow;

namespace KassandraWebTest.Steps
{
    /// <summary>
    /// Methods to help verify eleemnt and behavioral interactions.
    /// </summary>
    [Binding]
    public class VerificationSteps : StepsBase
    {
        /// <summary>
        /// Constructor.
        /// <param name="browser">Allows interacting with elements.</param>
        /// </summary>
        public VerificationSteps(Browser browser) : base(browser)
        {
        }

        #region Button
        /// <summary>
        /// Check the given button is displayed on the current screen.
        /// </summary>
        /// <param name="buttonName">Name of the button to check the state of.</param>
        [StepDefinition(@"the ""(.*)"" button is displayed")]
        public void ButtonIsDisplayed(string buttonName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.ButtonElementName(buttonName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the given button is not displayed on the current screen.
        /// </summary>
        /// <param name="buttonName">Name of the button to check the state of.</param>
        [StepDefinition(@"the ""(.*)"" button is not displayed")]
        public void ButtonIsNotDisplayed(string buttonName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.ButtonElementName(buttonName)).Displayed.Should().BeFalse();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the given button is enabled on the current screen.
        /// </summary>
        /// <param name="buttonName">Name of the button to check the state of.</param>
        [StepDefinition(@"the ""(.*)"" button is enabled")]
        public void ButtonIsEnabled(string buttonName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.ButtonElementName(buttonName)).Enabled.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the given button is disabled on the current screen.
        /// </summary>
        /// <param name="buttonName">Name of the button to check the state of.</param>
        [StepDefinition(@"the ""(.*)"" button is disabled")]
        public void ButtonIsDisabled(string buttonName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.ButtonElementName(buttonName)).Enabled.Should().BeFalse();
            }
            catch
            {
                throw;
            }
        }
        #endregion Button

        #region Icon
        /// <summary>
        /// Check the expected icon is displayed on the current screen.
        /// </summary>
        /// <param name="iconName">Expected icon name.</param>
        [StepDefinition(@"the ""(.*)"" icon is displayed")]
        public void IconIsDisplayed(string iconName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.IconElementName(iconName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected icon is highlighted on the current screen.
        /// </summary>
        /// <param name="iconName">Expected icon name.</param>
        [StepDefinition(@"the ""(.*)"" icon is highlighted")]
        public void IconIsHighlighted(string iconName)
        {
            try
            {
                Browser.Find.ElementById($"{PageBase.IconElementName(iconName)}[{Attributes.Highlight(true)}]").Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected icon is not highlighted on the current screen.
        /// </summary>
        /// <param name="iconName">Expected icon name.</param>
        [StepDefinition(@"the ""(.*)"" icon is not highlighted")]
        public void IconIsNotHighlighted(string iconName)
        {
            try
            {
                Browser.Find.ElementById($"{PageBase.IconElementName(iconName)}{Attributes.Highlight(false)}").Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected icon is displayed on the current screen.
        /// </summary>
        /// <param name="iconName">Expected icon name.</param>
        [StepDefinition(@"the ""(.*)"" icon is not displayed")]
        public void IconIsNotDisplayed(string iconName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.IconElementName(iconName)).Displayed.Should().BeFalse();
            }
            catch
            {
                throw;
            }
        }
        #endregion Icon

        #region Checkbox
        /// <summary>
        /// Check the expected checkbox is displayed on the current screen.
        /// </summary>
        /// <param name="checkboxName">Expected checkbox name.</param>
        [StepDefinition(@"the ""(.*)"" checkbox is displayed")]
        public void CheckboxIsDisplayed(string checkboxName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.CheckboxElementName(checkboxName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected checkbox is not displayed on the current screen.
        /// </summary>
        /// <param name="checkboxName">Expected checkbox name.</param>
        [StepDefinition(@"the ""(.*)"" checkbox is not displayed")]
        public void CheckboxIsNotDisplayed(string checkboxName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.CheckboxElementName(checkboxName)).Displayed.Should().BeFalse();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected checkbox is enabled on the current screen.
        /// </summary>
        /// <param name="checkboxName"><Expected checkbox name./param>
        [StepDefinition(@"the ""(.*)"" checkbox is enabled")]
        public void CheckboxIsEnabled(string checkboxName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.CheckboxElementName(checkboxName)).Enabled.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected checkbox is enabled on the current screen.
        /// </summary>
        /// <param name="checkboxName"><Expected checkbox name./param>
        [StepDefinition(@"the ""(.*)"" checkbox is disabled")]
        public void CheckboxIsDisabled(string checkboxName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.CheckboxElementName(checkboxName)).Enabled.Should().BeFalse();
            }
            catch
            {
                throw;
            }
        }
        #endregion Checkbox

        #region Field
        /// <summary>
        /// Check if the expected field is displayed on the current screen.
        /// </summary>
        /// <param name="fieldName">Expected field name.</param>
        [StepDefinition(@"the ""(.*)"" field is displayed")]
        public void FieldIsDisplayed(string fieldName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.FieldElementName(fieldName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check if the expected field is not displayed on the current screen.
        /// </summary>
        /// <param name="fieldName">Expected field name.</param>
        [StepDefinition(@"the ""(.*)"" field is not displayed")]
        public void FieldIsNotDisplayed(string fieldName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.FieldElementName(fieldName)).Displayed.Should().BeFalse();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check if the expected field contains the expected text.
        /// </summary>
        /// <param name="fieldName">Expected field name.</param>
        /// <param name="expectedText">Expected text contained in the given field.</param>
        [StepDefinition(@"the ""(.*)"" field contains ""(.*)""")]
        public void FieldContainsText(string fieldName, string expectedText)
        {
            try
            {
                Browser.Find.ElementById(PageBase.FieldElementName(fieldName)).Text.Should().Contain(expectedText);
            }
            catch
            {
                throw;
            }
        }
        #endregion Field

        #region Text
        /// <summary>
        /// Check if the expected text is displayed.
        /// </summary>
        /// <param name="expectedText">Expected text.</param>
        [StepDefinition(@"""(.*)"" is displayed")]
        public void TextIsDisplayed(string expectedText)
        {
            try
            {
                Browser.Find.ElementById(expectedText).Text.Should().BeEquivalentTo(expectedText);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected title of the screen.
        /// </summary>
        /// <param name="title">Expected screen title.</param>
        [StepDefinition(@"the title is ""(.*)""")]
        public void TitleIs(string title)
        {
            try
            {
                Browser.Driver.Title.Should().BeEquivalentTo(title);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected link is displayed on the current screen.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expectedText"></param>
        [StepDefinition(@"the ""(.*)"" link is displayed")]
        public void LinkTextIsDisplayed(string expectedLinkText)
        {
            try
            {
                Browser.Find.ElementByText(expectedLinkText).Text.Should().BeEquivalentTo(expectedLinkText);
            }
            catch
            {
                throw;
            }
        }
        #endregion Text

        #region Message
        /// <summary>
        /// Check that an information message is displayed with the expected text.
        /// </summary>
        /// <param name="expectedText">Expected Text.</param>
        [StepDefinition(@"the ""(.*)"" information message is displayed")]
        public void InformationMessageDisplayed(string expectedText)
        {
            try
            {
                Browser.Find.ElementByText(expectedText).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }
        #endregion Message

        #region Dropdown
        /// <summary>
        /// Check that the given dropdown is displayed on the current screen.
        /// </summary>
        /// <param name="dropdownName">Name of the dropdown.</param>
        [StepDefinition(@"the ""(.*)"" dropdown is displayed")]
        public void DropdownIsDisplayed(string dropdownName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.DropdownElementName(dropdownName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check that the given sortable dropdown is displayed on the current screen.
        /// </summary>
        /// <param name="dropdownName">Name of the dropdown.</param>
        [StepDefinition(@"the sortable ""(.*)"" is displayed")]
        public void ThenTheSortableIsDisplayed(string dropdownName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.SortableDropdownElementName(dropdownName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }
        #endregion Dropdown

        #region Container
        /// <summary>
        /// Check the given container is contains the expected element.
        /// </summary>
        /// <param name="containerName">Text of the parent container.</param>
        /// <param name="elementName">Expected name of child element.</param>
        [StepDefinition(@"the ""(.*)"" contains ""(.*)""")]
        public void ContainerContains(string containerName, string elementName)
        {
            try
            {
                Browser.Find.ElementByText(containerName).FindElementByName(elementName).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }
        #endregion Container

        #region Label
        /// <summary>
        /// Check that the given label is displayed on the current screen.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        [StepDefinition(@"the ""(.*)"" label is displayed")]
        public void LabelIsDisplayed(string labelName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.LabelElementName(labelName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check that a label is displayed with the expected text on the current screen.
        /// </summary>
        /// <param name="labelName">Name of the label.</param>
        /// <param name="expectedText">Expected text to find in a lable element.</param>
        [StepDefinition(@"the ""(.*)"" label is ""(.*)""")]
        public void LabelIsDisplayed(string labelName, string expectedText)
        {
            try
            {
                Browser.Find.ElementById(PageBase.LabelElementName(labelName)).SendKeys(expectedText);
            }
            catch
            {
                throw;
            }
        }
        #endregion Label

        #region Screen
        /// <summary>
        /// Check if the expected screen is displayed on the current screen.
        /// This expects the screenName to be the 'title' attribute of the screen.
        /// </summary>
        /// <param name="screenName">Name of the expected screen.</param>
        [StepDefinition(@"the ""(.*)"" screen is displayed")]
        public void ScreenIsDisplayed(string screenName)
        {
            var url = SiteMap.GetPageUrl(screenName);
            try
            {
                if (url != SiteMap.UnknownScreen)
                {
                    Browser.Driver.Title.Should().BeEquivalentTo(screenName);
                }
                else
                {
                    throw new Exception($"{screenName} is not a valid Kassandra screen");
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion Screen

        #region Sort
        /// <summary>
        /// Check that elements with a given attribute are sorted in ascending order.
        /// </summary>
        /// <param name="attribute">Attribute to locate elements by.</param>
        [StepDefinition(@"the ""(.*)"" are sorted in ascending order")]
        public void AttributesSortedInAscendingOrder(string attribute)
        {
            var market = string.Empty;

            foreach (var data in Browser.Find.ElementsByAttribute(attribute))
            {
                var tempMarket = data.GetAttribute(attribute);
                var result = string.Compare(market, tempMarket);

                if (result == -1)
                {
                    market = tempMarket;
                }
                else
                {
                    market.Should().StartWith(tempMarket);
                }
            }
        }

        /// <summary>
        /// Check that elements with a given attribute are sorted in descending order.
        /// </summary>
        /// <param name="attribute">Attribute to locate elements by.</param>
        [StepDefinition(@"the ""(.*)"" are sorted in descending order")]
        public void AttributeSortedInDescendingOrder(string attribute)
        {
            var market = string.Empty;

            foreach (var data in Browser.Find.ElementsByAttribute(attribute))
            {
                var tempMarket = data.GetAttribute(attribute);
                var result = string.Compare(market, tempMarket);

                if (result == 1)
                {
                    market = tempMarket;
                }
                else
                {
                    tempMarket.Should().StartWith(market);
                }
            }
        }
        #endregion Sort

        #region DataRow
        /// <summary>
        /// Check the datarow contains the expected icon.
        /// </summary>
        /// <param name="dataRow">Datarow to find the icon in.</param>
        /// <param name="expectedIcon">Expected icon in the given datarow.</param>
        [StepDefinition(@"the ""(.*)"" datarow contains the ""(.*)"" icon")]
        public void DatarowContainsTheIcon(string dataRow, string expectedIcon)
        {
            try
            {
                Browser.Find.ElementById(PageBase.DataRowElementName(dataRow)).FindElementById(PageBase.IconElementName(expectedIcon)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected icon is displayed for the given datarow on the current screen.
        /// </summary>
        /// <param name="iconName">Expected icon name.</param>
        [StepDefinition(@"the ""(.*)"" icon is displayed in the ""(.*)"" datarow")]
        public void DatarowIconIsDisplayed(string iconName)
        {
            try
            {
                Browser.Find.ElementById(PageBase.IconElementName(iconName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected datarow contains an element with the given name.
        /// </summary>
        /// <param name="dataRow">Row in a dataview to find an element of.</param>
        /// <param name="name">Name of expected element in a datarow.</param>
        [StepDefinition(@"the ""(.*)"" datarow contains ""(.*)""")]
        [StepDefinition(@"the ""(.*)"" datarow contains the ""(.*)"" button")]
        public void DatarowContains(string dataRow, string name)
        {
            try
            {
                Browser.Find.ElementById(PageBase.DataRowElementName(dataRow)).FindElementByName(name).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Check the expected datarow contiains an element with expected text.
        /// </summary>
        /// <param name="dataRow">Row in a dataview to find an element of.</param>
        /// <param name="name">Name of expected element in a datarow.</param>
        /// <param name="text">Expected text to find.</param>
        [StepDefinition(@"the ""(.*)"" datarow ""(.*)"" is ""(.*)""")]
        public void DatarowItemText(string dataRow, string name, string text)
        {
            try
            {
                Browser.Find.ElementById(PageBase.DataRowElementName(dataRow)).FindElementById(name).Text.Should().BeEquivalentTo(text);
            }
            catch
            {
                throw;
            }
        }
        #endregion DataRow

        #region DataView
        /// <summary>
        /// Check the given dataview is scrollable.
        /// </summary>
        /// <param name="dataView"></param>
        [StepDefinition(@"the ""(.*)"" dataview is scrollable")]
        public void DataViewIsScrollable(string dataView)
        {
            try
            {
                Browser.Find.ElementById(dataView).GetAttribute(Attributes.Scrollable(true)).Should().BeEquivalentTo("true");
            }
            catch
            {
                throw;
            }
        }
        #endregion DataView
    }
}
