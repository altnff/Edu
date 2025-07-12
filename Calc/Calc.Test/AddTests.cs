using Calc.Lib;

namespace Calc.Test
{
    public class AddTests
    {
        [Fact]
        public void TestAdd()
        {
            var res = CalcHelper.Add(2, 2);
            
            Assert.Equal(4, res);
        }

        [Theory]
        [MemberData(nameof(GetNumbers))]
        public void TestCoupleAdds(int a, int b, int c)
        {
            Assert.Equal(c, CalcHelper.Add(a, b));
        }

        public static IEnumerable<object[]> GetNumbers()
        {
            yield return new object[] { 1, 2, 3 };
            yield return new object[] { 2, 2, 4 };
            yield return new object[] { 3, 2, 5 };
            yield return new object[] { 6, 5, 11 };
            yield return new object[] { 1, 5, 6 };
        }
    }
}