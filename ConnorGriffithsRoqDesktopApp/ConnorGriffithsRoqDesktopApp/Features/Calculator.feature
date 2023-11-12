Feature: Calculator

Scenario: Addition
Given I click 8
When I click add
And I click 2
And I click equals
Then I validate the addition answer is correct

Scenario: Subtraction
Given I click 8
When I click subtract
And I click 2
And I click equals
Then I validate the subtraction answer is correct

Scenario: Multiplication
Given I click 8
When I click multiply
And I click 2
And I click equals
Then I validate the multiplication answer is correct

Scenario: Division
Given I click 8
When I click divide
And I click 2
And I click equals
Then I validate the division answer is correct

Scenario: Sqaure
Given I click 9
When I square the selected number
And I click equals
Then I validate the answer when squaring 9 is correct
