
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab_9_4
{

    class FileWriter
    {
        public void CreateHTML(StringBuilder htmlText)
        {
            File.WriteAllText("C:\\Users\\jair_\\OneDrive\\Documents\\myHTML.html", htmlText.ToString());
        }
    }

    class HTML
    {
        static void Main(string[] args)
        {
            FileWriter fileWriter = new FileWriter();


            StringBuilder htmlText = new StringBuilder();
            string bOpen = "<body>";
            string bClose = "</body>";
            string hOpen = "<h1>";
            string hClose = "</h1>";
            string ulOpen = "<ul>";
            string ulClose = "</ul>";
            string liOpen = "<li>";
            string liClose = "</li>";
            string tOpen = "<title> Lab_9_4 Creating HTML with C#";
            string tClose = "</title>";
            Console.WriteLine("Enter text for HTML header");
            
            string typeWriterH = Console.ReadLine();
            Console.WriteLine("Enter an item");
            string typeWriterL1 = Console.ReadLine();
            Console.WriteLine("Enter an item");
            string typeWriterL2 = Console.ReadLine();
            Console.WriteLine("Enter an item");
            string typeWriterL3 = Console.ReadLine();


            htmlText.Append(bOpen);
            htmlText.Append(hOpen);
            htmlText.Append(tOpen);
            htmlText.Append(tClose);
            htmlText.Append(typeWriterH);
            htmlText.Append(hClose);
            htmlText.Append(ulOpen);
            htmlText.Append(liOpen);
            htmlText.Append(typeWriterL1);
            htmlText.Append(liClose);
            htmlText.Append(liOpen);
            htmlText.Append(typeWriterL2);
            htmlText.Append(liClose);
            htmlText.Append(liOpen);
            htmlText.Append(typeWriterL3);
            htmlText.Append(liClose);
            htmlText.Append(ulClose);
            htmlText.Append(bClose);
            fileWriter.CreateHTML(htmlText);



        }
    }
}