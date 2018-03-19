using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employee
    {
        private readonly DAL.Employee dal = new DAL.Employee();
        /// <summary>
        /// 获取员工
        /// </summary>
        /// <returns></returns>
        public List<Model.Employee> GetEmployee(string cno, string education)
        {

            return dal.GetEmployee(cno,education);

        }




    }
}
