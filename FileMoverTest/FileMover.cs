using System;
using System.Collections.Generic;
using System.Text;
using FileMoverTest;
using System.IO;

namespace FileMoverTest
{
    class FileMover
    {
        public void MoveFiles(string fileName)
        {
         
            var source = $@"C:\Users\qlwor\source\repos\FileMoverTest\FileMoverTest\TestData\{fileName}";
            var destination = $@"C:\BANCSRC\{fileName}";

            File.Copy(source, destination);      
        }
       
    }
}
