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
    public partial class Control_AddTB : ControlBase
    {
        public Control_AddTB() : base()
        {

        }
        public Control_AddTB(System.Windows.Forms.Control panel) : base(panel)
        {
            InitializeComponent();
            DataGridViewComboBoxColumn TypeColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["FieldType"];
            TypeColumn.DataSource = Type;
            DataGridViewCheckBoxColumn NullColumn = (DataGridViewCheckBoxColumn)dataGridView1.Columns["IsValueNull"];
        }
        int index = 0; //选中的行数
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hti = dataGridView1.HitTest(e.X, e.Y);
                //_DataCount = _GPSInfoList.Count;
                if ((hti.RowIndex >= 0) && (hti.RowIndex < dataGridView1.Rows.Count))
                {
                    index = hti.RowIndex;
                    Point point = new Point();
                    point = MousePosition;
                    contextMenuStrip1.Show(point);
                }
            }
        }

        private void tsmi_DeleteCurrRow_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                try
                {
                    dataGridView1.Rows.RemoveAt(index);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_AddTable_Click(object sender, EventArgs e)
        {
            if (ServerList.Count == 0 && GetServerInfo())
            {
                MessageBox.Show("请选择数据库以及服务器");
                return;
            }
            if (string.IsNullOrEmpty(tb_TBName.Text))
            {
                MessageBox.Show("请输入新建表名");
                return;
            }
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("请输入新建表字段");
                return;
            }
            List<FieldProperties> fpList = new List<FieldProperties>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["FieldName"].Value == null)
                {
                    MessageBox.Show("请输入字段名");
                    return;
                }
                if (dataGridView1.Rows[i].Cells["FieldType"].Value == null)
                {
                    MessageBox.Show("请选择字段类型");
                    return;
                }
                //未勾选checkbox，则设置为false
                if (dataGridView1.Rows[i].Cells["IsValueNull"].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["IsValueNull"].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells["IsValueNull"].Value = false;
                }
                if (dataGridView1.Rows[i].Cells["SelfIncrease"].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["SelfIncrease"].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells["SelfIncrease"].Value = false;
                }
                if (dataGridView1.Rows[i].Cells["IsPrimaryKey"].Value == null || string.IsNullOrEmpty(dataGridView1.Rows[i].Cells["IsPrimaryKey"].Value.ToString()))
                {
                    dataGridView1.Rows[i].Cells["IsPrimaryKey"].Value = false;
                }
                FieldProperties fp = new FieldProperties();
                fp.FieldName = dataGridView1.Rows[i].Cells["FieldName"].Value.ToString();
                fp.FieldType = dataGridView1.Rows[i].Cells["FieldType"].Value.ToString();
                fp.FieldValueNull = bool.Parse(dataGridView1.Rows[i].Cells["IsValueNull"].Value.ToString())?1:0;
                fp.SelfPropagation = bool.Parse(dataGridView1.Rows[i].Cells["SelfIncrease"].Value.ToString()) ? 1 : 0;
                fp.IsPrimaryKey = bool.Parse(dataGridView1.Rows[i].Cells["IsPrimaryKey"].Value.ToString()) ? 1 : 0; 
                fpList.Add(fp);
            }
            foreach (ServerEntity item in ServerList)
            {
                item.ServerTBName.Add(tb_TBName.Text);
                item.Field = new List<FieldProperties>(fpList);
            }
            string result = service.CreateTable(ServerList);
            MessageBox.Show(result);
        }
    }
}
