

namespace Member_Data_Tests
{
    public class Member_Data_External
    {
        public static IEnumerable<object[]> GetData(int start) => new[]
            {
                new object[] { start, start, true },
                new object[] { start, start + 1, false },
                new object[] { start + 1, start + 1, true }
            };


        public static IEnumerable<object[]> GetData() => new[]
        {
            new object[] { 1, 2 },
            new object[] { 2, 2 },
            new object[] { 3, 3 },
          };
        }
}
