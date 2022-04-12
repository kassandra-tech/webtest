using FluentAssertions;

using KassandraWebTest.Framework;

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
                Browser.Find.Element(ButtonElementName(buttonName)).Displayed.Should().BeTrue();
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
                Browser.Find.Element(ButtonElementName(buttonName)).Displayed.Should().BeFalse();
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
                Browser.Find.Element(ButtonElementName(buttonName)).Enabled.Should().BeTrue();
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
                Browser.Find.Element(ButtonElementName(buttonName)).Enabled.Should().BeFalse();
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
                Browser.Find.Element(IconElementName(iconName)).Displayed.Should().BeTrue();
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
                Browser.Find.Element(IconElementName(iconName)).Displayed.Should().BeFalse();
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
                Browser.Find.Element(CheckboxElementName(checkboxName)).Displayed.Should().BeTrue();
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
                Browser.Find.Element(CheckboxElementName(checkboxName)).Displayed.Should().BeFalse();
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
                Browser.Find.Element(CheckboxElementName(checkboxName)).Enabled.Should().BeTrue();
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
                Browser.Find.Element(CheckboxElementName(checkboxName)).Enabled.Should().BeFalse();
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
                Browser.Find.Element(FieldElementName(fieldName)).Displayed.Should().BeTrue();
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
                Browser.Find.Element(FieldElementName(fieldName)).Displayed.Should().BeFalse();
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
                Browser.Find.Element(FieldElementName(fieldName)).Text.Should().Contain(expectedText);
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
                Browser.Find.Element(expectedText).Text.Should().BeEquivalentTo(expectedText);
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
                Browser.Find.Element(DropdownElementName(dropdownName)).Displayed.Should().BeTrue();
            }
            catch
            {
                throw;
            }
        }
        #endregion Dropdown

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
                Browser.Find.Element(LabelElementName(labelName)).Displayed.Should().BeTrue();
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
                Browser.Find.Element(LabelElementName(labelName)).SendKeys(expectedText);
            }
            catch
            {
                throw;
            }
        }
        #endregion Label
    }
}
