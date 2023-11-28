namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassTest()
        {
            // Arrange
            int a = 2;
            int b = 3;

            // Act
            int result = a + b;

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void FailTest()
        {
            // Arrange
            int x = 4;
            int y = 6;
            int test = 1;
            test = 2;
            // Act
            int result = x * y +test;

            // Assert
            Assert.Equal(20, result); // This assertion intentionally fails
        }
    }
}