using Bongo.Models.ModelValidations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bongo.Models
{
    [TestFixture]
    public class DateInFutureAttributeTests
    {
        [Test]
        
        public void DateValidator_InputExpectedDateRange_DateValidity()
        {
            DateInFutureAttribute dateInFutureAttribute = new(()=>DateTime.Now);

            var result = dateInFutureAttribute.IsValid(DateTime.Now.AddSeconds(-100));

            Assert.AreEqual(true, result);
        }
    }
}
