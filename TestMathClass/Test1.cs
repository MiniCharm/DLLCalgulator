using DLLCalgulator;

namespace TestMathClass
{
    [TestClass]
    public sealed class Test1
    {
        [DataTestMethod]
        [DataRow(4,5,9)]
        [DataRow(3,8,11)]
        [DataRow(0,9,9)]

        [TestMethod]
        public void Add(int a, int b,int forventetRes)
        {
            //Arrange
            MathClas math = new MathClas();

            //Act
            int res = math.Add(a, b);

            //Assert
            Assert.AreEqual(res, forventetRes);
        }

        [DataTestMethod]
        [DataRow(4, 5,-1)]
        [DataRow(8,3,5)]
        [DataRow(0, 9,-9)]
        [TestMethod]
        public void Subtract(int a, int b, int forventetRes)
        {
            //Arrange
            MathClas math = new MathClas();

            //Act
            int res = math.Subtract(a, b);

            //Assert
            Assert.AreEqual(res, forventetRes);
        }


        [DataTestMethod]
        [DataRow(4, 1,4)]
        [DataRow(8, 4,2)]
        [DataRow(0, 9,0)]
        [TestMethod]
        public void Divide(int a, int b, int forventetRes)
        {
            //Arrange
            MathClas math = new MathClas();

            //Act
            int res = math.Divide(a, b);

            //Assert
            Assert.AreEqual(res, forventetRes);
        }


        [DataTestMethod]
        [DataRow(4, 5,20)]
        [DataRow(3, 8,24)]
        [DataRow(0, 9,0)]
        [TestMethod]
        public void Multiplyd(int a, int b, int forventetRes)
        {
            //Arrange
            MathClas math = new MathClas();

            //Act
            int res = math.Multiply(a, b);

            //Assert
            Assert.AreEqual(res, forventetRes);
        }



        [DataTestMethod]
        [DataRow(4, 2)]
        [DataRow(11, 3.31)]
        [DataRow(0, 0)]
        [DataRow(5, 2.23)]
        [TestMethod]
        public void SquareRoot(int a, double forventetRes)
        {
            //Arrange
            MathClas math = new MathClas();

            //Act
            double res = math.SquareRoot(a);

            //Assert
            Assert.AreEqual(res, forventetRes,0.01);
        }

    }

}
