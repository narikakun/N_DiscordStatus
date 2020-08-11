namespace N_DiscordStatus
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.大きさを戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.位置を戻すToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.最前面にするToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最前面を解除するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 115);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 97);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.toolStripSeparator2,
            this.大きさを戻すToolStripMenuItem,
            this.位置を戻すToolStripMenuItem,
            this.toolStripSeparator1,
            this.最前面にするToolStripMenuItem,
            this.最前面を解除するToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 126);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // 大きさを戻すToolStripMenuItem
            // 
            this.大きさを戻すToolStripMenuItem.Name = "大きさを戻すToolStripMenuItem";
            this.大きさを戻すToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.大きさを戻すToolStripMenuItem.Text = "大きさを戻す";
            this.大きさを戻すToolStripMenuItem.Click += new System.EventHandler(this.大きさを戻すToolStripMenuItem_Click);
            // 
            // 位置を戻すToolStripMenuItem
            // 
            this.位置を戻すToolStripMenuItem.Name = "位置を戻すToolStripMenuItem";
            this.位置を戻すToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.位置を戻すToolStripMenuItem.Text = "位置を戻す";
            this.位置を戻すToolStripMenuItem.Click += new System.EventHandler(this.位置を戻すToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // 最前面にするToolStripMenuItem
            // 
            this.最前面にするToolStripMenuItem.Name = "最前面にするToolStripMenuItem";
            this.最前面にするToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.最前面にするToolStripMenuItem.Text = "最前面にする";
            this.最前面にするToolStripMenuItem.Click += new System.EventHandler(this.最前面にするToolStripMenuItem_Click);
            // 
            // 最前面を解除するToolStripMenuItem
            // 
            this.最前面を解除するToolStripMenuItem.Name = "最前面を解除するToolStripMenuItem";
            this.最前面を解除するToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.最前面を解除するToolStripMenuItem.Text = "最前面を解除する";
            this.最前面を解除するToolStripMenuItem.Click += new System.EventHandler(this.最前面を解除するToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = global::N_DiscordStatus.Properties.Settings.Default.Size;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::N_DiscordStatus.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::N_DiscordStatus.Properties.Settings.Default, "Size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("TopMost", global::N_DiscordStatus.Properties.Settings.Default, "TopMost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::N_DiscordStatus.Properties.Settings.Default.Location;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = global::N_DiscordStatus.Properties.Settings.Default.TopMost;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大きさを戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 位置を戻すToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最前面にするToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 最前面を解除するToolStripMenuItem;
    }
}

