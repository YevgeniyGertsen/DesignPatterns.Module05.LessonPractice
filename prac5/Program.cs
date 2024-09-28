using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{
    public class Invoice : IDocumnet
    {
        public void Open()
        {
            Console.WriteLine("Invoice open");
        }
    }

    public class InvoiceCreator : DocumentCreator
    {
        public override IDocumnet CreateDocument()
        {
            return new Invoice();
        }
    }



    public enum DocType
    {
        Report, Resume, letter, Invoce
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GetDocumnet(DocType.Report).Open();
        }

        public static IDocumnet GetDocumnet(DocType docType)
        {
            DocumentCreator creator = null;
            IDocumnet document = null;

            switch (docType)
            {
                case DocType.Report:
                    creator = new ReportCreator();
                    break;
                case DocType.Resume:
                    creator = new ResumeCreator();
                    break;
                case DocType.letter:
                    creator = new LetterCreator();
                    break;
                case DocType.Invoce:
                    creator = new InvoiceCreator();
                    break;
                default:
                    throw new Exception("Не корректный тип");
            }
            document = creator.CreateDocument();
            return document;
        }

    }
}
