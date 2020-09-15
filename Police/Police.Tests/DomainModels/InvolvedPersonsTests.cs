using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class InvolvedPersonsTests
    {
        private readonly InvolvedPersonsDM involvedPersons = new InvolvedPersonsDM();

        [Fact]
        public void CaseNumber_Valid()
        {
            string test = "Test case number";
            involvedPersons.CaseNumber = test;

            Assert.Equal(test, involvedPersons.CaseNumber);
        }

        [Fact]
        public void ThrowException_When_CaseNumber_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => involvedPersons.CaseNumber = String.Empty);
        }
    }
}
