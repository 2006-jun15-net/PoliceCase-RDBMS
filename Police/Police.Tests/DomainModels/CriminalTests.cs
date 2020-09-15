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

        [Fact]
        public void Sex_Valid()
        {
            string test = "Test name";
            criminal.Sex = test;

            Assert.Equal(test, criminal.Sex);
        }

        [Fact]
        public void ThrowException_When_Sex_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => criminal.Sex = String.Empty);
        }
    }
}
