using MathUtilityLibrary;

namespace TestProject1
{
    public class MathUtilityTest
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange 
            var mathUtility = new MathUtility();

            // Act
            int result = mathUtility.Sum(10, 20);

            // Assert
            Assert.Equal(30, result);
        }


        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            // Arrange 
            var mathUtility = new MathUtility();

            // Act
            int result = mathUtility.Subtract(20, 10);

            // Assert
            Assert.Equal(10, result);
        }


        [Theory]
        [InlineData(10,20, 30)]
        [InlineData(-10,-25, -35)]
        [InlineData(-10,10, 0)]
        public void Add_VariousInputs_ReturnsCorrectSum(int x, int y, int expectedResult)
        {
            // Arrange 
            var mathUtility = new MathUtility();

            // Act
            int actualResult = mathUtility.Sum(x, y);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            var mathUtility = new MathUtility();
            Assert.Throws<DivideByZeroException>( () => mathUtility.Divide(10,0) );
        }

    }
}