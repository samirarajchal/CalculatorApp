using CalculatorApp;

namespace TestProject
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Add add = new Add();
            int a = 5;
            int b = 6;

            //Act
            int result = add.AddNumbers(a, b);

            //Assert
            Assert.AreEqual(11, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Add add = new Add();
            int a = 5;
            int b = 6;

            //Act
            int result = add.AddNumbers(a, b);

            //Assert
            Assert.AreEqual(11, result);
        }
    }
}
