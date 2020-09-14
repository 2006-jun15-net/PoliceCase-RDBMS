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
        public void Street_Exception_WhenEmpty()
        {
            Assert.ThrowsAny<ArgumentException>(() => address.Street = String.Empty);
        }
    }
}
