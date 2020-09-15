using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class VictimTests
    {
        private readonly VictimDM victim = new VictimDM();

        [Fact]
        public void FirstName_Valid()
        {
            string test = "Test name";
            victim.FirstName = test;

            Assert.Equal(test, victim.FirstName);
        }

        [Fact]
        public void ThrowException_When_FirstName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => victim.FirstName = String.Empty);
        }

        [Fact]
        public void LastName_Valid()
        {
            string test = "Test name";
            victim.LastName = test;

            Assert.Equal(test, victim.LastName);
        }

        [Fact]
        public void ThrowException_When_LastName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => victim.LastName = String.Empty);
        }

        [Theory]
        [InlineData("Male")]
        [InlineData("Female")]
        [InlineData("Other")]
        public void Sex_Valid(string sex)
        {
            victim.Sex = sex;
            Assert.Equal(sex, victim.Sex);
        }

        [Theory]
        [InlineData("")]
        [InlineData("test sex")]
        public void ThrowException_When_Sex_Invalid(string sex)
        {
            Assert.ThrowsAny<ArgumentException>(() => victim.Sex = sex);
        }
    }
}
