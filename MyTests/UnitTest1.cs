using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTests;

using MyClasses;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Class1 instance = new Class1("test1");
        Assert.AreEqual("LOG >>> test1 is the name of the Class1 object",instance.GetLogMessage());
    }

    [TestMethod]
    public void TestMethod2()
    {
        Class1 instance = new Class1("test2");
        Assert.AreEqual(
            "LOG >>> test2 is the name of the Class1 object",
            UseExtensions.GetLogMessageForObject(instance)
        );
    }

    [TestMethod]
    public void TestMethod3()
    {
        Class1 instance = new Class1("test3");
        // this won't work, even though Class1 is ILoggable by virtue of the extension method
        ILoggable? loggable = instance as ILoggable;
        Assert.IsNull(loggable);
    }
}