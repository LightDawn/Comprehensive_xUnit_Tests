namespace FactTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var expectedValue = 2;
            var actualValue = 2;
            await Task.Yield();
            Assert.Equal(expectedValue, actualValue);
        }


        [Fact]
        public void Test_My_CLASS_NAME_IF_NOT_EQUAL_THROWS()
        {
            object obj1 = new MyClass { Name = "Object 2" };//From Refactored code
            object obj2 = new MyClass { Name = "Object 2" };//From Previous code
            Assert.Throws<ObjReferenceChecker>(testCode: () => CheckNameEquality((MyClass)obj1, (MyClass)obj2));
        }

        [Fact]
        public void Test_My_CLASS_DEFAULT_NULL_THROWS()
        {
            object obj2 = new MyClass { Name = "Object 2" };
            Assert.NotNull(obj2);

        }

        private void CheckNameEquality(MyClass obj1, MyClass obj2)
        {
            if (obj1.Name != obj2.Name)
            {
                throw new ObjReferenceChecker();
            }
        }
    }
}