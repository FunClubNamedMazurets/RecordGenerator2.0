using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generators
{
    public abstract class BaseGenerator
    {
        protected static string source;        
        protected Document document;
        protected Application application;
        protected Range range;
        protected IList<Bookmark> bookmarks;

        protected string pathForSave { get; set; }

        public BaseGenerator(string path)
        {
            pathForSave = path;        
        }

        public void ReadDocument() 
        {
            application = new Application();
            application.Visible = true;

            document = application.Documents.Add(source);
            document.Activate();
            bookmarks = new List<Bookmark>();
            foreach (Bookmark mark in document.Bookmarks)
            {
                bookmarks.Add(mark);
            }        
        }

        public void CloseDocument()
        {
            document.SaveAs2();
            document.Close();
            application.Quit();
            document = null;
        }
    }
}
