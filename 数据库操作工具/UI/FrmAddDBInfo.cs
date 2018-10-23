using DBOperationTool.Dao;
using DBOperationTool.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBOperationTool.UI
{
    public partial class FrmAddDBInfo : Form
    {
        ServerEntity se = new ServerEntity();
        List<string> DBName = new List<string>();
        public FrmAddDBInfo()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_DBIP.Text))
            {
                MessageBox.Show("IP值为空");
                return;
            }
            if (string.IsNullOrEmpty(tb_DBPort.Text))
            {
                MessageBox.Show("端口为空");
                return;
            }
            if (string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("密码为空");
                return;
            }
            if (string.IsNullOrEmpty(tb_ServerName.Text))
            {
                MessageBox.Show("服务器名为空");
                return;
            }
            if (string.IsNullOrEmpty(tb_UserID.Text))
            {
                MessageBox.Show("用户名为空");
                return;
            }

            se.Name = tb_ServerName.Text;
            se.ServerIP = tb_DBIP.Text;
            se.ServerPort = tb_DBPort.Text;
            se.ServerUserName = tb_UserID.Text;
            se.ServerPassword = tb_Password.Text;
            IDBInfoService service = new DBInfoService();
            DBName.Clear();
            DBName = service.SearchDBName(se);
            if (DBName.Count() == 0)
            {
                MessageBox.Show("请核查数据库信息是否正确");
            }
            else
            {
                MessageBox.Show("连接测试成功");
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (DBName.Count != 0)
            {
                se.ServerDBName = new List<string>(DBName);
                IToolService tool = new ToolService();
                tool.WriteXml(se);
                this.Close();
            }
            else
            {
                MessageBox.Show("请先进行连接测试");
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
