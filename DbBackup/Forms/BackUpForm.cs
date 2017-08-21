using CCWin;
using System;
using System.Windows.Forms;
using DbBackup.Common.DbOperate;
using DbBackup.Common.DbOperate.impl;
using System.Data.SqlClient;
using System.Configuration;

namespace DbBackup
{
    public partial class BackUpForm : Skin_Mac
    {
        #region 变量
        /// <summary>
        /// 服务器地址
        /// </summary>
        private string server = string.Empty;

        /// <summary>
        /// 数据库名称
        /// </summary>
        private string database = string.Empty;

        /// <summary>
        /// 登录名
        /// </summary>
        private string uid = string.Empty;

        /// <summary>
        /// 密码
        /// </summary>
        private string password = string.Empty;

        /// <summary>
        /// 备份路径
        /// </summary>
        private string path = string.Empty;
        #endregion 变量

        #region 初始化
        public BackUpForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体初始化
        /// </summary>
        /// <param name="sender">事件数据</param>
        /// <param name="e">事件监视对象</param>
        private void BackUpForm_Load(object sender, EventArgs e)
        {
            this.txtServer.Text = ConfigurationManager.AppSettings["server"].ToString();
            this.txtUid.Text = ConfigurationManager.AppSettings["uid"].ToString();
            this.txtPassword.Text = ConfigurationManager.AppSettings["password"].ToString();
            this.txtDatabase.Text = ConfigurationManager.AppSettings["database"].ToString();
            this.txtPath.Text = ConfigurationManager.AppSettings["path"].ToString();
        }
        #endregion 初始化

        #region 事件

        #region 备份
        /// <summary>
        /// 备份
        /// </summary>
        /// <param name="sender">事件数据</param>
        /// <param name="e">事件监视对象</param>
        private void btnBak_Click(object sender, EventArgs e) //备份
        {
            this.getDbOperateParams();
            DbOperate instance = new DbOperateBackUp(server, uid, password, database, path);
            try
            {
                bool isBak = instance.Operate();
                if (isBak)
                {
                    MessageBox.Show("你已经成功备份当前数据！", "系统消息");
                }
                else
                {
                    MessageBox.Show("备份数据失败！", "系统消息");
                }
            }
            catch (SqlException sexc)
            {
                MessageBox.Show("失败，可能是对数据库操作失败，原因：" + sexc, "数据库错误消息");
            }
            catch (Exception ex)
            {
                MessageBox.Show("对不起，操作失败，可能原因：" + ex, "系统消息");
            }
        }
        #endregion 备份

        #region 恢复
        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="sender">事件数据</param>
        /// <param name="e">事件监视对象</param>
        private void btnResotre_Click(object sender, EventArgs e)  //恢复
        {
            this.getDbOperateParams();
            DbOperate instance = new DbOperateRestore(server, uid, password, database, path);
            try
            {
                bool isRestore = instance.Operate();
                if (isRestore)
                {
                    MessageBox.Show("数据成功恢复为所选文档的状态！", "系统消息");
                }
                else
                {
                    MessageBox.Show("数据恢复失败！你已经成功备份当前数据！", "系统消息");
                }
            }
            catch (SqlException sexc)
            {
                MessageBox.Show("失败，可能是对数据库操作失败，原因：" + sexc, "数据库错误消息");
            }
            catch (Exception ex)
            {
                MessageBox.Show("对不起，操作失败，可能原因：" + ex, "系统消息");
            }
        }
        #endregion 恢复

        #endregion 事件

        #region 方法

        /// <summary>
        /// 获取db操作的参数
        /// </summary>
        private void getDbOperateParams() {
            server = this.txtServer.Text;
            uid = this.txtUid.Text;
            password = this.txtPassword.Text;
            database = this.txtDatabase.Text;
            path = this.txtPath.Text;
        }

        #endregion 方法
    }
}
