using NUnit.Framework;
using ICT3101_Calculator;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => 
                fr.Read("MagicNumbers.txt")).Returns(new string[2]{"42","42"});
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_WithMockedFileReader_Index0_ReturnsExpectedValue()
        {
            // Index 0 should return 42, processed as 2 * 42 = 84
            var result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WithMockedFileReader_Index1_ReturnsExpectedValue()
        {
            // Index 1 should return 42, processed as 2 * 42 = 84
            var result = _calculator.GenMagicNum(1, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WithMockedFileReader_NegativeIndex_ReturnsZero()
        {
            // Negative index should return 0 (no processing)
            var result = _calculator.GenMagicNum(-1, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GenMagicNum_WithMockedFileReader_IndexOutOfRange_ReturnsZero()
        {
            // Index beyond array length should return 0 (no processing)
            var result = _calculator.GenMagicNum(5, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GenMagicNum_WithMockedNegativeValue_ReturnsNegativeDoubled()
        {
            // Setup mock to return negative value
            _mockFileReader.Setup(fr => 
                fr.Read("MagicNumbers.txt")).Returns(new string[1]{"-15"});
            
            // Index 0 should return -15, processed as -2 * -15 = 30
            var result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void GenMagicNum_WithMockedZeroValue_ReturnsZero()
        {
            // Setup mock to return zero
            _mockFileReader.Setup(fr => 
                fr.Read("MagicNumbers.txt")).Returns(new string[1]{"0"});
            
            // Index 0 should return 0, processed as -2 * 0 = 0
            var result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GenMagicNum_VerifyFileReaderCalled()
        {
            // This test verifies that the FileReader's Read method is actually called
            var result = _calculator.GenMagicNum(0, _mockFileReader.Object);
            
            // Verify that Read was called exactly once with the correct parameter
            _mockFileReader.Verify(fr => fr.Read("MagicNumbers.txt"), Times.Once);
        }
    }
}