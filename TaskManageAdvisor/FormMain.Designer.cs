namespace TaskManageAdvisor
{
    partial class FormMain
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
            this.UCKeepingTasks = new TaskManageAdvisor.UserControlKeepingTasks();
            this.ButtonOptions = new System.Windows.Forms.Button();
            this.ButtonDaily = new System.Windows.Forms.Button();
            this.ButtonTaskManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UCKeepingTasks
            // 
            this.UCKeepingTasks.Location = new System.Drawing.Point(200, 0);
            this.UCKeepingTasks.Name = "UCKeepingTasks";
            this.UCKeepingTasks.Size = new System.Drawing.Size(782, 660);
            this.UCKeepingTasks.TabIndex = 0;
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonOptions.Location = new System.Drawing.Point(0, 160);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(200, 80);
            this.ButtonOptions.TabIndex = 5;
            this.ButtonOptions.Text = "設定";
            this.ButtonOptions.UseVisualStyleBackColor = true;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // ButtonDaily
            // 
            this.ButtonDaily.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonDaily.Location = new System.Drawing.Point(0, 80);
            this.ButtonDaily.Name = "ButtonDaily";
            this.ButtonDaily.Size = new System.Drawing.Size(200, 80);
            this.ButtonDaily.TabIndex = 4;
            this.ButtonDaily.Text = "デイリー";
            this.ButtonDaily.UseVisualStyleBackColor = true;
            this.ButtonDaily.Click += new System.EventHandler(this.ButtonDaily_Click);
            // 
            // ButtonTaskManage
            // 
            this.ButtonTaskManage.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonTaskManage.Location = new System.Drawing.Point(0, 0);
            this.ButtonTaskManage.Name = "ButtonTaskManage";
            this.ButtonTaskManage.Size = new System.Drawing.Size(200, 80);
            this.ButtonTaskManage.TabIndex = 3;
            this.ButtonTaskManage.Text = "タスク管理";
            this.ButtonTaskManage.UseVisualStyleBackColor = true;
            this.ButtonTaskManage.Click += new System.EventHandler(this.ButtonTaskManage_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.ButtonOptions);
            this.Controls.Add(this.ButtonDaily);
            this.Controls.Add(this.ButtonTaskManage);
            this.Controls.Add(this.UCKeepingTasks);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlKeepingTasks UCKeepingTasks;
        private System.Windows.Forms.Button ButtonTaskManage;
        private System.Windows.Forms.Button ButtonDaily;
        private System.Windows.Forms.Button ButtonOptions;
    }
}

