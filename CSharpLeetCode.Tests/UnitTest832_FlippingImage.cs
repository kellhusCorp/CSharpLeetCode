namespace CSharpLeetCode.Tests;

[TestFixture]
public class UnitTest832_FlippingImage
{
    [Test]
    public void Test_FlippingImage_FlipAndInvertImage()
    {
        var image = new[]
        {
            new[] { 1, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 0, 0 }
        };

        var result = new FlippingImageSolution().FlipAndInvertImage(image);

        Assert.That(result, Is.EqualTo(new int[3][]
        {
            new[] { 1, 0, 0 },
            new[] { 0, 1, 0 },
            new[] { 1, 1, 1 }
        }));
    }

    [Test]
    [TestCase(new[] { 1, 1, 0 }, new[] { 0, 1, 1 })]
    [TestCase(new[] { 1, 1, 0, 1 }, new[] { 1, 0, 1, 1 })]
    public void Test_FlippingImage_HorizontallyFlipRow(int[] row, int[] expected)
    {
        var result = new FlippingImageSolution().HorizontallyFlipRow(row);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(new[] { 1, 1, 0 }, new[] { 0, 0, 1 })]
    [TestCase(new[] { 0, 0, 0, 0 }, new[] { 1, 1, 1, 1 })]
    public void Test_FlippingImage_InvertRow(int[] row, int[] expected)
    {
        var result = new FlippingImageSolution().InvertRow(row);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(new[] { 1, 1, 0 }, new[] { 1, 0, 0 })]
    [TestCase(new[] { 1, 0, 1 }, new[] { 0, 1, 0 })]
    [TestCase(new[] { 0, 0, 0 }, new[] { 1, 1, 1 })]
    public void Test_FlippingImage_FlipAndInvertRow(int[] row, int[] expected)
    {
        var result = new FlippingImageSolution().FlipAndInvertRow(row);

        Assert.That(result, Is.EqualTo(expected));
    }
}