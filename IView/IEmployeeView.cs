using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IView
{
    public interface IEmployeeView
    {
        event EventHandler Load;//加载事件

        event EventHandler<EmployeeEventArgs> EmployeeSearching;//员工查询

        event EventHandler<EmployeeEventArgs> EducationSelected;//下拉框选择

        void ListEmployees(List<Model.Employee> employees);//绑定数据(列表)

        void ListEducation(string[] list);//绑定下拉列表


    }
    public class EmployeeEventArgs : EventArgs
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        public string  CNO { get; set; }

        /// <summary>
        /// 教育程度
        /// </summary>
        public string Education { get; set; }



    }
}
