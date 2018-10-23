using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBOperationTool.Control
{
    public partial class Control_DeleteField : ControlBase
    {
        public Control_DeleteField():base()
        {

        }
        public Control_DeleteField(System.Windows.Forms.Control panel):base(panel)
        {
            InitializeComponent();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (ServerList.Count == 0 && GetServerInfo())
            {
                MessageBox.Show("请选择数据库以及服务器");
                return;
            }
            if (string.IsNullOrEmpty(tb_TableName.Text) || string.IsNullOrWhiteSpace(tb_TableName.Text))
            {
                MessageBox.Show("请输入表");
                return;
            }
            if (string.IsNullOrEmpty(tb_AddFieldName.Text) || string.IsNullOrWhiteSpace(tb_AddFieldName.Text))
            {
                MessageBox.Show("请输入字段");
                return;
            }

            foreach (var item in ServerList)
            {
                item.ServerTBName.Add(tb_TableName.Text);
                item.Field.Add(new Entities.FieldProperties());
                item.Field[0].FieldName = tb_AddFieldName.Text;
            }
            string result = service.DeleteField(ServerList);
            MessageBox.Show(result);
        }
    }
}
