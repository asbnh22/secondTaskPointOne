using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SecondTaskPartOne
{
    class PrintToFile
    {
        public void WriteToFile(string text)
        {
            string FileName = "C:\\Users\\borod\\Documents\\Visual Studio 2017\\Projects\\SecondTaskPartOne\\index.html";

            using (StreamWriter WriteToFile = new StreamWriter(FileName))
            {
                WriteToFile.Write(text);
                WriteToFile.Close();
            }

        }
    }
}
