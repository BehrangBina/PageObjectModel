Feature: BaseScenarios
These scenarios can be used in any projects

Background: I navigate to the home page
Given  I navigate to the home page

@Debug
Scenario: 02. Validate the title of a website	
	Then   I can see the web title "Wikipedia"

@Debug
Scenario: 01. Validate the url of a website
	Then   I can see the web url "https://www.wikipedia.org/"

@PhantomJs
Scenario: 03. Validate existance of multiple texts in PageSource	
	Then   I can see
	| expectedText |
	| 日本語          |
	| 中文           |
	| Français     |