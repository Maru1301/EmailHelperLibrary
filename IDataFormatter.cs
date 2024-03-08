using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHelperLibrary
{
    // Interface for Data formatting
    public interface IDataFormatter
    {
        // Method for formatting a specific value based on its key
        string FormatValue(string key, object value);
    }

}
