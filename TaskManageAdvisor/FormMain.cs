using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManageAdvisor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// タスク管理ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTaskManage_Click(object sender, EventArgs e)
        {
            try
            {
                UCKeepingTasks.Visible = true;
            }
            catch(Exception ex)
            {
                //WinModuleLibrary.ErrorModule.ShowErrorLog(ex);
                //WinModuleLibrary.ErrorModule.ExportErrorLog(ex);
            }
        }
        /// <summary>
        /// デイリーボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDaily_Click(object sender, EventArgs e)
        {
            try {
                UCKeepingTasks.Visible = false;
            }
            catch (Exception ex)
            {
                //WinModuleLibrary.ErrorModule.ShowErrorLog(ex);
                //WinModuleLibrary.ErrorModule.ExportErrorLog(ex);
            }
        }
        /// <summary>
        /// 設定ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOptions_Click(object sender, EventArgs e)
        {
            try
            {
                UCKeepingTasks.Visible = false;
            }
            catch (Exception ex)
            {
                //WinModuleLibrary.ErrorModule.ShowErrorLog(ex);
                //WinModuleLibrary.ErrorModule.ExportErrorLog(ex);
            }
        }
    }
}
