using NUnit.Framework;
using System;
using System.IO;

namespace FileMoverTest
{
    public class Tests
    {
        string dest = @"C:\BANCSRC";
        FileMover move;
        [SetUp]
        public void Setup()
        {
            move = new FileMover();
        }

        [Test]
        public void Test1()
        {
            string testFile = File.ReadAllText(@"./TestData/File210617.txt");
            var today = DateTime.Today.ToString("yyMMdd");
            testFile = testFile.Replace("{date}", today);
            move.MoveFiles(testFile);
            Assert.IsTrue(File.Exists($"{dest}\\{testFile}"));
        }

        [TearDown]
        public void TearDown()
        {
            File.Delete(@"C:\\BANCSRC\\File210617.txt");
        }
    }
}