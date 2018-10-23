using DBOperationTool.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBOperationTool
{
    public class LogHelper
    {
        public static IToolService tool = new ToolService();
        public static string currTime
        {
            get
            {
                return DateTime.Now.ToString("yyyyMMdd") ;
            }
        }
        public static string Message;
        public static void Log(string text)
        {
            Message = text;
            StringBuilder sb = new StringBuilder();
            sb.Append(currTime+"\r\n");
            sb.Append(Message+"\r\n");
            tool.WriteLog(sb.ToString());
        }
    }
}
