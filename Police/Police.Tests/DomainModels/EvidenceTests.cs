using System;
using System.Collections.Generic;
using System.Text;
using Police.Domain.Models;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class EvidenceTests
    {
        private readonly EvidenceDM evidence = new EvidenceDM();

        [Fact]
        public void Name_Valid()
        {
            string test = "Test name";
            evidence.Name = test;

            Assert.Equal(test, evidence.Name);
        }

        [Fact]
        public void ThrowException_When_Name_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => evidence.Name = String.Empty);
        }

        [Fact]
        public void Description_Valid()
        {
            string test = "Test description";
            evidence.Description = test;

            Assert.Equal(test, evidence.Description);
        }

        [Fact]
        public void ThrowException_When_Description_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => evidence.Description = String.Empty);
        }

        [Fact]
        public void CaseNumber_Valid()
        {
            string test = "Test case number";
            evidence.CaseNumber = test;

            Assert.Equal(test, evidence.CaseNumber);
        }

        [Fact]
        public void ThrowException_When_CaseNumber_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => evidence.CaseNumber = String.Empty);
        }
    }
}
