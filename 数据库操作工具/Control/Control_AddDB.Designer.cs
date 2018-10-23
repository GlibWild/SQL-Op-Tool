namespace DBOperationTool.Control
{
    partial class Control_AddDB
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
            this.tb_DBName = new System.Windows.Forms.TextBox();
            this.btn_CreateDB = new System.Windows.Forms.Button();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "创建的数据库名：";
            // 
            // tb_DBName
            // 
            this.tb_DBName.Location = new System.Drawing.Point(173, 76);
            this.tb_DBName.Name = "tb_DBName";
            this.tb_DBName.Size = new System.Drawing.Size(202, 21);
            this.tb_DBName.TabIndex = 2;
            // 
            // btn_CreateDB
            // 
            this.btn_CreateDB.Location = new System.Drawing.Point(413, 74);
            this.btn_CreateDB.Name = "btn_CreateDB";
            this.btn_CreateDB.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateDB.TabIndex = 3;
            this.btn_CreateDB.Text = "创建";
            this.btn_CreateDB.UseVisualStyleBackColor = true;
            this.btn_CreateDB.Click += new System.EventHandler(this.btn_CreateDB_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(74, 122);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.Size = new System.Drawing.Size(414, 257);
            this.tb_Result.TabIndex = 4;
            // 
            // Control_AddDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.btn_CreateDB);
            this.Controls.Add(this.tb_DBName);
            this.Controls.Add(this.label1);
            this.Name = "Control_AddDB";
            this.Size = new System.Drawing.Size(563, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DBName;
        private System.Windows.Forms.Button btn_CreateDB;
        private System.Windows.Forms.TextBox tb_Result;
    }
}
