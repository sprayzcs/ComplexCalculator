using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComplexCalculator.Test
{
    [ExcludeFromCodeCoverage]
    class ProgramTests
    {
        [Test]
        public void MainTest()
        {
            Assert.DoesNotThrow(delegate
            {
                Program.Main();
            });
        }
    }
}
