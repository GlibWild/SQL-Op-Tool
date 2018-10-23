namespace DBOperationTool.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mns_Frm3GVideo = new System.Windows.Forms.MenuStrip();
            this.tsmi_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AddDBLinkInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.表设计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AddDB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DropDB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AddTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DeleteTable = new System.Windows.Forms.ToolStripMenuItem();
            this.数据表功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AddField = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_UpdateField = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DeleteField = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SaveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_RunSQL = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.advTree1 = new DevComponents.AdvTree.AdvTree();
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.说明文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mns_Frm3GVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).BeginInit();
            this.SuspendLayout();
            // 
            // mns_Frm3GVideo
            // 
            this.mns_Frm3GVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Setting,
            this.tsmi_refresh,
            this.说明文档ToolStripMenuItem});
            this.mns_Frm3GVideo.Location = new System.Drawing.Point(0, 0);
            this.mns_Frm3GVideo.Name = "mns_Frm3GVideo";
            this.mns_Frm3GVideo.Size = new System.Drawing.Size(717, 25);
            this.mns_Frm3GVideo.TabIndex = 3;
            this.mns_Frm3GVideo.Text = "menuStrip1";
            // 
            // tsmi_Setting
            // 
            this.tsmi_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AddDBLinkInfo,
            this.表设计ToolStripMenuItem,
            this.数据表功能ToolStripMenuItem,
            this.tsmi_SaveConfig,
            this.tsmi_RunSQL});
            this.tsmi_Setting.Name = "tsmi_Setting";
            this.tsmi_Setting.Size = new System.Drawing.Size(44, 21);
            this.tsmi_Setting.Text = "设置";
            // 
            // tsmi_AddDBLinkInfo
            // 
            this.tsmi_AddDBLinkInfo.Name = "tsmi_AddDBLinkInfo";
            this.tsmi_AddDBLinkInfo.Size = new System.Drawing.Size(184, 22);
            this.tsmi_AddDBLinkInfo.Text = "新增数据库连接信息";
            this.tsmi_AddDBLinkInfo.Click += new System.EventHandler(this.MenuClick);
            // 
            // 表设计ToolStripMenuItem
            // 
            this.表设计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AddDB,
            this.tsmi_DropDB,
            this.tsmi_AddTable,
            this.tsmi_DeleteTable});
            this.表设计ToolStripMenuItem.Name = "表设计ToolStripMenuItem";
            this.表设计ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.表设计ToolStripMenuItem.Text = "数据库功能";
            // 
            // tsmi_AddDB
            // 
            this.tsmi_AddDB.Name = "tsmi_AddDB";
            this.tsmi_AddDB.Size = new System.Drawing.Size(136, 22);
            this.tsmi_AddDB.Text = "新增数据库";
            this.tsmi_AddDB.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_DropDB
            // 
            this.tsmi_DropDB.Name = "tsmi_DropDB";
            this.tsmi_DropDB.Size = new System.Drawing.Size(136, 22);
            this.tsmi_DropDB.Text = "删除数据库";
            this.tsmi_DropDB.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_AddTable
            // 
            this.tsmi_AddTable.Name = "tsmi_AddTable";
            this.tsmi_AddTable.Size = new System.Drawing.Size(136, 22);
            this.tsmi_AddTable.Text = "新增表";
            this.tsmi_AddTable.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_DeleteTable
            // 
            this.tsmi_DeleteTable.Name = "tsmi_DeleteTable";
            this.tsmi_DeleteTable.Size = new System.Drawing.Size(136, 22);
            this.tsmi_DeleteTable.Text = "删除表";
            this.tsmi_DeleteTable.Click += new System.EventHandler(this.MenuClick);
            // 
            // 数据表功能ToolStripMenuItem
            // 
            this.数据表功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AddField,
            this.tsmi_UpdateField,
            this.tsmi_DeleteField});
            this.数据表功能ToolStripMenuItem.Name = "数据表功能ToolStripMenuItem";
            this.数据表功能ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.数据表功能ToolStripMenuItem.Text = "数据表功能";
            // 
            // tsmi_AddField
            // 
            this.tsmi_AddField.Name = "tsmi_AddField";
            this.tsmi_AddField.Size = new System.Drawing.Size(152, 22);
            this.tsmi_AddField.Text = "新增表字段";
            this.tsmi_AddField.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_UpdateField
            // 
            this.tsmi_UpdateField.Name = "tsmi_UpdateField";
            this.tsmi_UpdateField.Size = new System.Drawing.Size(152, 22);
            this.tsmi_UpdateField.Text = "修改表字段";
            this.tsmi_UpdateField.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_DeleteField
            // 
            this.tsmi_DeleteField.Name = "tsmi_DeleteField";
            this.tsmi_DeleteField.Size = new System.Drawing.Size(152, 22);
            this.tsmi_DeleteField.Text = "删除表字段";
            this.tsmi_DeleteField.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_SaveConfig
            // 
            this.tsmi_SaveConfig.Name = "tsmi_SaveConfig";
            this.tsmi_SaveConfig.Size = new System.Drawing.Size(184, 22);
            this.tsmi_SaveConfig.Text = "保存数据库配置";
            this.tsmi_SaveConfig.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_RunSQL
            // 
            this.tsmi_RunSQL.Name = "tsmi_RunSQL";
            this.tsmi_RunSQL.Size = new System.Drawing.Size(184, 22);
            this.tsmi_RunSQL.Text = "运行SQL语句";
            this.tsmi_RunSQL.Click += new System.EventHandler(this.MenuClick);
            // 
            // tsmi_refresh
            // 
            this.tsmi_refresh.Name = "tsmi_refresh";
            this.tsmi_refresh.Size = new System.Drawing.Size(44, 21);
            this.tsmi_refresh.Text = "刷新";
            this.tsmi_refresh.Click += new System.EventHandler(this.MenuClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.advTree1);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(717, 412);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // advTree1
            // 
            this.advTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.advTree1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.advTree1.BackgroundStyle.Class = "TreeBorderKey";
            this.advTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.advTree1.Columns.Add(this.columnHeader1);
            this.advTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advTree1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.advTree1.Location = new System.Drawing.Point(0, 0);
            this.advTree1.Name = "advTree1";
            this.advTree1.NodesConnector = this.nodeConnector1;
            this.advTree1.NodeStyle = this.elementStyle1;
            this.advTree1.PathSeparator = ";";
            this.advTree1.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
            this.advTree1.Size = new System.Drawing.Size(150, 412);
            this.advTree1.Styles.Add(this.elementStyle1);
            this.advTree1.TabIndex = 0;
            this.advTree1.Text = "advTree1";
            this.advTree1.AfterCheck += new DevComponents.AdvTree.AdvTreeCellEventHandler(this.advTree1_AfterCheck);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DataFieldName = "Name";
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.StretchToFill = true;
            this.columnHeader1.Width.Absolute = 150;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 412);
            this.panel1.TabIndex = 0;
            // 
            // 说明文档ToolStripMenuItem
            // 
            this.说明文档ToolStripMenuItem.Name = "说明文档ToolStripMenuItem";
            this.说明文档ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.说明文档ToolStripMenuItem.Text = "说明文档";
            this.说明文档ToolStripMenuItem.Click += new System.EventHandler(this.说明文档ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 437);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mns_Frm3GVideo);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mns_Frm3GVideo.ResumeLayout(false);
            this.mns_Frm3GVideo.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advTree1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_Frm3GVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Setting;
        private System.Windows.Forms.ToolStripMenuItem tsmi_refresh;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddDBLinkInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem 表设计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddDB;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddTable;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteTable;
        private System.Windows.Forms.ToolStripMenuItem 数据表功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddField;
        private System.Windows.Forms.ToolStripMenuItem tsmi_UpdateField;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SaveConfig;
        public DevComponents.AdvTree.AdvTree advTree1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DropDB;
        private System.Windows.Forms.ToolStripMenuItem tsmi_RunSQL;
        private System.Windows.Forms.ToolStripMenuItem 说明文档ToolStripMenuItem;
    }
}

