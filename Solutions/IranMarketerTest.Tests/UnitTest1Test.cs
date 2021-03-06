// <copyright file="UnitTest1Test.cs">Copyright ©  2017</copyright>

using System;
using IranMarketer.Common.Utility.Tests;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IranMarketer.Common.Utility.Tests.Tests
{
    [TestClass]
    [PexClass(typeof(UnitTest1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnitTest1Test
    {

        [PexMethod]
        public void IsValidEmailTest([PexAssumeUnderTest]UnitTest1 target)
        {
            target.IsValidEmailTest();
            // TODO: add assertions to method UnitTest1Test.IsValidEmailTest(UnitTest1)
        }
    }
}
