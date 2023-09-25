using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using UniTest;

namespace UniTestExe
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExist(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExist(@"C:\Regedit.exe");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowArgumentNullException()
        {
            FileProcess fp = new FileProcess();

            fp.FileExist(@"");
    
        }

        ////Another technique for Try Cath
        //[TestMethod]
        //public void FileNameNullOrEmpty_ThrowArgumentNullException_UsingTryCath()
        //{
        //    FileProcess fp = new FileProcess();

        //    try
        //    {
        //        fp.FileExist("test");
        //    }
        //    catch (ArgumentException)
        //    {
        //        //the test was a Sucess.
        //        return;
        //    }

        //    Assert.Fail("Fail exepected");
        //}

    }
}