namespace NameThatNumber;

using Xunit;

public class NameThatNumber
{
    public string NameNumber(int input)
    {
        // Insert your solution code here
        return "";
    }

    void RunTest(int input, string expected)
    {
        var actual = NameNumber(input);
        Assert.True(actual == expected);
    }

    [Fact]
    public void TestCaseZero() { RunTest(000000, "zero"); }

    [Fact]
    public void TestCaseOne() { RunTest(000001, "one"); }

    [Fact]
    public void TestCaseFifteen() { RunTest(000015, "fifteen"); }

    [Fact]
    public void TestCaseFortyTwo() { RunTest(000042, "forty two"); }

    [Fact]
    public void TestCaseThreeHundredNinetyNine() { RunTest(000399, "three hundred and ninety nine"); }

    [Fact]
    public void TestCaseOneThousandThreeHundredThirtySeven() { RunTest(001337, "one thousand three hundred and thirty seven"); }

    [Fact]
    public void TestCaseFortyThreeThousandTwoHundredTen() { RunTest(043210, "forty three thousand two hundred and ten"); }

    [Fact]
    public void TestCaseSevenHundredTwelveThousandEightHundredTwentySix() { RunTest(712826, "seven hundred and twelve thousand eight hundred and twenty six"); }
}