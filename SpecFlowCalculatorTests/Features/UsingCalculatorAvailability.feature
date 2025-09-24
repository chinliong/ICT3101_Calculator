Feature: UsingCalculatorAvailability
  In order to calculate MTBF and Availability
  As someone who struggles with math
  I want to be able to use my calculator to do this

  @Availability
  Scenario: Calculating MTBF
    Given I have a calculator
    When I have entered 200 and 50 into the calculator and press MTBF
    Then the availability result should be "250"

  @Availability
  Scenario: Calculating Availability
    Given I have a calculator
    When I have entered 200 and 50 into the calculator and press Availability
    Then the availability result should be "0.8"

  @Availability
  Scenario: Calculating MTBF with equal times
    Given I have a calculator
    When I have entered 100 and 100 into the calculator and press MTBF
    Then the availability result should be "200"

  @Availability
  Scenario: Calculating Availability with equal times
    Given I have a calculator
    When I have entered 100 and 100 into the calculator and press Availability
    Then the availability result should be "0.5"