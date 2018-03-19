using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工管理
    /// </summary>
    [Serializable]
    public partial class Employee
    {
        private int _id;
        private string _cno;
        private string _username;
        private int _gender;
        private string _workaddres;
        private string _education;
        private DateTime? _createdate;
        private int _etype;

        public Employee()
        { }
        #region Model
    

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 工号
        /// </summary>
        public string CNo
        {
            set { _cno = value; }
            get { return _cno; }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public int Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }
       
        /// <summary>
        /// 工作地
        /// </summary>
        public string WorkAddres
        {
            set { _workaddres = value; }
            get { return _workaddres; }
        }
 


        /// <summary>
        /// 学历
        /// </summary>
        public string Education
        {
            set { _education = value; }
            get { return _education; }
        }


        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
      

        /// <summary>
        /// 类型，0：员工，1：兼职，2：离职,   3 删除
        /// </summary>
        public int EType
        {
            set { _etype = value; }
            get { return _etype; }
        }


        #endregion Model

    }
}
