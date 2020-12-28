Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
	In order to avoid silly mistakes
	As a math idiot
	I *want* to be told the **sum** of ***two*** numbers

Link to a feature: [Calculator](SampleTestProject/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

	@Addition
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are "added"
	Then the result should be 120

	@Substraction
Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 10
	When the two numbers are "substracted"
	Then the result should be 40

	@Multiplication
Scenario: Multiply two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are "multiplied"
	Then the result should be 50