using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS
{
    public partial class employee
    {
        public string designame
        {
            get
            {
                if (designation == null)
                {
                    return "";
                }
                return designation.desigName;
            }
        }
        public int deptId
        {
            get
            {
                if(this.department==null)
                {
                    return 0;
                }
                return this.department.deptId;
            }
            set
            {
                this.department.deptId = value;
            }
        }
        public string deptName
        {
            get
            {
                if (this.department == null)
                {
                    return "";
                }
                return this.department.deptName;
            }
            set
            {
               
                this.department.deptName = value;
            }
        }
        public int desigId
        {
            get
            {
                if (this.designation == null)
                {
                    return 0;
                }
                return this.designation.desigId;
            }
            set
            {
                this.designation.desigId = value;
            }
        }
        public string desigName
        {
            get
            {
                if (this.designation == null)
                {
                    return "";
                }
                return this.designation.desigName;
            }
            set
            {
                this.department.deptName = value;
            }
        }
        public string userId
        {
            get
            {
                if (this.user == null)
                {
                    return "";
                }
                return this.user.userId;
            }
            set
            {
                this.user.userId = value;
            }
        }
        public string pass
        {
            get
            {
                if (this.user == null)
                {
                    return "";
                }
                return this.user.pass;
            }
            set
            {
                this.user.pass = value;
            }
        }
        public string utypeName
        {
            get
            {
                if (this.usertype == null)
                {
                    return "";
                }
                return this.usertype.utypeName;
            }
            set
            {
                this.usertype.utypeName = value;
            }
        }
        public int utypeId
        {
            get
            {
                if (this.usertype == null)
                {
                    return 0;
                }
                return this.usertype.utypeId;
            }
            set
            {
                this.usertype.utypeId = value;
            }
        }
        
    }
}
