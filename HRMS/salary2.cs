using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    public partial class salary
    {

        public string empName
        {
            get
            {
                if (employee == null)
                {
                    return "";
                }
                return employee.empName;
            }
        }
        public string desigName
        {
            get
            {
                if (employee == null)
                {
                    return "";
                }
                return employee.designame;

            }
        }
    }
}
