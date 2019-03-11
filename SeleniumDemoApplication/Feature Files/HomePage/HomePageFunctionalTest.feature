@browser_setup_before_feature @close_current_browser
Feature: HomePageFunctionalTest	

Scenario: 001_Ensure that amazon logo is displayed
	Given I go to home page
	Then the amazon logo is displayed

Scenario: 002_Ensure that SearchBox is displayed
	Given I go to home page
	Then the amazon logo is displayed
	Then The Search Box is displayed

Scenario Outline: 003_Check the displaying the Products,that are searched by searchBox
	Given I go to home page
	Then the amazon logo is displayed
	When  Customer search for the Product <products>
	Then I click on search button
	Then The <products> products are displayed

	Examples:
	| products |
	| Apple   |
	| Samsung  |

Scenario: 004_Check the Ratings are displayed
	Given I go to home page
	Then the amazon logo is displayed
	When  Customer search for the Product Apple
	Then I click on search button
	Then The Apple products are displayed
	Then The Ratings of the Products are displayed

Scenario Outline: 005_Click the ratings of the Product
	Given I go to home page
	Then the amazon logo is displayed
	When Customer search for the Product Apple
	Then I click on search button
	Then The Apple products are displayed
	When I click on ratings <rating>
	Then The Ratings of the Products are displayed
	
	Examples: 
	| rating |
	| 4      |
	| 3      |

Scenario: 006_click the Today's Deal 
	Given I go to home page
	Then the amazon logo is displayed
	When Customer click on Today's Deal
	Then Today's Deal Product is displayed

Scenario: 007_Check the Price of Product in dealsPage
	Given I go to home page
	Then the amazon logo is displayed
	When Customer click on Today's Deal
	Then Today's Deal Product are displayed
	When select the price link 
	Then The Product of that price displayed

Scenario: 008_Check the SortByPrice 
	Given I go to home page
	Then the amazon logo is displayed
	When Customer click on Today's Deal
	Then Today's Deal Product are displayed
	Then The Sort by Link is displayed
	When Click on Dropdown List
	Then The Price options are dispalyed
	When Click on the options Low to high
	Then Low to High Price Products displayed

Scenario: 009_Check the Clickevents by JavaScriptExecutor
	Given I go to home page
	Then the amazon logo is displayed
	When Customer click on Today's Deal
	Then Today's Deal Product are displayed
	When Click on Orders 
	Then Orders that have been given are displayed

Scenario: 010_Check the Header Footer 
	Given I go to home page
	Then the amazon logo is displayed
	Then Header is displayed
	Then Footer is displayed

Scenario: 011_Check the Gift Cards
	Given I go to home page
	Then the amazon logo is displayed
	Then Gift cards is displayed
	When click on Gift cards
	Then Gift Cards Items are displayed
	
	
	

	
	 

