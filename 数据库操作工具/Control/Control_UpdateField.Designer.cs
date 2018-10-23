namespace DBOperationTool.Control
{
    partial class Control_UpdateField
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_AddFieldName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_NullValue = new System.Windows.Forms.CheckBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.cb_SelfPropagation = new System.Windows.Forms.CheckBox();
            this.cb_PrimaryKey = new System.Windows.Forms.CheckBox();
            this.tb_FieldType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ModifyFieldName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据表：";
            // 
            // tb_TableName
            // 
            this.tb_TableName.Location = new System.Drawing.Point(87, 51);
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(193, 21);
            this.tb_TableName.TabIndex = 1;
            this.tb_TableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "原有字段名：";
            // 
            // tb_AddFieldName
            // 
            this.tb_AddFieldName.Location = new System.Drawing.Point(87, 90);
            this.tb_AddFieldName.Name = "tb_AddFieldName";
            this.tb_AddFieldName.Size = new System.Drawing.Size(193, 21);
            this.tb_AddFieldName.TabIndex = 3;
            this.tb_AddFieldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "字段类型：";
            // 
            // cb_NullValue
            // 
            this.cb_NullValue.AutoSize = true;
            this.cb_NullValue.Checked = true;
            this.cb_NullValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_NullValue.Location = new System.Drawing.Point(30, 237);
            this.cb_NullValue.Name = "cb_NullValue";
            this.cb_NullValue.Size = new System.Drawing.Size(108, 16);
            this.cb_NullValue.TabIndex = 6;
            this.cb_NullValue.Text = "是否允许值为空";
            this.cb_NullValue.UseVisualStyleBackColor = true;
            this.cb_NullValue.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(301, 88);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Visible = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(136, 269);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 9;
            this.btn_Change.Text = "修改";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // cb_SelfPropagation
            // 
            this.cb_SelfPropagation.AutoSize = true;
            this.cb_SelfPropagation.Location = new System.Drawing.Point(280, 237);
            this.cb_SelfPropagation.Name = "cb_SelfPropagation";
            this.cb_SelfPropagation.Size = new System.Drawing.Size(96, 16);
            this.cb_SelfPropagation.TabIndex = 10;
            this.cb_SelfPropagation.Text = "是否为自增长";
            this.cb_SelfPropagation.UseVisualStyleBackColor = true;
            this.cb_SelfPropagation.Visible = false;
            // 
            // cb_PrimaryKey
            // 
            this.cb_PrimaryKey.AutoSize = true;
            this.cb_PrimaryKey.Location = new System.Drawing.Point(163, 237);
            this.cb_PrimaryKey.Name = "cb_PrimaryKey";
            this.cb_PrimaryKey.Size = new System.Drawing.Size(84, 16);
            this.cb_PrimaryKey.TabIndex = 11;
            this.cb_PrimaryKey.Text = "是否为主键";
            this.cb_PrimaryKey.UseVisualStyleBackColor = true;
            this.cb_PrimaryKey.Visible = false;
            // 
            // tb_FieldType
            // 
            this.tb_FieldType.Location = new System.Drawing.Point(87, 159);
            this.tb_FieldType.Name = "tb_FieldType";
            this.tb_FieldType.Size = new System.Drawing.Size(193, 21);
            this.tb_FieldType.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "修改字段属性为";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_ModifyFieldName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_FieldType);
            this.panel1.Controls.Add(this.cb_PrimaryKey);
            this.panel1.Controls.Add(this.cb_SelfPropagation);
            this.panel1.Controls.Add(this.btn_Change);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.cb_NullValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_AddFieldName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_TableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 312);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "字段名：";
            this.label5.Visible = false;
            // 
            // tb_ModifyFieldName
            // 
            this.tb_ModifyFieldName.Location = new System.Drawing.Point(87, 159);
            this.tb_ModifyFieldName.Name = "tb_ModifyFieldName";
            this.tb_ModifyFieldName.Size = new System.Drawing.Size(193, 21);
            this.tb_ModifyFieldName.TabIndex = 14;
            this.tb_ModifyFieldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ModifyFieldName.Visible = false;
            // 
            // Control_UpdateField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Control_UpdateField";
            this.Size = new System.Drawing.Size(412, 312);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_AddFieldName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_NullValue;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.CheckBox cb_SelfPropagation;
        private System.Windows.Forms.CheckBox cb_PrimaryKey;
        private System.Windows.Forms.TextBox tb_FieldType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ModifyFieldName;
        private System.Windows.Forms.Label label5;
    }
}
