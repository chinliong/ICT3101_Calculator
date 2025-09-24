Feature: UsingCalculatorBasicReliability
  In order to calculate the Basic Musa model's failures/intensities
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this

  @BasicReliability
  Scenario: Calculating current failure intensity
    Given I have a calculator
    When I have entered 10, 50, and 200 into the calculator and press current failure intensity
    Then the reliability result should be "7.5"

  @BasicReliability
  Scenario: Calculating current failure intensity with no failures yet
    Given I have a calculator
    When I have entered 10, 0, and 200 into the calculator and press current failure intensity
    Then the reliability result should be "10"

  @BasicReliability
  Scenario: Calculating average number of expected failures
    Given I have a calculator
    When I have entered 200, 10, and 50 into the calculator and press expected failures
    Then the reliability result should be "183.583"

  @BasicReliability
  Scenario: Calculating expected failures at zero time
    Given I have a calculator
    When I have entered 200, 10, and 0 into the calculator and press expected failures
    Then the reliability result should be "0"