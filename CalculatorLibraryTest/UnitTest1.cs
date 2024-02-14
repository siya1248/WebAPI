using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
namespace CalculatorLibraryTest;
{
[TestClass]
public class AddTests
{
    [TestMethod]
    public void TestMethod1()
    {
        int a=5;
        int b=3;
        int result = 8;

        int actualSum = Calculator.Add(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod2()
    {
        int a=-5;
        int b=-3;
        int result = -8;

        int actualSum = Calculator.Add(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod3()
    {
        int a=5;
        int b=-3;
        int result = 2;

        int actualSum = Calculator.Add(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod4()
    {
        int a=-5;
        int b=3;
        int result = -2;

        int actualSum = Calculator.Add(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod5()
    {
        int a=0;
        int b=-3;
        int result = -3;

        int actualSum = Calculator.Add(a,b);
        Assert.AreEqual(result, actualSum);
    }
}
public class SubstractTests
{
    [TestMethod]
    public void TestMethod6()
    {
        int a=4;
        int b=2;
        int result = 2;

        int actualSum = Calculator.Subtract(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod7()
    {
        int a=-4;
        int b=-2;
        int result = -2;

        int actualSum = Calculator.Subtract(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod8()
    {
        int a=4;
        int b=-2;
        int result = 2;

        int actualSum = Calculator.Subtract(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod9()
    {
        int a=-4;
        int b=2;
        int result = -6;

        int actualSum = Calculator.Subtract(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod10()
    {
        int a=0;
        int b=-2;
        int result = -2;

        int actualSum = Calculator.Subtract(a,b);
        Assert.AreEqual(result, actualSum);
    }
}
public class MultiplyTests
{
    [TestMethod]
    public void TestMethod11()
    {
        int a=3;
        int b=5;
        int result = 15;

        int actualSum = Calculator.Multiply(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod12()
    {
        int a=-3;
        int b=5;
        int result = -15;

        int actualSum = Calculator.Multiply(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod13()
    {
        int a=0;
        int b=5;
        int result = 0;

        int actualSum = Calculator.Multiply(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod14()
    {
        int a=-5;
        int b=-3;
        int result = 15;

        int actualSum = Calculator.Multiply(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod15()
    {
        int a=0;
        int b=0;
        int result = 0;

        int actualSum = Calculator.Multiply(a,b);
        Assert.AreEqual(result, actualSum);
    }
}
public class DivideTests
{
    [TestMethod]
    public void TestMethod16()
    {
        int a=8;
        int b=2;
        int result = 4;

        int actualSum = Calculator.Divide(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod17()
    {
        int a=-8;
        int b=2;
        int result = -4;

        int actualSum = Calculator.Divide(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod18()
    {
        int a=0;
        int b=2;
        int result = 0;

        int actualSum = Calculator.Divide(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod19()
    {
        int a=-8;
        int b=-2;
        int result = 4;

        int actualSum = Calculator.Divide(a,b);
        Assert.AreEqual(result, actualSum);
    }
    public void TestMethod20()
    {
        int a=0;
        int b=0;
        int result = 0;

        int actualSum = Calculator.Divide(a,b);
        Assert.AreEqual(result, actualSum);
    }
}
}