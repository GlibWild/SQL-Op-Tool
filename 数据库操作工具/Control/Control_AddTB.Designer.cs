namespace DBOperationTool.Control
{
    partial class Control_AddTB
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TBName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddTable = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_DeleteCurrRow = new System.Windows.Forms.ToolStripMenuItem();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsValueNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SelfIncrease = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加表名：";
            // 
            // tb_TBName
            // 
            this.tb_TBName.Location = new System.Drawing.Point(74, 17);
            this.tb_TBName.Name = "tb_TBName";
            this.tb_TBName.Size = new System.Drawing.Size(216, 21);
            this.tb_TBName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.FieldType,
            this.IsValueNull,
            this.IsPrimaryKey,
            this.SelfIncrease});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(412, 260);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AddTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_TBName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 52);
            this.panel1.TabIndex = 3;
            // 
            // btn_AddTable
            // 
            this.btn_AddTable.Location = new System.Drawing.Point(319, 17);
            this.btn_AddTable.Name = "btn_AddTable";
            this.btn_AddTable.Size = new System.Drawing.Size(75, 23);
            this.btn_AddTable.TabIndex = 4;
            this.btn_AddTable.Text = "新增";
            this.btn_AddTable.UseVisualStyleBackColor = true;
            this.btn_AddTable.Click += new System.EventHandler(this.btn_AddTable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_DeleteCurrRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 26);
            // 
            // tsmi_DeleteCurrRow
            // 
            this.tsmi_DeleteCurrRow.Name = "tsmi_DeleteCurrRow";
            this.tsmi_DeleteCurrRow.Size = new System.Drawing.Size(136, 22);
            this.tsmi_DeleteCurrRow.Text = "删除当前行";
            this.tsmi_DeleteCurrRow.Click += new System.EventHandler(this.tsmi_DeleteCurrRow_Click);
            // 
            // FieldName
            // 
            this.FieldName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldName.HeaderText = "字段名";
            this.FieldName.Name = "FieldName";
            // 
            // FieldType
            // 
            this.FieldType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FieldType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.FieldType.HeaderText = "字段类型";
            this.FieldType.Name = "FieldType";
            this.FieldType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FieldType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IsValueNull
            // 
            this.IsValueNull.FalseValue = "";
            this.IsValueNull.HeaderText = "Null";
            this.IsValueNull.Name = "IsValueNull";
            this.IsValueNull.TrueValue = "true";
            this.IsValueNull.Width = 50;
            // 
            // IsPrimaryKey
            // 
            this.IsPrimaryKey.HeaderText = "PK";
            this.IsPrimaryKey.Name = "IsPrimaryKey";
            this.IsPrimaryKey.Width = 40;
            // 
            // SelfIncrease
            // 
            this.SelfIncrease.HeaderText = "自增长";
            this.SelfIncrease.Name = "SelfIncrease";
            this.SelfIncrease.Width = 60;
            // 
            // Control_AddTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Control_AddTB";
            this.Size = new System.Drawing.Size(412, 312);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TBName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteCurrRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FieldType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsValueNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPrimaryKey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelfIncrease;
    }
}
