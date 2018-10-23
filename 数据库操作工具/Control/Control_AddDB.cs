using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DBOperationTool.Service;

namespace DBOperationTool.Control
{
    public partial class Control_AddDB : ControlBase
    {
        public delegate void RefreshDBNameListDelegate();
        public static event RefreshDBNameListDelegate RefreshDBNameListHandler; //用于在新增数据库后对存储信息进行更新的功能

        public delegate void RefreshTreeDelegate();
        public static event RefreshTreeDelegate RefreshTreeHandler ; //用于通知主界面更新树结构
        public Control_AddDB():base()
        {

        }
        public Control_AddDB(System.Windows.Forms.Control panel):base(panel)
        {
            InitializeComponent();
            RefreshDBNameListHandler += Control_AddDB_RefreshDBNameListHandler;
        }

        private void Control_AddDB_RefreshDBNameListHandler()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                IToolService tool = new ToolService();
                tool.RefreshConfigFile();
                RefreshTreeHandler();
            }));
            
        }

        private void btn_CreateDB_Click(object sender, EventArgs e)
        {
            if (ServerList.Count == 0 && GetServerInfo())
            {
                MessageBox.Show("请选择服务器");
                return;
            }
            foreach (ServerEntity item in ServerList)
            {
                item.ServerDBName.Clear();
                item.ServerDBName.Add(tb_DBName.Text);
            }
            this.BeginInvoke(new MethodInvoker(delegate
            {
                string result = service.CreateDatabase(ServerList);
                tb_Result.Text += result;
                RefreshDBNameListHandler();
            }));
        }
    }
}
