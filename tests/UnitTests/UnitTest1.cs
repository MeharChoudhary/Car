using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void InitialsTest()
        {
            var expected = "P.T.R.T.";
            var name="Peddi Taraka Ravi Teja";
            var actual = Initials(name);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Pulihora Raja","P.R.")]
        [InlineData("Shivaji Rao Gaekwad","S.R.G.")]
        [InlineData("Kolar Gold Fields","K.G.F.")]
        public void IsOdd_WorksWithManyInputs(string name, string exp)
        {
            Assert.Equal(Initials(name),exp);
        }

        public string Initials(string name)
        {
            string[] temp;
            string res="";
            temp=name.Split(" ");
            foreach(String item in temp){
                res+=item.Substring(0,1)+".";
            }
            return res;
        }

    }
}
