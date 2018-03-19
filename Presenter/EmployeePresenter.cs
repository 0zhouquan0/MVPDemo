using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IView;
namespace Presenter
{
    public class EmployeePresenter : Presenter<IEmployeeView>
    {
        public BLL.Employee Mode
        { get; private set; }
        public EmployeePresenter(IEmployeeView view) : base(view)
        {

            this.Mode = new BLL.Employee();

        }
        protected override void OnViewSet()
        {
            this.View.Load += (object sender, EventArgs args) =>
           {

               List<Model.Employee> list = this.Mode.GetEmployee(null, null);
               this.View.ListEmployees(list);

               string[] educations = new string[] {"大专","本科","研究生" };
               this.View.ListEducation(educations);

           };
            this.View.EducationSelected += (object sender, EmployeeEventArgs args) =>
              {

                  List<Model.Employee> list = this.Mode.GetEmployee(args.CNO, args.Education);
                  this.View.ListEmployees(list);

              };
            this.View.EmployeeSearching += (object sender, EmployeeEventArgs args) =>
            {

                List<Model.Employee> list = this.Mode.GetEmployee(args.CNO, args.Education);
                this.View.ListEmployees(list);

            };


        }
    }
}
