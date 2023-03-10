namespace TaskManageAdvisor
{
    partial class UserControlKeepingTasks
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElapsedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaberMonth = new System.Windows.Forms.Label();
            this.ButtonSwitchLastMonth = new System.Windows.Forms.Button();
            this.ButtonSwitchNextMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Status,
            this.PlanningTime,
            this.Tasks,
            this.Items,
            this.ElapsedTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(758, 500);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(758, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.HeaderText = "状態";
            this.Status.Name = "Status";
            // 
            // PlanningTime
            // 
            this.PlanningTime.HeaderText = "計画時間";
            this.PlanningTime.Name = "PlanningTime";
            // 
            // Tasks
            // 
            this.Tasks.HeaderText = "タスク";
            this.Tasks.Name = "Tasks";
            this.Tasks.Width = 150;
            // 
            // Items
            // 
            this.Items.HeaderText = "項目";
            this.Items.Name = "Items";
            this.Items.Width = 306;
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.HeaderText = "経過時間";
            this.ElapsedTime.Name = "ElapsedTime";
            // 
            // LaberMonth
            // 
            this.LaberMonth.AutoSize = true;
            this.LaberMonth.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LaberMonth.Location = new System.Drawing.Point(311, 12);
            this.LaberMonth.Name = "LaberMonth";
            this.LaberMonth.Size = new System.Drawing.Size(115, 32);
            this.LaberMonth.TabIndex = 1;
            this.LaberMonth.Text = "yyyy/MM";
            // 
            // ButtonSwitchLastMonth
            // 
            this.ButtonSwitchLastMonth.Location = new System.Drawing.Point(263, 12);
            this.ButtonSwitchLastMonth.Name = "ButtonSwitchLastMonth";
            this.ButtonSwitchLastMonth.Size = new System.Drawing.Size(31, 32);
            this.ButtonSwitchLastMonth.TabIndex = 2;
            this.ButtonSwitchLastMonth.Text = "<";
            this.ButtonSwitchLastMonth.UseVisualStyleBackColor = true;
            // 
            // ButtonSwitchNextMonth
            // 
            this.ButtonSwitchNextMonth.Location = new System.Drawing.Point(441, 12);
            this.ButtonSwitchNextMonth.Name = "ButtonSwitchNextMonth";
            this.ButtonSwitchNextMonth.Size = new System.Drawing.Size(29, 32);
            this.ButtonSwitchNextMonth.TabIndex = 3;
            this.ButtonSwitchNextMonth.Text = ">";
            this.ButtonSwitchNextMonth.UseVisualStyleBackColor = true;
            // 
            // UserControlKeepingTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonSwitchNextMonth);
            this.Controls.Add(this.ButtonSwitchLastMonth);
            this.Controls.Add(this.LaberMonth);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlKeepingTasks";
            this.Size = new System.Drawing.Size(782, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElapsedTime;
        private System.Windows.Forms.Label LaberMonth;
        private System.Windows.Forms.Button ButtonSwitchLastMonth;
        private System.Windows.Forms.Button ButtonSwitchNextMonth;
    }
}
