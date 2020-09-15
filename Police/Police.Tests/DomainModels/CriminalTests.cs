using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class CriminalTests
    {
        private readonly CriminalDM criminal = new CriminalDM();

        [Fact]
        public void FirstName_Valid()
        {
            string test = "Test name";
            criminal.FirstName = test;

            Assert.Equal(test, criminal.FirstName);
        }

        [Fact]
        public void ThrowException_When_FirstName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => criminal.FirstName = String.Empty);
        }

        [Fact]
        public void LastName_Valid()
        {
            string test = "Test name";
            criminal.LastName = test;

            Assert.Equal(test, criminal.LastName);
        }

        [Fact]
        public void ThrowException_When_LastName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => criminal.LastName = String.Empty);
        }

        [Theory]
        [InlineData("Male")]
        [InlineData("Female")]
        [InlineData("Other")]
        public void Sex_Valid(string sex)
        {
            criminal.Sex = sex;
            Assert.Equal(sex, criminal.Sex);
        }

        [Theory]
        [InlineData("")]
        [InlineData("test sex")]
        public void ThrowException_When_Sex_Invalid(string sex)
        {
            Assert.ThrowsAny<ArgumentException>(() => criminal.Sex = sex);
        }
    }
}
