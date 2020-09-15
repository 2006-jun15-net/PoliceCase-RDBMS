using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class OfficerTests
    {
        private readonly OfficerDM officer = new OfficerDM();

        [Fact]
        public void FirstName_Valid()
        {
            string test = "Test name";
            officer.FirstName = test;

            Assert.Equal(test, officer.FirstName);
        }

        [Fact]
        public void ThrowException_When_FirstName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => officer.FirstName = String.Empty);
        }

        [Fact]
        public void LastName_Valid()
        {
            string test = "Test name";
            officer.LastName = test;

            Assert.Equal(test, officer.LastName);
        }

        [Fact]
        public void ThrowException_When_LastName_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => officer.LastName = String.Empty);
        }

        [Fact]
        public void BadgeNumber_Valid()
        {
            string test = "123";
            officer.BadgeNumber = test;

            Assert.Equal(test, officer.BadgeNumber);
        }

        [Theory]
        [InlineData("")]
        [InlineData("abc")]
        [InlineData("1234")]
        [InlineData("12")]
        public void ThrowException_When_BadgeNumber_Invalid(string badgeNumber)
        {
            Assert.ThrowsAny<ArgumentException>(() => officer.BadgeNumber = badgeNumber);
        }

        [Theory]
        [InlineData("Chief")]
        [InlineData("Detective")]
        [InlineData("Examiner")]
        [InlineData("Street Cop")]
        public void Rank_Valid(string rank)
        {
            officer.Rank = rank;

            Assert.Equal(rank, officer.Rank);
        }

        [Theory]
        [InlineData("")]
        [InlineData("test rank")]
        public void ThrowException_When_Rank_Invalid(string rank)
        {
            Assert.ThrowsAny<ArgumentException>(() => officer.Rank = rank);
        }
    }
}
