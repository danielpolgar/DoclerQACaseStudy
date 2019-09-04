Feature: Title
	Check if the title is "UI Testing Site" on every site


Scenario Outline: Verify the title on every site
	Given the web browser is at the <page>
	Then the page title is UI Testing Site 

	Examples:
      | page                                    | 
      | http://uitest.duodecadits.com/          | 
      | http://uitest.duodecadits.com/form.html |
	  | http://uitest.duodecadits.com/error     |