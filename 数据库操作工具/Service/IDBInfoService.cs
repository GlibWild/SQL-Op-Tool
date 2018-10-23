using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBOperationTool.Service
{
    public interface IDBInfoService
    {
        /// <summary>
        /// 查询数据库名
        /// </summary>
        /// <param name="se"></param>
        /// <returns></returns>
        List<string> SearchDBName(ServerEntity se);
        /// <summary>
        /// 删除指定表中数据
        /// </summary>
        /// <param name="ServerList"></param>
        /// <returns></returns>
        string TruncateTable(List<ServerEntity> ServerList);
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="serverList"></param>
        string ExecuteSQL(List<ServerEntity> serverList, string sql);

        /// <summary>
        /// 删除指定表数据+结构
        /// </summary>
        /// <param name="ServerList"></param>
        /// <returns></returns>
        string DropTable(List<ServerEntity> ServerList);
        string ExecuteSQL_ExportData(List<ServerEntity> serverList, string sql, string exportFile);

        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="serverList"></param>
        /// <returns></returns>
        string CreateDatabase(List<ServerEntity> serverList);

        /// <summary>
        /// 向表中新增字段
        /// </summary>
        /// <param name="ServerList"></param>
        /// <returns></returns>
        string AddTableField(List<ServerEntity> ServerList);
        /// <summary>
        /// 查询表字段的属性：包括长度，是否允许为空，是否为主键，是否为自增长
        /// </summary>
        /// <param name="serverList"></param>
        /// <returns></returns>
        List<ServerEntity> SearchFieldProperties(List<ServerEntity> ServerList);
        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="serverList"></param>
        string CreateTable(List<ServerEntity> serverList);
        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="ServerList"></param>
        /// <returns></returns>
        string DropDatabase(List<ServerEntity> ServerList);
        /// <summary>
        /// 修改表字段类型
        /// </summary>
        /// <param name="serverList"></param>
        /// <returns></returns>
        string AlertFieldType(List<ServerEntity> serverList);
        /// <summary>
        /// 删除表字段
        /// </summary>
        /// <param name="serverList"></param>
        /// <returns></returns>
        string DeleteField(List<ServerEntity> serverList);
    }
}
