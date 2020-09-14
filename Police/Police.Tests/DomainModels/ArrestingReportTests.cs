using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class ArrestingReportTests
    {
        private readonly ArrestingReportDM arrestingReport = new ArrestingReportDM();

        [Fact]
        public void ID_Valid()
        {
            string test = "Test ID";
            arrestingReport.ID = test;

            Assert.Equal(test, arrestingReport.ID);
        }

        [Fact]
        public void ThrowException_When_ID_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => arrestingReport.ID = String.Empty);
        }

        [Fact]
        public void ArrestingOfficer_Valid()
        {
            string test = "test badge number";
            arrestingReport.ArrestingOfficer = test;

            Assert.Equal(test, arrestingReport.ArrestingOfficer);
        }

        [Fact]
        public void ThrowException_When_ArrestingOfficer_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => arrestingReport.ArrestingOfficer = String.Empty);
        }
    }
}
