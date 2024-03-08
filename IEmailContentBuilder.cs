using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHelperLibrary
{
    public interface IEmailContentBuilder
    {
        // Getter and setter properties for table, table head, table body, info, and table head details
        string Content { get; set; }
        string Table { get; set; }
        string TableHead { get; set; }
        string TableBody { get; set; }
        string Info { get; set; }
        Dictionary<string, TableHeadDetail> TableHeadDetailHashtable { get; set; }

        // Dictionary for storing transaction information
        Dictionary<string, object> TranInfo { get; set; }

        string GenerateCustomTableCellValue(string key);
    }

    public class TableHeadDetail
    {
        public string TableHeadName { get; set; }
        public string TableHeadWidth { get; set; }
        public string TableHeadType { get; set; }

        public TableHeadDetail(string tableHeadName, string tableHeadWidth, string tableHeadType)
        {
            TableHeadName = tableHeadName;
            TableHeadWidth = tableHeadWidth;
            TableHeadType = tableHeadType;
        }
    }
}
