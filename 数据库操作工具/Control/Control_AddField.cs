using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBOperationTool.Entities;

namespace DBOperationTool.Control
{
    public partial class Control_AddField : ControlBase
    {
       
        public Control_AddField() : base()
        {

        }
        public Control_AddField(System.Windows.Forms.Control panel) : base(panel)
        {
            InitializeComponent();
            comboBox_FieldType.Items.AddRange(Type);
        }

        private void btn_AddField_Click(object sender, EventArgs e)
        {
            if (ServerList.Count == 0 && GetServerInfo())
            {
                MessageBox.Show("请选择数据库以及服务器");
                return;
            }
            if (string.IsNullOrEmpty(tb_TableName.Text) || string.IsNullOrWhiteSpace(tb_TableName.Text))
            {
                MessageBox.Show("请输入添加字段的表");
                return;
            }
            if (string.IsNullOrEmpty(tb_AddFieldName.Text) || string.IsNullOrWhiteSpace(tb_AddFieldName.Text))
            {
                MessageBox.Show("请输入添加字段");
                return;
            }
            if (string.IsNullOrEmpty(comboBox_FieldType.Text) || string.IsNullOrWhiteSpace(comboBox_FieldType.Text))
            {
                MessageBox.Show("请输入添加字段类型");
                return;
            }
            foreach (var item in ServerList)
            {
                item.Field.Clear();
                item.ServerTBName.Add(tb_TableName.Text);
                string FieldType = comboBox_FieldType.Text;
                FieldProperties fp = new FieldProperties();

                fp.FieldName = tb_AddFieldName.Text;
                fp.FieldType = FieldType;
                fp.FieldValueNull = cb_NullValue.Checked == true ? 1 : 0;
                fp.IsPrimaryKey = cb_PrimaryKey.Checked == true ? 1 : 0;
                fp.SelfPropagation = cb_SelfPropagation.Checked == true ? 1 : 0;
                item.Field.Add(fp);
            }
            string result = service.AddTableField(ServerList);
            MessageBox.Show(result);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_TableName.Text = null;
            tb_AddFieldName.Text = null;
            cb_NullValue.Checked = true;
            comboBox_FieldType.Text = null;
        }
    }
}
