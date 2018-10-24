using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicUnitTesting.Test
{
    /// <summary>
    /// Assembly initialize and cleanup methods
    /// </summary>
    [TestClass]
    public class TestInitialization
    {
        

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext tc)
        {
            tc.WriteLine("In the assembly initialize method");
            //TODO: Create resources needed for testing
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            //TODO: Clean up resources used for testing
        }

    }
}
