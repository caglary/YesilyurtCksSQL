using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace WordExamples


{
    class Program
    {

        static void Main(string[] args)
        {
            string filePath = @"C:\Users\cagla\Desktop\EK-10.docx";
      
            XWPFDocument doc = new XWPFDocument();
            doc.CreateParagraph();
            using (FileStream sw = File.Create("fileformat.docx"))
            {
                doc.Write(sw);
            }

            Console.ReadLine();


        }
     
    }
}
