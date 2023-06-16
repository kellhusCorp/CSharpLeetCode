using NUnit.Framework;

namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest1472_DesignBrowserHistory
{
    [Test]
    public void Test_DesignBrowserHistory()
    {
        var browserHistory = new BrowserHistory("leetcode.com");
        
        browserHistory.Visit("google.com");
        browserHistory.Visit("facebook.com");
        browserHistory.Visit("youtube.com");

        var result  = browserHistory.Back(1);
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo("facebook.com"));
            Assert.That(browserHistory.Back(1), Is.EqualTo("google.com"));
            Assert.That(browserHistory.Forward(1), Is.EqualTo("facebook.com"));
        });

        browserHistory.Visit("linkedin.com");
        browserHistory.Forward(2);
        Assert.Multiple(() =>
        {
            Assert.That(browserHistory.Back(2), Is.EqualTo("google.com"));
            Assert.That(browserHistory.Back(7), Is.EqualTo("leetcode.com"));
        });
    }
}