using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IDocumnet
    {
        void Open();
    }
    public class Report : IDocumnet
    {
        public void Open()
        {
            //500
            Console.WriteLine("Report open!");
        }
    }
    public class Resume : IDocumnet
    {
        public void Open()
        {
            Console.WriteLine("Resume open!");
        }
    }
    public class Letter : IDocumnet
    {
        public void Open()
        {
            Console.WriteLine("Letter open!");
        }
    }


    public abstract class DocumentCreator
    {
        public abstract IDocumnet CreateDocument();
    }
    public class ReportCreator : DocumentCreator
    {
        public override IDocumnet CreateDocument()
        {
            return new Report();
        }
    }
    public class ResumeCreator : DocumentCreator
    {
        public override IDocumnet CreateDocument()
        {
            return new Resume();
        }
    }
    public class LetterCreator : DocumentCreator
    {
        public override IDocumnet CreateDocument()
        {
            return new Letter();
        }
    }

}
