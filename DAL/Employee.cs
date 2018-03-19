using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {

        private IList<Model.Employee> _employees = new List<Model.Employee>{
            new Model.Employee{ ID=1, CNo="001", CreateDate=DateTime.Now, Education="研究生", EType=0, Gender=0, UserName="张三", WorkAddres="上海总部"  },
            new Model.Employee{ ID=2, CNo="002", CreateDate=DateTime.Now, Education="本科", EType=1, Gender=0, UserName="李四", WorkAddres="深圳分部"  },
            new Model.Employee{ ID=3, CNo="003", CreateDate=DateTime.Now, Education="大专", EType=1, Gender=0, UserName="王五", WorkAddres="武汉分部"  },
            new Model.Employee{ ID=3, CNo="004", CreateDate=DateTime.Now, Education="本科", EType=0, Gender=0, UserName="赵六", WorkAddres="武汉分部"  }
        };

        /// <summary>
        /// 获取员工
        /// </summary>
        /// <returns></returns>
        public List<Model.Employee> GetEmployee(string cno, string education)
        {

            var employees = (from p in _employees
                             where (string.IsNullOrEmpty(cno) || p.CNo.Contains(cno)) && (string.IsNullOrEmpty(education) || p.Education.Equals(education))
                             select p).ToList();

            return employees;

        }



    }
}
