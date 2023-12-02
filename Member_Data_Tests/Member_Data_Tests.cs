namespace Member_Data_Tests
{
    public class Member_Data_Tests
    {
        public static IEnumerable<object[]> DataTest()
        {
            return new[]
          {
            new object[] { 1, 2 },
            new object[] { 2, 2 },
            new object[] { 3, 3 },
          };
        }

        [Theory]
        [MemberData(memberName: nameof(Member_Data_Tests.DataTest))]
        public void Test_Equality_By_Member_Data_Inline(int value1, int value2)
        {
            Assert.Equal(value1, value2);
        }


        [Theory]
        [MemberData(memberName: nameof(Member_Data_External.GetData), MemberType = typeof(Member_Data_External))]
        public void Test_Equality_By_Member_Data_External_Data(int value1, int value2)
        {
            Assert.Equal(value1, value2);
        }

        [Theory]
        [MemberData(memberName: nameof(Member_Data_External.GetData), 10, MemberType = typeof(Member_Data_External))]
        public void Test_Equality_By_Member_Data_External_Data_With_Number_As_Argument(int value1, int value2, bool compareValue)
        {
            Assert.Equal(compareValue, value1 == value2);
        }
    }
}