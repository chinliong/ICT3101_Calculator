Feature: UsingCalculatorFactorial
  In order to calculate factorials correctly
  As a math student
  I want to be able to use my calculator to compute factorials

  @Factorial
  Scenario: Normal factorial calculation
    Given I have a calculator
    When I have entered 5 into the calculator and press factorial
    Then the factorial result should be 120

  @Factorial
  Scenario: Zero factorial
    Given I have a calculator
    When I have entered 0 into the calculator and press factorial
    Then the factorial result should be 1

  @Factorial
  Scenario: One factorial
    Given I have a calculator
    When I have entered 1 into the calculator and press factorial
    Then the factorial result should be 1

  @Factorial
  Scenario: Small factorial
    Given I have a calculator
    When I have entered 3 into the calculator and press factorial
    Then the factorial result should be 6