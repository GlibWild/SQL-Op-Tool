using DBOperationTool.Dao;
using DBOperationTool.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace DBOperationTool.Service
{
    public class DBInfoService : IDBInfoService
    {
        IDBInfoDao dao = new DBInfoDao();
        public string AddTableField(List<ServerEntity> ServerList)
        {
            return dao.AddTableField(ServerList);
        }

        public string CreateDatabase(List<ServerEntity> serverList)
        {
            return dao.CreateDatabase(serverList);
        }
        public string DropDatabase(List<ServerEntity> ServerList)
        {
            return dao.DropDatabase(ServerList);
        }
        public string CreateTable(List<ServerEntity> serverList)
        {
            return dao.CreateTable(serverList);
        }

        public string DropTable(List<ServerEntity> ServerList)
        {
            return dao.DropTable(ServerList);
        }

        public List<string> SearchDBName(ServerEntity se)
        {
            return dao.SearchDBName(se);
        }

        public List<ServerEntity> SearchFieldProperties(List<ServerEntity> ServerList)
        {
            List<ServerEntity> temp = dao.SearchFieldProperties(ServerList);
            //DealProperties(temp);
            return temp;
        }
        public string TruncateTable(List<ServerEntity> ServerList)
        {
            return dao.TruncateTable(ServerList);
        }

        /// <summary>
        /// 更新字段类型
        /// </summary>
        /// <param name="ServerList"></param>        
        public string AlertFieldType(List<ServerEntity> ServerList)
        {
            return dao.AlertFieldType(ServerList);
        }
        public string ExecuteSQL(List<ServerEntity> ServerList, string sql)
        {
            return dao.ExecuteSQL(ServerList, sql);
        }

        public string DeleteField(List<ServerEntity> serverList)
        {
            return dao.DeleteField(serverList);
        }

        /// <summary>
        /// 执行数据导出
        /// </summary>
        /// <param name="serverList"></param>
        /// <param name="sql"></param>
        /// <param name="exportFile"></param>
        /// <returns></returns>
        public string ExecuteSQL_ExportData(List<ServerEntity> serverList, string sql, string exportFile)
        {
            if (serverList.Count == 1)
            {
                int count = 10000;
                while (count == 10000)
                {

                }
            }
            else
            {

            }
            return "";
            //foreach (ServerEntity item in serverList)
            //{
            //    int pageNum = 0;
            //    int pageCount = 10000;
            //    if (pageNum == 0)
            //    {
            //        DataTable dt = dao.ExecuteSQL_ExportData(item,sql,pageNum*pageCount,)
            //    }
            //}



        }
    }
}
