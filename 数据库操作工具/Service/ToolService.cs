using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using DBOperationTool;
using DBOperationTool.Service;
using System.IO;
using System.Windows.Forms;

namespace DBOperationTool.Service
{

    public class ToolService : IToolService
    {
        //加载服务器列表
        public static string serverFilePath = Application.StartupPath + @"\serverlist.xml";
        public static string ConfigPath = Application.StartupPath + @"\DBSaveConfig.txt";
        public static string LogPath = Application.StartupPath + @"\Log\";

        public ToolService() { }
        /// <summary>
        /// 读取服务器配置文件
        /// </summary>
        /// <param name="serverFilePath"></param>
        public List<ServerEntity> ReadXml(string serverFilePath)
        {
            List<ServerEntity> seList = new List<ServerEntity>();
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings setting = new XmlReaderSettings();
            setting.IgnoreComments = true;
            xmlDoc.Load(serverFilePath);
            XmlNode root = xmlDoc.SelectSingleNode("serverlist");
            XmlNodeList xn1 = root.ChildNodes;
            //位置在info中
            foreach (XmlNode item in xn1)
            {
                ServerEntity se = new ServerEntity();
                XmlElement xe = (XmlElement)item;
                se.Name = xe.GetAttribute("name");
                //位置在server中
                XmlNodeList xn = item.ChildNodes;
                se.ServerIP = xn[0].InnerText;
                se.ServerPort = xn[1].InnerText;
                se.ServerUserName = xn[2].InnerText;
                se.ServerPassword = xn[3].InnerText;
                XmlNodeList xn2 = xn[4].ChildNodes;
                foreach (XmlNode child in xn2)
                {
                    se.ServerDBName.Add(child.InnerText);
                }

                seList.Add(se);
            }
            return seList;
        }



        public void WriteXml(ServerEntity se)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement servers = null;
            if (File.Exists(serverFilePath))
            {
                doc.Load(serverFilePath);
                servers = doc.DocumentElement;
            }
            else
            {
                //创建声明
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "gb2312", null);
                doc.AppendChild(dec);
                //创建根节点
                servers = doc.CreateElement("serverlist");
                doc.AppendChild(servers);
            }

            XmlElement childServer = doc.CreateElement("info");
            childServer.SetAttribute("name", se.Name);
            servers.AppendChild(childServer);

            XmlElement inner1 = doc.CreateElement("serverIP");
            inner1.InnerText = se.ServerIP;
            childServer.AppendChild(inner1);

            XmlElement inner2 = doc.CreateElement("serverPort");
            inner2.InnerText = se.ServerPort;
            childServer.AppendChild(inner2);

            XmlElement inner3 = doc.CreateElement("serverUserName");
            inner3.InnerText = se.ServerUserName;
            childServer.AppendChild(inner3);

            XmlElement inner4 = doc.CreateElement("serverPassword");
            inner4.InnerText = se.ServerPassword;
            childServer.AppendChild(inner4);

            XmlElement inner5 = doc.CreateElement("serverCatalog");
            childServer.AppendChild(inner5);

            foreach (string item in se.ServerDBName)
            {
                XmlElement inner6 = doc.CreateElement("List");
                inner6.InnerText = item;
                inner5.AppendChild(inner6);
            }


            doc.Save(serverFilePath);

        }
        public void WriteConfigText(Dictionary<string, string> dic)
        {
            FileInfo fileInfo = new FileInfo(ConfigPath);
            if (File.Exists(ConfigPath))
            {
                fileInfo.Delete();
            }
            FileStream fs = fileInfo.Create();
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> item in dic)
            {
                sb.Append(item.Key + "|" + item.Value + "\n");
            }
            byte[] data = System.Text.Encoding.Default.GetBytes(sb.ToString());
            fs.Write(data, 0, data.Length);
            fs.Close();
        }
        public Dictionary<string, string> ReadConfigText()
        {
            Dictionary<string, string> tempDic = new Dictionary<string, string>();
            if (File.Exists(ConfigPath))
            {
                FileStream fs = new FileStream(ConfigPath, FileMode.Open);
                int Count = 1024; //每次读取1024个字节
                int offset = 0; //偏移量
                byte[] bytes = new byte[Count];
                byte[] FileByte = new byte[2048];
                int readByteCount = 0;
                while ((readByteCount = fs.Read(bytes, 0, Count)) > 0)
                {
                    bytes.CopyTo(FileByte, offset);
                    offset += readByteCount;
                    bytes = new byte[Count];
                }
                fs.Close();
                string info = System.Text.Encoding.Default.GetString(FileByte).Replace("\0", "");
                string[] temp = info.Split('\n');
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i].Length > 0)
                    {
                        string[] ConfigTemp = temp[i].Split('|');
                        tempDic.Add(ConfigTemp[0], ConfigTemp[1]);
                    }
                }
            }
            return tempDic;
        }
        public void WriteLog(string text)
        {
            string tempPath = LogPath + "Log" + LogHelper.currTime + ".txt";
            FileInfo fileInfo = new FileInfo(tempPath);

            //if (File.Exists(ConfigPath))
            //{
            //    fileInfo.Delete();
            //}
            FileStream fs = null;
            if (!File.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }
            if (!File.Exists(tempPath))
            {
                fs = fileInfo.Create();
            }
            else
            {
                fs = fileInfo.Open(FileMode.Append, FileAccess.Write);
            }
            byte[] data = System.Text.Encoding.Default.GetBytes(text);
            fs.Write(data, 0, data.Length);
            fs.Close();
        }

        public void RefreshConfigFile()
        {
            IDBInfoService service = new DBInfoService();
            List<ServerEntity> OldServerList = new List<ServerEntity>();
            List<string> DBName = new List<string>();
            OldServerList.Clear();
            if (File.Exists(serverFilePath))
            {
                OldServerList = ReadXml(serverFilePath);
                FileInfo fileInfo = new FileInfo(serverFilePath);
                fileInfo.Delete();
                foreach (ServerEntity item in OldServerList)
                {
                    DBName.Clear();
                    DBName = service.SearchDBName(item);
                    if (DBName.Count != 0)
                    {
                        item.ServerDBName = new List<string>(DBName);
                        WriteXml(item);
                    }
                }
            }
        }
    }
}
