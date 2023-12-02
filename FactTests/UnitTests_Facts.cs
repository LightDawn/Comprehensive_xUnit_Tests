namespace FactTests
{
    public class UnitTests_Facts
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
        //This potentially shows an approval test, in which obj1 could be loaded from legacy code and obj2 from newly refactored version.
        //The code throws an exception if the result of comparing desired properties of both class are not equal.
        public void Test_My_CLASS_NAME_IF_NOT_EQUAL_THROWS()
        {
           
            object obj1 = new MyClass { Name = "Object 2" };//From legacy code
            object obj2 = new MyClass { Name = "Object 2" };//From Newly refactored code
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