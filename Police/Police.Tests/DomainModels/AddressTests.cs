using System;
using System.Collections.Generic;
using System.Text;
using Police.Domain.Models;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class AddressTests
    {
        private readonly AddressDM address = new AddressDM();

        [Fact]
        public void Street_Valid()
        {
            string test = "test street";
            address.Street = test;

            Assert.Equal(test, address.Street);
        }

        [Fact]
        public void ExceptionThrown_When_Street_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => address.Street = String.Empty);
        }

        [Fact]
        public void City_Valid()
        {
            string test = "test city";
            address.City = test;

            Assert.Equal(test, address.City);
        }

        [Fact]
        public void ExceptionThrown_When_City_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => address.City = String.Empty);
        }

        [Fact]
        public void State_Valid()
        {
            string test = "test state";
            address.State = test;

            Assert.Equal(test, address.State);
        }

        [Fact]
        public void ExceptionThrown_When_State_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => address.State = String.Empty);
        }

        [Fact]
        public void Zipcode_Valid()
        {
            int test = 12345;
            address.Zipcode = test;

            Assert.Equal(test, address.Zipcode);
        }

        [Fact]
        public void ExceptionThrown_When_Zipcode_Invalid()
        {
            Assert.ThrowsAny<ArgumentException>(() => address.Zipcode = 1);
            Assert.ThrowsAny<ArgumentException>(() => address.Zipcode = 12);
            Assert.ThrowsAny<ArgumentException>(() => address.Zipcode = 123);
            Assert.ThrowsAny<ArgumentException>(() => address.Zipcode = 1234);
            Assert.ThrowsAny<ArgumentException>(() => address.Zipcode = 123456);
        }
    }
}
