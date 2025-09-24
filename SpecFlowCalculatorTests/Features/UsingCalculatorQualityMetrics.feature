Feature: UsingCalculatorQualityMetrics
  In order to assess and track software quality
  As a system quality engineer  
  I want to calculate defect density and SSI for system releases

  @QualityMetrics
  Scenario: Calculating defect density
    Given I have a calculator
    When I have entered 50 and 10000 into the calculator and press defect density
    Then the quality metrics result should be "0.005"

  @QualityMetrics
  Scenario: Calculating defect density with no defects
    Given I have a calculator
    When I have entered 0 and 5000 into the calculator and press defect density
    Then the quality metrics result should be "0"

  @QualityMetrics
  Scenario: Calculating SSI for second release
    Given I have a calculator
    When I have entered 15000, 9000, and 0 into the calculator and press new SSI
    Then the quality metrics result should be "6000"

  @QualityMetrics
  Scenario: Calculating SSI for third release with no deleted code
    Given I have a calculator
    When I have entered 20000, 15000, and 0 into the calculator and press new SSI
    Then the quality metrics result should be "5000"