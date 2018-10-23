using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBOperationTool.UI;
using DevComponents.AdvTree;
using DBOperationTool.Dao;
using DBOperationTool.Service;
using System.IO;

namespace DBOperationTool.Control
{

    public class ControlBase : UserControl
    {
        /// <summary>
        /// 字段类型
        /// </summary>
        public static object[] Type = new object[]{
            "bit",
            "binary(50)",
            "char(50)",
            "decimal",
            "datetime",
            "float",
            "image",
            "int",
            "money",
            "nchar(50)",
            "nvarchar(50)",
            "ntext(50)",
            "numeric",
            "real",
            "smallint",
            "smallmoney",
            "smalldatetime",
            "text(50)",
            "tinyint",
            "timestamp",
            "uniqueidentifier",
            "varbinary(50)",
            "varchar(50)"};

        

        public IDBInfoService service = new DBInfoService(); //用于处理数据库操作
        public static ControlBase BaseControl
        {
            get;
            set;
        }
        /// <summary>
        /// 记录此控件所在的父控件
        /// </summary>
        public static System.Windows.Forms.Control ParentControl
        {
            get;
            set;
        }
        /// <summary>
        /// 用于存储调用此控件的form
        /// </summary>
        public static Form BaseForm
        {
            get;
            set;
        }
        public ControlBase()
        {
            
        }
        public ControlBase(System.Windows.Forms.Control panel)
        {
            Dock = DockStyle.Fill;
            RemoveLastControl();
            ParentControl = panel;
            BaseControl = this;
            FrmMain.NodeChangeHandler += FrmMain_NodeChangeHandler;
        }

        public List<ServerEntity> ServerList = new List<ServerEntity>();
        private void FrmMain_NodeChangeHandler()
        {
            GetServerInfo();
        }
        public bool GetServerInfo()
        {
            ServerList.Clear();
            if (BaseForm is UI.FrmMain)
            {
                foreach (Node root in (BaseForm as FrmMain).RootNode)
                {
                    if (root.Nodes.Count != 0 && root.Name == "服务器")
                    {
                        foreach (Node item in root.Nodes)
                        {
                            if (item.Checked)
                            {
                                foreach (Node child in item.Nodes)
                                {
                                    if (child.Checked)
                                    {
                                        ServerEntity temp = ServerEntity.clone(item.Tag);
                                        temp.ServerDBName.Clear();
                                        temp.ServerDBName.Add(child.Name);
                                        ServerList.Add(temp);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (ServerList.Count == 0)
            {
                return true;
            }
            else return false;
        }
        public void RemoveLastControl()
        {
            if (BaseControl != null)
            {
                ParentControl.Controls.Remove(BaseControl);
                BaseControl = null;
            }
        }

        public static ControlBase Control(Form form, System.Windows.Forms.Control panel1, string name)
        {
            BaseForm = form;
            switch (name)
            {
                case "tsmi_AddDB"://添加数据库
                    BaseControl = new Control_AddDB(panel1);
                    break;
                case "tsmi_AddTable"://在数据库中添加数据表
                    BaseControl = new Control_AddTB(panel1);
                    break;
                case "tsmi_DeleteTable"://在数据库中删除数据表
                    BaseControl = new Control_DeleteTB(panel1);
                    break;
                case "tsmi_AddField"://在数据表中添加字段
                    BaseControl = new Control_AddField(panel1);
                    break;
                case "tsmi_DeleteField"://在数据表中删除字段
                    BaseControl = new Control_DeleteField(panel1);
                    break;
                case "tsmi_UpdateField"://在数据表中更新字段
                    BaseControl = new Control_UpdateField(panel1);
                    break;
                case "tsmi_DropDB"://删除数据库
                    BaseControl = new Control_DropDB(panel1);
                    break;
                case "tsmi_RunSQL":
                    BaseControl = new Control_InputSQL(panel1);
                    break;
            }
            return BaseControl;
        }
    }
}
