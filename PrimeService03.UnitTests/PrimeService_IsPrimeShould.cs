using PrimeService03.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeService03.UnitTests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf24()
        {
            var result = _primeService.IsPrime(24);

            Assert.False(result, $"24 should not be prime");
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, $"1 should not be prime");
        }

        [Fact]
        public void ReturnFalseGivenValueOf0()
        {
            var result = _primeService.IsPrime(0);

            Assert.False(result, $"0 should not be prime");
        }

        [Fact]
        public void ReturnFalseGivenValueOfMinus3()
        {
            var result = _primeService.IsPrime(-3);

            Assert.False(result, $"-3 should not be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf23()
        {
            var result = _primeService.IsPrime(23);

            Assert.True(result, $"23 should be prime");
        }

    }
}
