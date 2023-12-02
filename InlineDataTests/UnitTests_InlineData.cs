namespace InlineDataTests
{
    public class UnitTests_InlineData
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2 + 1, 3)]
        [InlineData(2, 1 + 1)]
        public void Test_Equality_By_Data(int value1, int value2)
        {
            Assert.Equal(value1, value2);
        }
    }
}