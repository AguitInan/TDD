namespace Exercice01.Tests;

using Exercice01.Bibliotheque;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GradingCalculatorTests
{
    private GradingCalculator _calculator;

    [TestInitialize]
    public void Setup()
    {
        _calculator = new GradingCalculator();
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs95AndAttendanceIs90_ShouldReturnA()
    {
        _calculator.Score = 95;
        _calculator.AttendancePercentage = 90;
        var result = _calculator.GetGrade();
        Assert.AreEqual('A', result);
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs85AndAttendanceIs90_ShouldReturnB()
    {
        _calculator.Score = 85;
        _calculator.AttendancePercentage = 90;
        var result = _calculator.GetGrade();
        Assert.AreEqual('B', result);
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs65AndAttendanceIs90_ShouldReturnC()
    {
        _calculator.Score = 65;
        _calculator.AttendancePercentage = 90;
        var result = _calculator.GetGrade();
        Assert.AreEqual('C', result);
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs95AndAttendanceIs65_ShouldReturnB()
    {
        _calculator.Score = 95;
        _calculator.AttendancePercentage = 65;
        var result = _calculator.GetGrade();
        Assert.AreEqual('B', result);
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs95AndAttendanceIs55_ShouldReturnF()
    {
        _calculator.Score = 95;
        _calculator.AttendancePercentage = 55;
        var result = _calculator.GetGrade();
        Assert.AreEqual('F', result);
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs65AndAttendanceIs55_ShouldReturnF()
    {
        _calculator.Score = 65;
        _calculator.AttendancePercentage = 55;
        var result = _calculator.GetGrade();
        Assert.AreEqual('F', result);
    }

    [TestMethod]
    public void GetGrade_WhenScoreIs50AndAttendanceIs90_ShouldReturnF()
    {
        _calculator.Score = 50;
        _calculator.AttendancePercentage = 90;
        var result = _calculator.GetGrade();
        Assert.AreEqual('F', result);
    }

    [TestCleanup]
    public void Cleanup()
    {
        _calculator = null;
    }
}