using Domain.Data.Entities;
using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Helpers
{
    public static class FormHelper
    {
        public static void InputsToModel(Form form, BaseEntity model, bool hasGrid = false)
        {
            Type type = model.GetType();

            foreach (var property in type.GetProperties().OrderBy(x => x.Name))
            {
                PropertyInfo piShared = type.GetProperty(property.Name);
                var control = form.Controls.Find(property.Name, true).FirstOrDefault();

                Type type1 = property.PropertyType;
                Type type2 = typeof(DynamicTable);

                if (property.Name == nameof(BaseEntity.Id))
                {
                    if (!string.IsNullOrEmpty(control.Text))
                    {
                        piShared.SetValue(model, control.Text);
                    }
                }
                else if(property.PropertyType == typeof(DynamicTable))
                {
                    if (hasGrid)
                    {
                        var grid = (DataGridView)control;
                        var table = new DynamicTable(grid.Rows.Count, grid.Columns.Count, Convert.ToInt32(grid.Tag));

                        for (int i = 0; i < grid.Rows.Count; i++)
                        {
                            for (int j = 0; j < grid.Columns.Count; j++)
                            {
                                if (grid[j, i].Value != null)
                                {
                                    table.Data[i, j] = grid[j, i].Value.ToString();
                                }
                            }
                        }
                        piShared.SetValue(model, table);
                    }
                }
                else
                {
                    piShared.SetValue(model, control.Text);
                }
            }         
        }
    }
}
