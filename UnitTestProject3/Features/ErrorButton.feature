Feature: Error button
	Check if the Error button gets a 404 HTTP response code


Scenario: Error button gets a 404 HTTP response code
	Given a web browser is at the Home page
	When the user clicks on the Error button
	Then the page title contains Error
