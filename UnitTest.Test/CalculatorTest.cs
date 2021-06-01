using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.App;
using Xunit;

namespace UnitTest.Test
{
    public class CalculatorTest
    {

        public Calculator calculator { get; set; }
        public CalculatorTest()
        {
            this.calculator = new Calculator();
        }


        [Fact]
        public void AddTest()
        {
            ////Arrange
            //int a = 5;
            //int b = 20;

            //var calculator = new Calculator();

            ////Act
            //var total = calculator.Add(a, b);

            ////Assert
            ////Assert.Equal<int>(25, total);
            //Assert.NotEqual<int>(25, total);

            var names = new List<string>() { "Eymen", "Burak", "Vural" };

            Assert.Contains(names, x => x == "Eymen");

            //Assert.Contains("Eymen", "Eymen Burak");
            //Assert.DoesNotContain("Eymen", "Eymen Burak");

            //Assert.True(5 > 7);
            //Assert.False(5 > 7);

            //Assert.True("".GetType() == typeof(string));

            var regex = "^dog";
            //Assert.Matches(regex, "dog cat");
            //Assert.Matches(regex, "catdog cat");
            //Assert.DoesNotMatch(regex, "catdog cat");

            //Assert.StartsWith("Eym", "Eymen");
            //Assert.EndsWith("en", "Eymen");

            //Assert.Empty(new List<string>());
            //Assert.Empty(new List<string>() {"Eymen" });
            //Assert.NotEmpty(new List<string>() {"Eymen" });


            //Assert.InRange(10, 2, 20);
            //Assert.NotInRange(10, 2, 20);

            //Assert.Single(new List<string>() { "Eymen", "Burak" });
            //Assert.Single<int>(new List<int>() {1,3,4});

            //Assert.IsType<int>("Eymen");
            //Assert.IsNotType<int>("Eymen");

            //Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());
            //Assert.IsAssignableFrom<object>(2);

            //string value = "";
            ////Assert.Null(value);
            //Assert.NotNull(value);

            //Assert.Equal<int>(2, 3);
        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(10, 2, 12)]
        public void Add_SimpleValues_ReturnTotalValue(int a, int b, int expectedTotal)
        {

            var actualTotal = calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        } 
        
        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(10, 0, 1)]
        public void Add_ZeroValues_ReturnZeroValue(int a, int b, int expectedTotal)
        {

            var actualTotal = calculator.Add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
