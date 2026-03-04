using GithubActionsLab;
namespace GithubActionsLab;

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Alyassiri()
    {
        Assert.AreEqual(-1, Program.Subtract("1", "2"));
        Assert.AreEqual(1, Program.Subtract("3", "2"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Alyassiri()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
    }

    [TestMethod]
    public void Subtract_Null_Alyassiri()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Alyassiri()
    {
        Assert.AreEqual(2, Program.Multiply("1", "2"));
        Assert.AreEqual(6, Program.Multiply("3", "2"));
        Assert.AreEqual(35, Program.Multiply("5", "7"));
    }

    [TestMethod]
    public void Multiply_Invalid_Alyassiri()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
    }

    [TestMethod]
    public void Multiply_Null_Alyassiri()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Alyassiri()
    {
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
        Assert.AreEqual(1.5, Program.Divide("3", "2"));
        Assert.AreEqual(2, Program.Divide("10", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Alyassiri()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
    }

    [TestMethod]
    public void Divide_Null_Alyassiri()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
    }
}

[TestClass]
public class PowerTests
{
    [TestMethod]
    public void Power_Valid_Alyassiri()
    {
        Assert.AreEqual(1, Program.Power("1", "2"));
        Assert.AreEqual(9, Program.Power("3", "2"));
        Assert.AreEqual(32, Program.Power("2", "5"));
    }

    [TestMethod]
    public void Power_Invalid_Alyassiri()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
    }

    [TestMethod]
    public void Power_Null_Alyassiri()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
    }
}