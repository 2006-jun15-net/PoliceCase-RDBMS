using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class WitnessTests
    {
        private readonly WitnessDM witness = new WitnessDM();

        [Fact]
        public void FirstName_Valid()
        {
            string test = "Test name";
            witness.FirstName = test;

            Assert.Equal(test, witness.FirstName);
        }

        [Fact]
        public void ThrowException_When_FirstName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => witness.FirstName = String.Empty);
        }

        [Fact]
        public void LastName_Valid()
        {
            string test = "Test name";
            witness.LastName = test;

            Assert.Equal(test, witness.LastName);
        }

        [Fact]
        public void ThrowException_When_LastName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => witness.LastName = String.Empty);
        }

        [Theory]
        [InlineData("Male")]
        [InlineData("Female")]
        [InlineData("Other")]
        public void Sex_Valid(string sex)
        {
            witness.Sex = sex;
            Assert.Equal(sex, witness.Sex);
        }

        [Theory]
        [InlineData("")]
        [InlineData("test sex")]
        public void ThrowException_When_Sex_Invalid(string sex)
        {
            Assert.ThrowsAny<ArgumentException>(() => witness.Sex = sex);
        }
    }
}
