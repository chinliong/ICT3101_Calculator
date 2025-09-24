using NUnit.Framework;
using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup() => _calculator = new Calculator();

    // Naming: Method_Scenario_ExpectedResult

    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        var result = _calculator.Add(10, 20);
        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
    {
        var result = _calculator.Subtract(10, 3);
        Assert.That(result, Is.EqualTo(7));
    }

    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
    {
        var result = _calculator.Multiply(4, 5);
        Assert.That(result, Is.EqualTo(20));
    }

    // Step 14: zeros should throw
    [Test]
    [TestCase(0, 0)]
    [TestCase(0, 10)]
    [TestCase(10, 0)]
    public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
    {
        Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
    }

    [Test]
    public void Divide_WithNonZeroInputs_ReturnsQuotient()
    {
        var result = _calculator.Divide(10, 2);
        Assert.That(result, Is.EqualTo(5));
    }

    // Factorial
    [Test]
    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(5, 120)]
    public void Factorial_WithNonNegativeIntegers_ReturnsExpected(double n, double expected)
    {
        var result = _calculator.Factorial(n);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Factorial_WithNegative_Throws()
    {
        Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
    }

    // TDD examples
    [Test]
    [TestCase(10, 5, 25)]
    [TestCase(3, 4, 6)]
    public void AreaOfTriangle_ValidInputs_ReturnsArea(double h, double l, double expected)
    {
        var result = _calculator.AreaOfTriangle(h, l);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void AreaOfTriangle_Negative_Throws()
    {
        Assert.That(() => _calculator.AreaOfTriangle(-1, 2), Throws.ArgumentException);
    }

    [Test]
    [TestCase(0, 0)]
    [TestCase(1, System.Math.PI)]
    [TestCase(2, 12.566370614359172)]
    public void AreaOfCircle_ValidInputs_ReturnsArea(double r, double expected)
    {
        var result = _calculator.AreaOfCircle(r);
        Assert.That(result, Is.EqualTo(expected).Within(1e-9));
    }

    [Test]
    public void AreaOfCircle_Negative_Throws()
    {
        Assert.That(() => _calculator.AreaOfCircle(-3), Throws.ArgumentException);
    }

    // UnknownFunctionA: permutations
    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        var result = _calculator.UnknownFunctionA(5, 5);
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        var result = _calculator.UnknownFunctionA(5, 4);
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        var result = _calculator.UnknownFunctionA(5, 3);
        Assert.That(result, Is.EqualTo(60));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
    {
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
    {
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }

    // UnknownFunctionB: combinations
    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        var result = _calculator.UnknownFunctionB(5, 5);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        var result = _calculator.UnknownFunctionB(5, 4);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        var result = _calculator.UnknownFunctionB(5, 3);
        Assert.That(result, Is.EqualTo(10));
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
    {
        Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
    {
        Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
    }
}
