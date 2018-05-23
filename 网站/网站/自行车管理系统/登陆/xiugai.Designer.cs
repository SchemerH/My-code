namespace 登陆
{
    partial class xiugai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.政治面貌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除成员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审核失败ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(518, 230);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "车辆编号";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "车辆品牌";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "车辆型号";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "车辆新旧程度";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "上传用户";
            this.columnHeader5.Width = 114;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "价格";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.政治面貌ToolStripMenuItem,
            this.删除成员ToolStripMenuItem,
            this.审核失败ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 政治面貌ToolStripMenuItem
            // 
            this.政治面貌ToolStripMenuItem.Name = "政治面貌ToolStripMenuItem";
            this.政治面貌ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.政治面貌ToolStripMenuItem.Text = "查看图片";
            this.政治面貌ToolStripMenuItem.Click += new System.EventHandler(this.政治面貌ToolStripMenuItem_Click);
            // 
            // 删除成员ToolStripMenuItem
            // 
            this.删除成员ToolStripMenuItem.Name = "删除成员ToolStripMenuItem";
            this.删除成员ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除成员ToolStripMenuItem.Text = "审核通过";
            this.删除成员ToolStripMenuItem.Click += new System.EventHandler(this.删除成员ToolStripMenuItem_Click);
            // 
            // 审核失败ToolStripMenuItem
            // 
            this.审核失败ToolStripMenuItem.Name = "审核失败ToolStripMenuItem";
            this.审核失败ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.审核失败ToolStripMenuItem.Text = "审核失败";
            this.审核失败ToolStripMenuItem.Click += new System.EventHandler(this.审核失败ToolStripMenuItem_Click);
            // 
            // xiugai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 293);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "xiugai";
            this.Text = "查找";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 政治面貌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除成员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 审核失败ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}