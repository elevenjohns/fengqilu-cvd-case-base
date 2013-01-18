using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;
using System.ComponentModel;
using System.Diagnostics;

namespace FengQiLu.Models
{
    public partial class FengQiLuEntities
    {
        public void ImportCVDFromDataTable(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                var cvd = new CVD();
                foreach (DataColumn col in table.Columns)
                {
                    foreach (PropertyInfo propertyInfo in cvd.GetType().GetProperties())
                    {
                        if (propertyInfo.Name == col.ColumnName)
                        {
                            if (propertyInfo.CanWrite && propertyInfo.Name != "ID")
                            {
                                if (row[col.ColumnName] == null || (string)row[col.ColumnName] == "无数据" || (string)row[col.ColumnName] == "empty")
                                {
                                    propertyInfo.SetValue(cvd, null, null); 
                                }
                                else if (propertyInfo.PropertyType == typeof(Boolean) || propertyInfo.PropertyType == typeof(Boolean?))
                                {
                                    if ((string)row[col.ColumnName] == "0" || string.IsNullOrEmpty((string)row[col.ColumnName]))
                                        propertyInfo.SetValue(cvd, false, null);
                                    else
                                        propertyInfo.SetValue(cvd, true, null);
                                }
                                else
                                {
                                    try
                                    {
                                        TypeConverter typeConverter = TypeDescriptor.GetConverter(propertyInfo.PropertyType);
                                        object val = typeConverter.ConvertFromString((string)row[col.ColumnName]);
                                        propertyInfo.SetValue(cvd, val, null);
                                    }
                                    catch 
                                    {
                                        Debug.WriteLine("Failed to process property: " + propertyInfo.Name + " cell: " + row[col.ColumnName]);
                                    }
                                }
                            }
                        }                        
                    }
                }
                this.CVD.Add(cvd);
            }
            this.SaveChanges();
        }
    }
}