using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBOperationTool;

namespace DBOperationTool.Service
{
    public interface IToolService
    {
        /// <summary>
        /// 读取服务器信息xml文件
        /// </summary>
        /// <param name="XmlPath"></param>
        /// <returns></returns>
        List<ServerEntity> ReadXml(string XmlPath);
        /// <summary>
        /// 写入/追加服务器信息xml文件
        /// </summary>
        /// <param name="se"></param>
        void WriteXml(ServerEntity se);
        /// <summary>
        /// 写入服务器信息配置
        /// </summary>
        /// <param name=""></param>
        void WriteConfigText(Dictionary<string,string> dic);
        Dictionary<string,string> ReadConfigText();
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="text"></param>
        void WriteLog(string text);
        /// <summary>
        /// 刷新服务器配置文件信息
        /// </summary>
        void RefreshConfigFile();
    }
}
