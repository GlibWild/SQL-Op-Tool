namespace DBOperationTool.Control
{
    partial class Control_AddField
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_AddField = new System.Windows.Forms.Button();
            this.comboBox_FieldType = new System.Windows.Forms.ComboBox();
            this.cb_NullValue = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_AddFieldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_SelfPropagation = new System.Windows.Forms.CheckBox();
            this.cb_PrimaryKey = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_PrimaryKey);
            this.panel1.Controls.Add(this.cb_SelfPropagation);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_AddField);
            this.panel1.Controls.Add(this.comboBox_FieldType);
            this.panel1.Controls.Add(this.cb_NullValue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_AddFieldName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_TableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 312);
            this.panel1.TabIndex = 0;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(205, 240);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_AddField
            // 
            this.btn_AddField.Location = new System.Drawing.Point(62, 240);
            this.btn_AddField.Name = "btn_AddField";
            this.btn_AddField.Size = new System.Drawing.Size(75, 23);
            this.btn_AddField.TabIndex = 8;
            this.btn_AddField.Text = "添加";
            this.btn_AddField.UseVisualStyleBackColor = true;
            this.btn_AddField.Click += new System.EventHandler(this.btn_AddField_Click);
            // 
            // comboBox_FieldType
            // 
            this.comboBox_FieldType.DropDownHeight = 70;
            this.comboBox_FieldType.FormattingEnabled = true;
            this.comboBox_FieldType.IntegralHeight = false;
            this.comboBox_FieldType.Location = new System.Drawing.Point(87, 165);
            this.comboBox_FieldType.Name = "comboBox_FieldType";
            this.comboBox_FieldType.Size = new System.Drawing.Size(193, 20);
            this.comboBox_FieldType.TabIndex = 7;
            // 
            // cb_NullValue
            // 
            this.cb_NullValue.AutoSize = true;
            this.cb_NullValue.Checked = true;
            this.cb_NullValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_NullValue.Location = new System.Drawing.Point(301, 111);
            this.cb_NullValue.Name = "cb_NullValue";
            this.cb_NullValue.Size = new System.Drawing.Size(108, 16);
            this.cb_NullValue.TabIndex = 6;
            this.cb_NullValue.Text = "是否允许值为空";
            this.cb_NullValue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "字段类型：";
            // 
            // tb_AddFieldName
            // 
            this.tb_AddFieldName.Location = new System.Drawing.Point(87, 108);
            this.tb_AddFieldName.Name = "tb_AddFieldName";
            this.tb_AddFieldName.Size = new System.Drawing.Size(193, 21);
            this.tb_AddFieldName.TabIndex = 3;
            this.tb_AddFieldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "添加字段：";
            // 
            // tb_TableName
            // 
            this.tb_TableName.Location = new System.Drawing.Point(87, 51);
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(193, 21);
            this.tb_TableName.TabIndex = 1;
            this.tb_TableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // cb_SelfPropagation
            // 
            this.cb_SelfPropagation.AutoSize = true;
            this.cb_SelfPropagation.Location = new System.Drawing.Point(301, 168);
            this.cb_SelfPropagation.Name = "cb_SelfPropagation";
            this.cb_SelfPropagation.Size = new System.Drawing.Size(96, 16);
            this.cb_SelfPropagation.TabIndex = 10;
            this.cb_SelfPropagation.Text = "是否为自增长";
            this.cb_SelfPropagation.UseVisualStyleBackColor = true;
            // 
            // cb_PrimaryKey
            // 
            this.cb_PrimaryKey.AutoSize = true;
            this.cb_PrimaryKey.Location = new System.Drawing.Point(301, 141);
            this.cb_PrimaryKey.Name = "cb_PrimaryKey";
            this.cb_PrimaryKey.Size = new System.Drawing.Size(84, 16);
            this.cb_PrimaryKey.TabIndex = 11;
            this.cb_PrimaryKey.Text = "是否为主键";
            this.cb_PrimaryKey.UseVisualStyleBackColor = true;
            // 
            // Control_AddField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Control_AddField";
            this.Size = new System.Drawing.Size(412, 312);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AddFieldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_NullValue;
        private System.Windows.Forms.ComboBox comboBox_FieldType;
        private System.Windows.Forms.Button btn_AddField;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.CheckBox cb_PrimaryKey;
        private System.Windows.Forms.CheckBox cb_SelfPropagation;
    }
}
