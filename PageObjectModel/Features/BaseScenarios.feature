Feature: BaseScenarios
These scenarios can be used in any projects

@Debug
Scenario: Validate the title of a website
	Given  I navigate to the home page
	Then   I can see the web title "Wikipedia"

@Debug
Scenario: Validate the url of a website
	Given  I navigate to the home page
	Then   I can see the web url "https://www.wikipedia.org/"

@Debug
Scenario: Validate existance of multiple texts in PageSource
	Given  I navigate to the home page
	Then   I can see
	| expectedText |
	| 日本語          |
	| 中文           |
	| Français     |