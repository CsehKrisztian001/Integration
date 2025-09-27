using Integration;

namespace IntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void DivWithPositive()
        {
            Assert.Equal(4, Program.Div(20, 5));
            Assert.Equal(2, Program.Div(10, 5));
            Assert.Equal((decimal)2.5, Program.Div(5, 2));
        }

        [Fact]
        public void DivWithZero()
        {
            Assert.Null(Program.Div(20, 0));
        }

    }
}