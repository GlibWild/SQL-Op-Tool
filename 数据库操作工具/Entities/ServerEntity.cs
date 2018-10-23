using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBOperationTool.Entities;

namespace DBOperationTool
{
   public class ServerEntity
    {
        /**
* 数据库连接字符串 "Server=" + user.txt_IPAddress + "," + user.port.ToString() + "; UID=cortoi_pt;PWD=cortoi_pt;Initial Catalog=CortoiBasicV5_2;" 表名carinfo
**/
        public ServerEntity()
        {
            Field = new List<FieldProperties>();
            ServerTBName = new List<string>();
            ServerDBName = new List<string>();
        }

        /// <summary>
        /// 服务器名称
        /// </summary>
        public string Name { get; set; }
       /// <summary>
       /// 服务器IP地址
       /// </summary>
       public string ServerIP { get; set; }
       /// <summary>
       /// 服务器端口号
       /// </summary>
       public string ServerPort { get; set; }
       /// <summary>
       /// 服务器登录用户名
       /// </summary>
       public string ServerUserName { get; set; }
       /// <summary>
       /// 服务器登录密码
       /// </summary>
       public string ServerPassword { get; set; }
       /// <summary>
       /// 数据库库名
       /// </summary>
       public List<string> ServerDBName { get; set; }
        /// <summary>
        /// 数据库表名
        /// </summary>
        public List<string> ServerTBName { get; set; }
        /// <summary>
        /// 字段属性
        /// </summary>
        public List<FieldProperties> Field { get; set; }
        /// <summary>
        /// 深复制
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public static ServerEntity clone(object tag)
        {
            ServerEntity se = (ServerEntity)tag;
            ServerEntity temp = new ServerEntity();
            temp.Name = se.Name;
            temp.ServerIP = se.ServerIP;
            temp.ServerPassword = se.ServerPassword;
            temp.ServerPort = se.ServerPort;
            temp.ServerUserName = se.ServerUserName;
            return temp;
        }
    }
}
