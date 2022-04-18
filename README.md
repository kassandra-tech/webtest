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

``` html
<button type="submit" class="submit_button" id="submit_button" name="Submit">Text</button>
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

#### Dropdown
Allows accepting decisions and filtering one or more options.

#### Field
Users can input data in a field.

#### Icon
Small images that provide symbols to convey information.

``` html
<i class="usdt_icon" id="usdt_icon" name="USDT Icon" alt="Tether (USDT) Icon"></i>
```

#### Image
Pictures on the screen.

``` html
<img src="kassandra_banner.jpg" name="Kassandra Banner" alt="Kassandra banner 'Find your financial freedom'">
```

#### Label
Non editable information text.

``` html
<label class="username_field" id="username_field" name="Username Field">Username</label>
```

#### Link
Allows navigation to other screens and web pages.

``` html
<link class="bitcoin_market_information" id="bitcoin_market_information" name="Bitcoin Market Information" rel="search" href="https://coinmarketcap.com/currencies/bitcoin/">
```

#### Sortable Dropdown
Dropdown that can be sorted in assending and decending order.

#### Toggle
Allows selecting or deselecting an option, similar to a checkbox.

