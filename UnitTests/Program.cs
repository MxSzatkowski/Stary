using NUnit.Framework;
using FakeItEasy;
using Wrapper;
using NUnit.Framework.Internal.Execution;
using Test;
using ExecFile;
using System.Runtime.InteropServices;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        public const string DllPath = @"..\..\..\..\x64\Debug\CPlusPlus.dll";

        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers();


        [Test]
        public void UseAddNumber_return30()
        {
            var wrapperContext = new CPlusPlusWraper();

            var c = 30;

            var result = wrapperContext.UseAddNumbers();

            Assert.That(result, Is.EqualTo(c));
        }

    }
}
