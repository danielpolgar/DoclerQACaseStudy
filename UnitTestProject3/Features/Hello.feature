Feature: Hello
	Check if the browser redirects to the Hello Page and displays the name in the input box


Scenario Outline: Redirect to the Hello Page after submit the input text
	Given a web browser is at the Form page
	When the user writes a <value> in the input box
	And the user clicks on the submit button
	Then the browser navigates to the Hello Page and displays the <result>

	Examples:
      | value            | result          |
      | John             | Hello John!     |
      | Sophia           | Hello Sophia!   |
      | Charlie          | Hello Charlie!  |
      | Emily            | Hello Emily!    |
	  | Dániel           | Hello Dániel!   |

