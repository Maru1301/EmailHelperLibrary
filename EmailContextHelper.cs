using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailHelperLibrary
{
    public class EmailContextHelper
    {
        protected IEmailContentBuilder _container;

        public EmailContextHelper(IEmailContentBuilder container)
        {
            _container = container;
        }

        public string GetEmailContent()
        {
            EmailTableBuilder builder = new EmailTableBuilder(_container);
            builder.BuildTable();
            //append Info
            bool CanParse = bool.TryParse((string)_container.TranInfo["ExistAnnouncement"], out bool result);
            if (CanParse && result == true)
            {
                _container.Info += "此筆交易已完成公告";
            }

            _container.Content = $@"
                <!DOCTYPE html>
                <html dir='ltr' xmlns='http://www.w3.org/1999/xhtml' lang='zh'>
                 <head>
                 </head>
                 <body>
                  <div id='Mail_Content'>
                   <table cellpadding = '5' border='1' style='width: 2000px;'>
                    {_container.Table}
                   </table>
                   <p style='color: red; font-weight: bold'>{_container.Info}</p>
                  </div>
                 </body>
                </html>";

            return _container.Content;
        }
    }
}
