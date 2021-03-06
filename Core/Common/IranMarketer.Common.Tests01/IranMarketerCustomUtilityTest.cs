using System.Reflection;
using Pikad.Framework.UnitOfWork;
// <copyright file="IranMarketerCustomUtilityTest.cs">Copyright ©  2017</copyright>

using System;
using IranMarketer.Common.Utility;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IranMarketer.Common.Utility.Tests
{
    [TestClass]
    [PexClass(typeof(IranMarketerCustomUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IranMarketerCustomUtilityTest
    {

        [PexMethod]
        public bool IsValidEmail(string strIn)
        {
            bool result = IranMarketerCustomUtility.IsValidEmail(strIn);
            return result;

            // TODO: add assertions to method IranMarketerCustomUtilityTest.IsValidEmail(String)
        }

    }
}
