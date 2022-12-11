using System;
using System.Xml;

namespace Spire.Doc
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\cagla\Desktop\EK-10.docx";
            string readFile = @"C:\Users\cagla\Desktop\Sample.xml";
            ////Load Document
            Document document = new Document();
            document.LoadFromFile(fileName);

            ////Save the Word document as an XML file
            //document.SaveToFile(@"C:\Users\cagla\Desktop\Sample.xml", FileFormat.Xml);

            ////Save it to PDF
            //document.SaveToFile(@"C:\Users\cagla\Desktop\Sample.pdf", FileFormat.PDF);

            ////Launch Document
            //System.Diagnostics.Process.Start(@"C:\Users\cagla\Desktop\Sample.pdf");

            //open form



            //load data

            XmlDocument doc = new XmlDocument();
            doc.Load(readFile);


            XmlElement root = doc.DocumentElement;
            var nodes = root.GetElementsByTagName("item");
            

            foreach (XmlNode node in nodes)
            {
                if (node.Attributes["FieldName"]!=null)
                {
                    var fieldname = node.Attributes["FieldName"].Value;
                    node.Attributes["FieldName"].InnerXml="x";
                   

                }

            }

            ////Save doc file.
            //doc.Save(@"C:\Users\cagla\Desktop\Sample.doc", FileFormat.Doc);

            ////Launching the MS Word file.
            //WordDocViewer(@"C:\Users\cagla\Desktop\Sample.doc");






        }

        private static void WordDocViewer(string v)
        {
            throw new NotImplementedException();
        }
    }
}
