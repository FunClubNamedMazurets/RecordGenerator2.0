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
        protected Document document;
        protected Application application;
        protected Range range;
        protected IList<Bookmark> bookmarks;
        protected bool _hasGrid;

        protected string FilePath { get; set; }

        public BaseGenerator(bool hasGrid = false)
        {
            _hasGrid = hasGrid;
        }

        public void ReadDocument()
        {
            application = new Application();
       
            document = application.Documents.Add(FilePath);
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
                if (property.Name != nameof(BaseEntity.Id) && property.PropertyType != typeof(DynamicTable))
                {
                    object bkmC = property.Name;
                    Bookmark bookmark = document.Bookmarks.get_Item(ref bkmC);

                    range = bookmark.Range;
                    range.Text = property.GetValue(model).ToString();
                }
                else if (property.PropertyType == typeof(DynamicTable))
                {
                    if (_hasGrid)
                    {
                        var dynamicTable = (DynamicTable)property.GetValue(model);

                        for (int i = 0; i < dynamicTable.RowsCount; i++)
                        {
                            document.Tables[dynamicTable.TableTag].Rows.Add();
                        }

                        int n = 0, m = 0;
                        foreach (Row row in document.Tables[dynamicTable.TableTag].Rows)
                        {
                            if (row.Index != 1)
                            {
                                m = 0;
                                foreach (Cell cell in row.Cells)
                                {
                                    if (dynamicTable.Data[n, m] != null)
                                        cell.Range.Text = dynamicTable.Data[n, m].ToString();
                                    m++;
                                }
                                n++;
                            }
                        }                      
                    }
                }
            }

            application.Visible = true;
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
