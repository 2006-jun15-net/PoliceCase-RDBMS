using System;
using System.Collections.Generic;
using System.Text;
using Police.Domain.Models;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class CaseFolderTests
    {
        private readonly CaseFolderDM caseFolder = new CaseFolderDM();

        [Fact]
        public void CaseNumber_Valid()
        {
            string test = "Test case number";
            caseFolder.CaseNumber = test;

            Assert.Equal(test, caseFolder.CaseNumber);
        }

        [Fact]
        public void ThrowException_When_CaseNumber_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => caseFolder.CaseNumber = String.Empty);
        }

        [Fact]
        public void Detective_Valid()
        {
            string test = "Test detective";
            caseFolder.Detective = test;

            Assert.Equal(test, caseFolder.Detective);
        }

        [Fact]
        public void ThrowException_When_Detective_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => caseFolder.Detective = String.Empty);
        }

        [Fact]
        public void PoliceReportID_Valid()
        {
            string test = "Test report";
            caseFolder.PoliceReportID = test;

            Assert.Equal(test, caseFolder.PoliceReportID);
        }

        [Fact]
        public void ThrowException_When_PoliceReportID_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => caseFolder.PoliceReportID = String.Empty);
        }

        [Fact]
        public void ArrestingReportID_Valid()
        {
            string test = "Test report";
            caseFolder.ArrestingReportID = test;

            Assert.Equal(test, caseFolder.ArrestingReportID);
        }

        [Fact]
        public void ThrowException_When_ArrestingReportID_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => caseFolder.ArrestingReportID = String.Empty);
        }
    }
}
