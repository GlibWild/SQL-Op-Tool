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
    public partial class Control_UpdateField : ControlBase
    {
        public Control_UpdateField() : base()
        {

        }
        public Control_UpdateField(System.Windows.Forms.Control panel) : base(panel)
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
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




            #region
            //List<ServerEntity> se = service.SearchFieldProperties(ServerList);
            ////使用逻辑为：判断是否有报错信息（Tag），没有则返回查询成功，有则返回哪个数据库查询失败
            //string ErrorText = null;
            //int i = 0;
            //foreach (ServerEntity item in se)
            //{
            //    if (!string.IsNullOrEmpty(item.Field[0].Tag))
            //    {
            //        ErrorText += "数据库" + item.ServerIP + "," + item.ServerPort + ":" + item.ServerDBName[0] + "查询失败。\r\n失败原因：" + item.Field[0].Tag + "\r\n";
            //    }
            //    else
            //    {
            //        if (i == 0)
            //        {
            //            //显示数据仅为第一条数据信息
            //            tb_FieldType.Text = item.Field[0].FieldType;
            //            cb_NullValue.Checked = item.Field[0].FieldValueNull == 1 ? true : false;
            //            cb_PrimaryKey.Checked = item.Field[0].IsPrimaryKey == 1 ? true : false;
            //            cb_SelfPropagation.Checked = item.Field[0].SelfPropagation == 1 ? true : false;
            //        }
            //        i++;
            //    }
            //}
            //MessageBox.Show(ErrorText);
            #endregion
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
            //if (string.IsNullOrEmpty(tb_ModifyFieldName.Text) || string.IsNullOrWhiteSpace(tb_ModifyFieldName.Text))
            //{
            //    MessageBox.Show("请输入修改后的字段");
            //    return;
            //}
            if (string.IsNullOrEmpty(tb_FieldType.Text) || string.IsNullOrWhiteSpace(tb_FieldType.Text))
            {
                MessageBox.Show("请输入修改后的字段");
                return;
            }

            foreach (var item in ServerList)
            {
                item.ServerTBName.Add(tb_TableName.Text);
                item.Field.Add(new Entities.FieldProperties());
                item.Field[0].FieldName = tb_AddFieldName.Text;
                item.Field[0].FieldType = tb_FieldType.Text;
            }
            string result = service.AlertFieldType(ServerList);
            MessageBox.Show(result);
        }
    }
}
