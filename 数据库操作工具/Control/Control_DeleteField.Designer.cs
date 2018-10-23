namespace DBOperationTool.Control
{
    partial class Control_DeleteField
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
            this.btn_Change = new System.Windows.Forms.Button();
            this.tb_AddFieldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Change);
            this.panel1.Controls.Add(this.tb_AddFieldName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_TableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 312);
            this.panel1.TabIndex = 2;
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(149, 225);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(75, 23);
            this.btn_Change.TabIndex = 9;
            this.btn_Change.Text = "删除字段";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // tb_AddFieldName
            // 
            this.tb_AddFieldName.Location = new System.Drawing.Point(114, 127);
            this.tb_AddFieldName.Name = "tb_AddFieldName";
            this.tb_AddFieldName.Size = new System.Drawing.Size(193, 21);
            this.tb_AddFieldName.TabIndex = 3;
            this.tb_AddFieldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "字段名：";
            // 
            // tb_TableName
            // 
            this.tb_TableName.Location = new System.Drawing.Point(114, 88);
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(193, 21);
            this.tb_TableName.TabIndex = 1;
            this.tb_TableName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 91);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据表：";
            // 
            // Control_DeleteField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Control_DeleteField";
            this.Size = new System.Drawing.Size(412, 312);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox tb_AddFieldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TableName;
        private System.Windows.Forms.Label label1;
    }
}
