Feature: UI Testing button
	Check if the UI Testing button navigates to the Home page


Scenario: Navigate to the Home page with the UI Testing button
	Given a web browser is at the Form page
	When the user clicks on the UI Testing button
	Then the browser navigates to the home page