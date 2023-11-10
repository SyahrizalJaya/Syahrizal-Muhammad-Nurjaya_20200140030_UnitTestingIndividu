using System;
using NUnit.Framework;

public class Program
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new ArgumentException("Cannot divide by zero");
        }

        return num1 / num2;
    }
}

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_TwoNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Add(5, 3);
        Assert.AreEqual(8, result);
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Multiply(5, 3);
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Divide_TwoNumbers_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Divide(6, 2);
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Calculator calculator = new Calculator();
        Assert.Throws<ArgumentException>(() => calculator.Divide(5, 0));
    }
}