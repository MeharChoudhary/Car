using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Xunit;

using Web;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;


// Important: Make sure namespace matches folder structure
namespace Tests.UnitTests.Web.Controllers
{
    public class HomeControllerTests
    {
        
       [Fact]
        public void AlfaRomeo_ReturnsAString()
        {
            // Arrange
            var controller = new CarController();

            // Act
            var result = controller.AlfaRomeo();

            // Assert
	
            var contentResult = Assert.IsAssignableFrom<ContentResult>(result);
            var actual = contentResult.Content;
            var expected = "Alfa Romeo is another sport brand. Returned in text.";
			      Assert.Equal(expected, actual.ToString());
        }
       

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