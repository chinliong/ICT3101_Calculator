Feature: UsingCalculatorMusaLogarithmic
  In order to predict system reliability and failure patterns
  As a system quality engineer
  I want to use the Musa Logarithmic model for failure calculations

  @MusaLogarithmic
  Scenario: Calculating logarithmic failure intensity
    Given I have a calculator
    When I have entered 0.02, 50, and 100 into the calculator and press logarithmic failure intensity
    Then the logarithmic result should be "0.02"

  @MusaLogarithmic
  Scenario: Calculating logarithmic failure intensity at start
    Given I have a calculator
    When I have entered 0.02, 0, and 100 into the calculator and press logarithmic failure intensity
    Then the logarithmic result should be "0.02"

  @MusaLogarithmic
  Scenario: Calculating logarithmic expected failures
    Given I have a calculator
    When I have entered 100, 0.02, and 50 into the calculator and press logarithmic expected failures
    Then the logarithmic result should be "0.007"

  @MusaLogarithmic
  Scenario: Calculating logarithmic expected failures at zero time
    Given I have a calculator
    When I have entered 100, 0.02, and 0 into the calculator and press logarithmic expected failures
    Then the logarithmic result should be "0"