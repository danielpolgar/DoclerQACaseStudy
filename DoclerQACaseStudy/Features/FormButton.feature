Feature: Form button
	Check if the Form button navigates to the Form page and turns to active status


Scenario: Navigate to the Form page
	Given a web browser is at the Home page
	When the user clicks on the Form button
	Then the browser navigates to the Form page


Scenario: Form button turns to active status
	Given a web browser is at the Form page
	Then the form button status is active
