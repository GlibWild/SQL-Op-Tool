using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DBOperationTool;
using DBOperationTool.Service;
using DBOperationTool.UI;
using DevComponents.AdvTree;
using DBOperationTool.Control;

namespace DBOperationTool.UI
{
    public partial class FrmMain : Form
    {
        public delegate void NodeChangeDelegate();
        public static event NodeChangeDelegate NodeChangeHandler;
        List<ServerEntity> list = new List<ServerEntity>();
        List<ToolStripMenuItem> tsmiList = new List<ToolStripMenuItem>(); //保存动态添加的服务器菜单栏
        IToolService tool = new ToolService();
        ControlBase control = null;
        /// <summary>
        /// 获取树的根节点
        /// </summary>
        public NodeCollection RootNode
        {
            get
            {
                return advTree1.Nodes;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            Control_AddDB.RefreshTreeHandler += Control_AddDB_RefreshTreeHandler;
            Control_DropDB.RefreshTreeHandler += Control_AddDB_RefreshTreeHandler;
        }


        private void Control_AddDB_RefreshTreeHandler()
        {
            GetServerInfo();
            LoadServerTreeStruct();
        }

        /// <summary>
        /// 动态加载树节点
        /// </summary>
        public void LoadServerTreeStruct()
        {
            advTree1.ClearAndDisposeAllNodes();
            if (list.Count > 0)
            {
                Node root = new Node();
                root.Name = "服务器";
                root.Text = "服务器";
                root.CheckBoxVisible = true;
                advTree1.Nodes.Add(root);
                foreach (var item in list)
                {
                    Node node = new Node();
                    node.Name = item.Name;
                    node.Text = item.Name;
                    node.Tag = item;
                    node.CheckBoxVisible = true;
                    root.Nodes.Add(node);
                    int i = 0;
                    int j = 0;
                    bool flag = true;
                    foreach (var DBName in item.ServerDBName)
                    {
                        Node node2 = new Node();
                        node2.Name = DBName;
                        node2.Text = DBName;
                        node2.Tag = DBName;
                        node2.CheckBoxVisible = true;
                        Dictionary<string, string> dic = tool.ReadConfigText();
                        if (dic.Keys.Contains(item.Name))
                        {
                            if (dic[item.Name] == DBName)
                            {
                                node2.Checked = true;
                                flag = false;
                            }
                            j++;
                            if (j == item.ServerDBName.Count && flag)
                            {
                                node.Nodes[0].Checked = true;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                node2.Checked = true;
                                i++;
                            }
                        }
                        node2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;

                        node.Nodes.Add(node2);
                    }
                    node.Checked = false;
                }
            }

        }
        /// <summary>
        /// 加载服务器信息
        /// </summary>
        private void GetServerInfo()
        {
            list.Clear();
            if (File.Exists(ToolService.serverFilePath))
            {
                list = tool.ReadXml(ToolService.serverFilePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetServerInfo();
            LoadServerTreeStruct();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void advTree1_AfterCheck(object sender, AdvTreeCellEventArgs e)
        {
            Node n = e.Cell.Parent;
            advTree1.AfterCheck -= this.advTree1_AfterCheck;
            foreach (Node tn in n.Nodes)
            {
                if (tn.CheckBoxStyle != DevComponents.DotNetBar.eCheckBoxStyle.RadioButton)
                {
                    tn.Checked = n.Checked;
                }
            }
            if (n.Parent != null)
            {
                Node p = n.Parent;
                bool flag = true;
                foreach (Node item in p.Nodes)
                {
                    if (item.CheckBoxStyle != DevComponents.DotNetBar.eCheckBoxStyle.RadioButton)
                    {
                        flag &= item.Checked;
                    }
                }
                p.Checked = flag;
            }
            if (control != null)
            {
                NodeChangeHandler();
            }
            advTree1.AfterCheck += this.advTree1_AfterCheck;
        }

        private void MenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            switch (item.Name)
            {
                case "tsmi_AddDBLinkInfo": //添加数据库连接信息
                    FrmAddDBInfo frmAddDBInfo = new FrmAddDBInfo();
                    frmAddDBInfo.ShowDialog();
                    break;
                case "tsmi_refresh": //刷新功能
                    tool.RefreshConfigFile();
                    GetServerInfo();
                    LoadServerTreeStruct();
                    break;
                case "tsmi_SaveConfig": //设置数据库选中数据库等信息后，可以进行保存，方便下一次读取时直接获取
                    SaveDBConfig();
                    break;
                default:
                    control = ControlBase.Control(this, panel1, item.Name);
                    panel1.Controls.Add(control);
                    break;
            }
        }

        private void SaveDBConfig()
        {
            Dictionary<string, string> ConfigDic = new Dictionary<string, string>();
            foreach (Node root in advTree1.Nodes)
            {
                if (root.Nodes.Count != 0 && root.Name == "服务器")
                {
                    foreach (Node item in root.Nodes)
                    {
                        foreach (Node child in item.Nodes)
                        {
                            if (child.Checked)
                            {
                                ConfigDic.Add(item.Name, child.Name);
                                break;
                            }
                        }
                    }
                }
            }
            if (ConfigDic.Count != 0)
            {
                tool.WriteConfigText(ConfigDic);
            }
        }

        private void 说明文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "服务器工具说明.docx");
            if (File.Exists(path))
            {
                //FileInfo file = new FileInfo(path);
                Process.Start(path);


            }
            else
            {
                MessageBox.Show("说明文件丢失");
            }
        }
    }
}
