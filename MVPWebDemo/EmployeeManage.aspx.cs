using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IView;
using Model;
using Presenter;

namespace MVPWebDemo
{
    public partial class EmployeeManage : System.Web.UI.Page, IEmployeeView
    {
        private readonly EmployeePresenter _presenter;
        /// <summary>
        /// 构造函数
        /// </summary>
        public EmployeeManage()
        {
            _presenter = new EmployeePresenter(this);
        }

        #region 实现接口
        public new  event EventHandler Load;
        public event EventHandler<EmployeeEventArgs> EmployeeSearching;
        public event EventHandler<EmployeeEventArgs> EducationSelected;

        public void ListEducation(string[] list)
        {
            this.ddl_employeeState.DataSource = list;
            this.ddl_employeeState.DataBind();
            this.ddl_employeeState.Items.Insert(0, new ListItem { Text = "请选择", Value = "" });
        }

        public void ListEmployees(List<Employee> employees)
        {
            this.gv_employee.DataSource = employees;
            this.gv_employee.DataBind();
        }




        #endregion
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.Load != null)
                {
                    this.Load(sender, e);
                }
            }
           
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_search_Click(object sender, EventArgs e)
        {
            if (this.EmployeeSearching!=null)
            {
                this.EmployeeSearching(sender, new EmployeeEventArgs { CNO = this.txt_cno.Text.Trim(), Education = this.ddl_employeeState.SelectedValue });
            }
        }
        /// <summary>
        /// 下拉选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddl_employeeState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.EducationSelected != null)
            {
                this.EducationSelected(sender, new EmployeeEventArgs { CNO = this.txt_cno.Text.Trim(), Education = this.ddl_employeeState.SelectedValue });
            }
        }
    }
}