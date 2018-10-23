using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBOperationTool.Control;
using DBOperationTool.UI;
using DevComponents.AdvTree;
using System.IO;

namespace DBOperationTool.Control
{
    public partial class Control_DeleteTB : ControlBase
    {
        
        public Control_DeleteTB() : base()
        {

        }
        public Control_DeleteTB(System.Windows.Forms.Control panel) : base(panel)
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (ServerList.Count == 0 && GetServerInfo())
            {
                MessageBox.Show("请选择需要删除表的数据库以及服务器");
                return;
            }
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请输入要删除的表名");
                return;
            }
            foreach (var item in ServerList)
            {
                item.ServerTBName.Add(textBox1.Text);
            }
            if (checkBox1.Checked)
            {
                string result = service.DropTable(ServerList);
                LogHelper.Log(result);
                textBox2.AppendText(result+"\r\n");
            }
            else
            {
                string result = service.TruncateTable(ServerList);
                LogHelper.Log(result);
                textBox2.AppendText(result + "\r\n");
            }
        }        
    }
}
