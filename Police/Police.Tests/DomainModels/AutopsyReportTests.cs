using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class AutopsyReportTests
    {
        private readonly AutopsyReportDM autopsyReport = new AutopsyReportDM();

        [Fact]
        public void ID_Valid()
        {
            string test = "Test ID";
            autopsyReport.ID = test;

            Assert.Equal(test, autopsyReport.ID);
        }

        [Fact]
        public void ThrowException_When_ID_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => autopsyReport.ID = String.Empty);
        }

        [Fact]
        public void MannerOfDeath_Valid()
        {
            string test = "Test input";
            autopsyReport.MannerOfDeath = test;

            Assert.Equal(test, autopsyReport.MannerOfDeath);
        }

        [Fact]
        public void ThrowException_When_MannerOfDeath_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => autopsyReport.MannerOfDeath = String.Empty);
        }

        [Fact]
        public void CauseOfDeath_Valid()
        {
            string test = "Test death";
            autopsyReport.CauseOfDeath = test;

            Assert.Equal(test, autopsyReport.CauseOfDeath);
        }

        [Fact]
        public void ThrowException_When_CauseOfDeath_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => autopsyReport.CauseOfDeath = String.Empty);
        }

        [Fact]
        public void Examiner_Valid()
        {
            string test = "Test examiner";
            autopsyReport.Examiner = test;

            Assert.Equal(test, autopsyReport.Examiner);
        }

        [Fact]
        public void ThrowException_When_Examiner_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => autopsyReport.Examiner = String.Empty);
        }

        [Fact]
        public void CaseNumber_Valid()
        {
            string test = "Test case number";
            autopsyReport.CaseNumber = test;

            Assert.Equal(test, autopsyReport.CaseNumber);
        }

        [Fact]
        public void ThrowException_When_CaseNumber_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => autopsyReport.CaseNumber = String.Empty);
        }
    }
}
