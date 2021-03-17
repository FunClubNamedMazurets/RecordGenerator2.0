using Domain.Data.Entities;
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
        
        public void SetInputs(BaseEntity model) 
        {
            Type type = model.GetType();
            //int i = 0;

            foreach (var property in type.GetProperties().OrderBy(x => x.Name))
            {
                if (property.Name != nameof(BaseEntity.Id))
                {
                    object bkmC = property.Name;
                    Bookmark bookmark = document.Bookmarks.get_Item(ref bkmC);

                    range = bookmark.Range;
                    range.Text = property.GetValue(model).ToString();
                }
            }


            //foreach (var property in type.GetProperties().OrderBy(x => x.Name))
            //{
            //    if (property.Name != nameof(BaseEntity.Id))
            //    {
            //        range = bookmarks[i].Range;
            //        range.Text = property.GetValue(model).ToString();

            //        i++;
            //    }
            //}
        }

        public void CloseDocument()
        {
            document.SaveAs2();
            document.Close();
            application.Quit();
            document = null;
            application = null;
        }
    }
}
