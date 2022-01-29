using MatrixMutator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MatrixMutatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<float?> matrix = MatrixLoader.LoadMatrix("matrix.csv");
        }
    }
}