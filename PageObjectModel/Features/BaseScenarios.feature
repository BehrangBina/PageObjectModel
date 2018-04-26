Feature: BaseScenarios
These scenarios can be used in any projects

@Debug
Scenario: Validate the title of a website
	Given  I navigate to the home page
	Then   I can see the web title "Wikipedia"
