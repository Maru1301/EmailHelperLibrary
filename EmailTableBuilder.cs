using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHelperLibrary
{
    public class EmailTableBuilder
    {
        /// <summary>
        /// Reference to the email content builder object.
        /// </summary>
        protected readonly IEmailContentBuilder _container;

        public EmailTableBuilder(IEmailContentBuilder container)
        {
            _container = container;
        }

        /// <summary>
        /// Builds the table structure by generating the table head and body using the container object.
        /// </summary>
        public virtual void BuildTable()
        {
            
        }
    }
}
