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
    public partial class Control_InputSQL : ControlBase
    {
        public Control_InputSQL():base()
        {

        }
        public Control_InputSQL(System.Windows.Forms.Control panel):base(panel)
        {
            InitializeComponent();
        }
        private void btn_CreateDB_Click(object sender, EventArgs e)
        {
            if (ServerList.Count == 0 && GetServerInfo())
            {
                MessageBox.Show("请选择服务器");
                return;
            }

            string result = string.Empty;
            if (this.checkBox1.Checked)
            {
                string fileName = textBox1.Text;
                result = service.ExecuteSQL_ExportData(ServerList, tb_Result.Text, textBox1.Text);
            }
            else
            {

                result = service.ExecuteSQL(ServerList, tb_Result.Text);
            }
            
            MessageBox.Show(result);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Result.Clear();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.csv|*.csv";
            sfd.CheckPathExists = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = sfd.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Enabled = this.checkBox1.Checked;
        }
    }
}
