using System;
using System.Collections;
using System.Collections.Generic;

namespace Interfaces_Intro
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<IDocument> documents = new List<IDocument>();
            documents.Add(new PDFDocument());
            documents.Add(new WordDocument());
            documents.Add(new WordDocument());

            foreach (IDocument currentDoc in documents)
                currentDoc.Print();

            #region Interface with abstract classes

            IList<IDoc> docs = new List<IDoc>();
            docs.Add(new PDFDoc());
            docs.Add(new WordDoc());
    
            foreach (IDoc currentDoc in docs)
            {
                //für allgemeine Fälle -> currentDoc

                if (currentDoc is IPDFDoc pDFDoc)
                {
                    pDFDoc.SetMeta(new object());
                }
                else if (currentDoc is IWord wordFile)
                {
                    wordFile.SaveAsWord97Format("Hallo.doc");
                }
            }

            #endregion


        }
    }

    #region Variante 1 mit Interfaces
    public interface IDocument
    {
        int Id { get; set; }
        string Title { get; set; }   
        string Description { get; set; }

        DateTime CreatedAt { get; set; }
        string  CreatedBy { get; set; }

        void Print();
    }

    public interface IPDFDocument : IDocument
    {
        void SetPDFMeta(object obj);
    }

    public class PDFDocument : IPDFDocument
    {
        //ctor + tab + tab 
        public PDFDocument()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public void Print()
        {
            Console.WriteLine($"Print {Title}");
        }


        public void SetPDFMeta(object obj)
        {
            //... 
        }
    }

    public class WordDocument : IDocument
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }

        public void Print()
        {
            Console.WriteLine($"Print {Title}");
        }
    }
    #endregion

    #region Variante 2 mit abstract 
    public interface IDoc
    {
        void Print();
        void SaveAndClose();
        IList<IDoc> ShowLastOpenedDocs();
    }

    public abstract class DocBase : IDoc
    {
        public abstract void Print();
        public abstract void SaveAndClose();
        public abstract IList<IDoc> ShowLastOpenedDocs();

        public virtual void CommonCodes()
        {
            Console.WriteLine("Wenn implementierung benötigt wird");
        }
    }


    public interface IPDFDoc : IDoc
    {
        void SetMeta(object any);
    }

    public interface IWord : IDoc
    {
        void SetWordDocMeta(object any);
        void SaveAsWord97Format(string filename);
    }
    
    
    public class PDFDoc : DocBase, IPDFDoc
    {
        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void SaveAndClose()
        {
            throw new NotImplementedException();
        }

       

        public override IList<IDoc> ShowLastOpenedDocs()
        {
            throw new NotImplementedException();
        }

        public void SetMeta(object any)
        {
            throw new NotImplementedException();
        }
    }

    public class WordDoc : DocBase, IWord
    {
        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void SaveAndClose()
        {
            throw new NotImplementedException();
        }

        public void SaveAsWord97Format(string filename)
        {
            throw new NotImplementedException();
        }

        public void SetWordDocMeta(object any)
        {
            throw new NotImplementedException();
        }

        public override IList<IDoc> ShowLastOpenedDocs()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Vorsicht bei Designs
    public interface IFile
    {
        void Print();
    }

    public interface IDocFile
    {
        void Print();
    }

    public class TheDocFile : IDocFile, IFile
    {
        void IDocFile.Print()
        {
            throw new NotImplementedException();
        }

        void IFile.Print()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    
}
