using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class CrimeTests
    {
        private readonly CrimeDM crime = new CrimeDM();

        [Fact]
        public void Classification_Valid()
        {
            string test = "Test classification";
            crime.Classification = test;

            Assert.Equal(test, crime.Classification);
        }

        [Fact]
        public void ThrowException_When_Classification_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => crime.Classification = String.Empty);
        }
    }
}
