# Kassandra Webtest

Kassandra Webtest contains the core framework and design for running and verifying Kassandra website behavior.

This will be included for all Kassandra UI projects to verify project use cases are working as expected.

## Test Framework and Runner 
Projects will use [SpecFlow](https://specflow.org/) for running use cases to verify system behavior.

## Business Language
A domain specific language using [Gherkin](https://cucumber.io/docs/gherkin/) syntax will be created to represent all Kassandra behavior.

## Web Automation
Selenium WebDriver will be used to run automated use cases.

### Supported Browsers
Chrome

## Kassandra User Interface Design 

### Types
Kassandra element types and minimum design requirements will be defined below.

#### Button
Used to navigate to other screens or change the state of the current screen.

Buttons require an ```id``` attribute.

Button with text.
``` html
<button id="submit-button" class="kassandra-action-button">Submit</button>
```

Button with image.
``` html
<a href="home.html">
  <img src="../images/kassandra-icon.svg" id="kassandra-button" class="header-icon" title="Kassandra Home" alt="Kassandra sphere icon. Navigates home when clicked."></img>
</a>
```

#### Checkbox
Allows accepting decisions and filtering.

``` html
<input type="checkbox" class="binance_checkbox" id="binance_checkbox" name="Binance" value="Binance">
```

#### Data Header
Header for a Data View.

``` html
<th class="market_dataheader" id="market_dataheader" name="Market">Market</th>
```

#### Data Row
Row of elements in a Data View.

``` html
<td class="btc_usd_market_datarow" id="btc_usd_market_datarow" name="BTC-USD">BTC-USD</td>
```

#### Data View
Container of Data Rows. This is for representing tabular data.

``` html
<table class="markets_data_view" id="markets_data_view" name="Markets Data View">
```

#### Div
Organization element.

When used purley for organization and style the following example can be used for divs.
``` html
<div class="kassandra-header">
```

When a div is used for more than style and element format, an ```id``` attribute is required.
``` html
<div id="create-account-label" class="kassandra-title">Create Account</div>
```

#### Dropdown
Allows accepting decisions and filtering one or more options.

#### Field
Users can input data in a field.

Fields require ```type``` and ```id``` attributes.
``` html
<input type="text" id="username-field" class="kassandra-field">
```

``` html
<input type="password" id="password-field" class="kassandra-field">
```

#### Icon
Small images that provide symbols to convey information.

``` html
<i class="usdt_icon" id="usdt_icon" name="USDT Icon" alt="Tether (USDT) Icon"></i>
```

#### Image
Pictures on the screen.

All image elements require the following attributes ```src```, ```title```, and ```alt```.

Image elements that also have behavior and function as buttons must also have a ```id``` attribute.
``` html
<img src="../images/kassandra-icon.svg" id="kassandra-button" class="header-icon" title="Kassandra Home" alt="Kassandra sphere icon. Navigates home when clicked."></img>
```

#### Label
Non editable information text.

``` html
<label class="kassandra-label">Username</label>
```

#### Link
Allows navigation to other screens and web pages.

Links that function as containers for other elements only require a ```href``` attribute.
``` html
<a href="home.html">
  <img src="../images/kassandra-icon.svg" id="kassandra-button" class="header-icon" title="Kassandra Home" alt="Kassandra sphere icon. Navigates home when clicked."></img>
</a>
```

Text links only require ```href``` attributes.
``` html
<a href="coming-soon.html" class="kassandra-header-link">Learn</a>
```

#### Sortable Dropdown
Dropdown that can be sorted in assending and decending order.

#### Toggle
Allows selecting or deselecting an option, similar to a checkbox.

