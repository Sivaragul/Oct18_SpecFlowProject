Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Successfullogin
	Given the userid is testuser_2 
	And the password is Test@153
	When successful login
	Then the result should be loggedin

Scenario:Successfullogout
    Given the input is 1
	When successful logout
	Then the ans should be loggedout successfully

Scenario:AddToCart
    Given the prodname is product
	And the quantity is 1
	When Added to the cart
	Then the output should be added successfully