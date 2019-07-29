using System;

namespace SecondTaskPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlBuilder b = new HtmlBuilder();
            b.buildHtml();

            PrintToFile p = new PrintToFile();
            p.WriteToFile(b.buildHtml());
        }
    }
}
