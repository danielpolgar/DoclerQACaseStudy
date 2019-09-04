Feature: Company Logo
	Check if the company logo is on every site


Scenario Outline: Verify the company logo on every site
	Given the web browser is at the <page>
	Then there is a company logo image

	Examples:
      | page                                    | 
      | http://uitest.duodecadits.com/          | 
      | http://uitest.duodecadits.com/form.html |
	  | http://uitest.duodecadits.com/error     |