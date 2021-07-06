using System;
using Xunit;
using Session23;

namespace Session23.tests {
    public class FibonacciseriesTest {

        private FibonacciSeriesClass CreateDefaultSUT() {
            //sut = system under test
            var sut = new FibonacciSeriesClass();
            return sut;
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(90)]

        public void CalculateTotalValue_InvalidVATPercIsGiven_ThrowsArgumentException(long n) {
            //Arrange
            var sut = CreateDefaultSUT();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(5, 5)]
        public void CalculateFidonacci_TotalValue124IsGivenWith24VATPerc_ReturnsExceptionbig(long n, long expected) {
            //Arrange
            var sut = CreateDefaultSUT();
            

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
