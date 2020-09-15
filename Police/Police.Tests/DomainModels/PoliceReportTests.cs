using Police.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Police.Tests.DomainModels
{
    public class PoliceReportTests
    {
        private readonly PoliceReportDM policeReport = new PoliceReportDM();

        [Fact]
        public void ID_Valid()
        {
            string test = "Test ID";
            policeReport.ID = test;

            Assert.Equal(test, policeReport.ID);
        }

        [Fact]
        public void ThrowException_When_ID_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => policeReport.ID = String.Empty);
        }

        [Fact]
        public void Narrative_Valid()
        {
            string test = "Test narrative";
            policeReport.Narrative = test;

            Assert.Equal(test, policeReport.Narrative);
        }

        [Fact]
        public void ThrowException_When_Narrative_Empty()
        {
            Assert.ThrowsAny<ArgumentException>(() => policeReport.Narrative = String.Empty);
        }
    }
}
