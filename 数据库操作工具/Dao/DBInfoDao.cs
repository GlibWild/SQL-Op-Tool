using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using System.Data.SqlClient;
using DBOperationTool.Entities;

namespace DBOperationTool.Dao
{
    public class DBInfoDao : IDBInfoDao
    {

        public List<string> SearchDBName(ServerEntity se)
        {
            IDbConnection conn = null;
            List<string> list = new List<string>();
            try
            {
                string con = "Server=" + se.ServerIP + "," + se.ServerPort + "; UID=" + se.ServerUserName + ";PWD=" + se.ServerPassword + ";";
                conn = new SqlConnection(con);
                string sql = "SELECT Name FROM Master..SysDatabases ORDER BY Name ";
                list = conn.Query<string>(sql).ToList();
            }
            catch (Exception ex)
            {
                list.Clear();
                LogHelper.Log(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public string TruncateTable(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0] + ";";
                    conn = new SqlConnection(con);
                    string sql = "truncate Table " + item.ServerTBName[0];
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 删除成功。\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 删除失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }
        public string DropTable(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0] + ";";
                    conn = new SqlConnection(con);
                    string sql = "Drop Table " + item.ServerTBName[0];
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 删除成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 删除失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }

        public string AddTableField(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                string NullValue = null;
                string PrimaryKey = null;
                string SelfPropagation = "";
                if (item.Field[0].FieldValueNull == 1)
                {
                    NullValue = "";
                }
                else
                {
                    NullValue = " not null";
                }
                if (item.Field[0].IsPrimaryKey == 1)
                {
                    PrimaryKey = " primary key";
                }
                else
                {
                    PrimaryKey = "";
                }
                if (item.Field[0].SelfPropagation == 1)
                {
                    SelfPropagation = " IDENTITY";
                }
                else
                {
                    SelfPropagation = "";
                }
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0] + ";";
                    conn = new SqlConnection(con);
                    // alter table tablename add columnname nvarchar(50)
                    string sql = "alter table " + item.ServerTBName[0] + " add " + item.Field[0].FieldName + " " + item.Field[0].FieldType + NullValue + PrimaryKey + SelfPropagation;
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 添加成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 添加失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }

        public List<ServerEntity> SearchFieldProperties(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            List<ServerEntity> list = new List<ServerEntity>(ServerList);
            foreach (ServerEntity item in ServerList)
            {
                FieldProperties temp = new FieldProperties();
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0] + ";";
                    conn = new SqlConnection(con);
                    string sql = "SELECT a.name FieldName,COLUMNPROPERTY(a.id,a.name,'IsIdentity') SelfPropagation, (case when (SELECT count(*) FROM sysobjects WHERE (name in (SELECT name FROM sysindexes WHERE (id = a.id) AND (indid in (SELECT indid FROM sysindexkeys WHERE (id = a.id) AND (colid in (SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name))))))) AND (xtype = 'PK'))>0 then '1' else '0' end) IsPrimaryKey, b.name FieldType, COLUMNPROPERTY(a.id,a.name,'PRECISION') as FieldLength, (case when a.isnullable=1 then '1'else '0' end) FieldValueNull FROM  syscolumns  a  left join systypes b on  a.xtype=b.xusertype inner join sysobjects d on a.id=d.id  and  d.xtype='U' and  d.name<>'dtproperties' left join syscomments e on a.cdefault=e.id left join sys.extended_properties  g on a.id=g.class AND a.colid = g.minor_id  where d.name = @TableName and a.name = @FieldName order by a.id,a.colorder";
                    temp = conn.Query<FieldProperties>(sql, new { TableName = item.ServerTBName[0], FieldName = item.Field[0].FieldName }).Single();
                    item.Field.Add(temp);
                    LogHelper.Log("数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + "查询成功");
                }
                catch (Exception ex)
                {
                    temp.Tag = ex.Message;
                    item.Field.Add(temp);
                    LogHelper.Log("数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + ":" + item.ServerTBName[0] + " 查询失败。\r\n原因：" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return list;
        }

        public string CreateDatabase(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";";
                    conn = new SqlConnection(con);
                    string sql = "Create database "+ item.ServerDBName[0];
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 创建成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 创建失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }

        public string CreateTable(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0] + ";";
                    conn = new SqlConnection(con);
                    string properties = null;
                    foreach (FieldProperties fp in item.Field)
                    {
                        properties +=fp.FieldName+" "+fp.FieldType + " " + (fp.FieldValueNull == 1 ? "" : "not null") + " " + (fp.IsPrimaryKey == 1 ? "primary key" : "") + " " + (fp.SelfPropagation == 1 ? "IDENTITY" : "") + ",";
                    }
                    string text = properties.Substring(0,properties.LastIndexOf(','));
                    string sql = "Create Table "+ item.ServerTBName[0]+ "("+ text + ");";
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0]+":" + item.Field[0].FieldName + " 创建成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0]+":"+item.Field[0].FieldName + " 创建失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }
        public string DropDatabase(List<ServerEntity> ServerList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";";
                    conn = new SqlConnection(con);
                    string sql = "Drop database " + item.ServerDBName[0];
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 删除成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 删除失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }
        public string ExecuteSQL(List<ServerEntity> ServerList,string sql)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in ServerList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0];
                    conn = new SqlConnection(con);
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 执行成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 执行失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }

        public string AlertFieldType(List<ServerEntity> serverList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in serverList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0];
                    conn = new SqlConnection(con);
                    string sql = string.Format("ALTER TABLE {0} ALTER COLUMN {1} {2}",item.ServerTBName[0],item.Field[0].FieldName,item.Field[0].FieldType);
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 修改字段属性成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 修改失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }

        public string DeleteField(List<ServerEntity> serverList)
        {
            IDbConnection conn = null;
            string temp = null;

            foreach (ServerEntity item in serverList)
            {
                try
                {
                    string con = "Server=" + item.ServerIP + "," + item.ServerPort + "; UID=" + item.ServerUserName + ";PWD=" + item.ServerPassword + ";Initial Catalog=" + item.ServerDBName[0];
                    conn = new SqlConnection(con);
                    string sql = string.Format("ALTER TABLE {0} DROP COLUMN {1}", item.ServerTBName[0], item.Field[0].FieldName);
                    conn.Execute(sql);
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 删除字段成功\r\n";
                }
                catch (Exception ex)
                {
                    temp += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + " 删除失败。\r\n原因：" + ex.Message + "\r\n";
                }
                finally
                {
                    conn.Close();
                }
            }
            LogHelper.Log(temp);
            return temp;
        }
    }
}
