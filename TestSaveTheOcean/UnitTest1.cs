using LLibreria;
using SaveTheOcean;

namespace TestSaveTheOcean
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGATortuga()
        {
            // Arrange
            Tortuga testTortuga = new Tortuga("aaa", "aaa", 20);
            double GA = 5.5; 
            int x = 5; 
            int expected = Convert.ToInt32(GA - ((GA - 2) * (2 * GA + 3)) - x); 

            // Act
            int result = testTortuga.CalcGA(GA, x); 

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGAAu()
        {
            // Arrange
            Au testAu= new Au("bbb", "bbb", 20);
            double GA = 5.5;
            int x = 5;
            int expected = Convert.ToInt32(GA - (GA * GA + x));

            // Act
            int result = testAu.CalcGA(GA, x);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGACetaci()
        {
            // Arrange
            Cetaci testCetaci = new Cetaci("ccc", "ccc", 20);
            double GA = 5.5;
            int x = 5;
            int expected = Convert.ToInt32(GA - (Math.Log10(GA) - x));

            // Act
            int result = testCetaci.CalcGA(GA, x);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestInRange()
        {
            int max = 20; 
            int min = 5; 
            int num = 12; 

            // Act
            bool result = Class1.InRange(max, min, num); 

            // Assert
            Assert.IsTrue(result); 
        }
        [TestMethod]
        public void TestOutOfRange()
        {
            int max = 20;
            int min = 5;
            int num = 4;

            // Act
            bool result = Class1.InRange(max, min, num);

            // Assert
            Assert.IsFalse(result);
        }
    }
}