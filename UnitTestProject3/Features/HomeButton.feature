Feature: Home button
	Check if the Home button navigates to the Home page and turns to active status


Scenario: Navigate to the Home page
	Given a web browser is at the Form page
	When the user clicks on the Home button
	Then the browser navigates to the home page


Scenario: Home button turns to active status
	Given a web browser is at the Home page
	Then the home button status is active
