Feature: BaseScenarios
These scenarios can be used in any projects

Background: I navigate to the home page
Given  I navigate to the home page

@Debug
Scenario: Validate the title of a website	
	Then   I can see the web title "Wikipedia"

@Debug
Scenario: Validate the url of a website
	Then   I can see the web url "https://www.wikipedia.org/"

@Debug
Scenario: Validate existance of multiple texts in PageSource	
	Then   I can see
	| expectedText |
	| 日本語          |
	| 中文           |
	| Français     |