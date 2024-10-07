using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
   public class ConnectionData
    {
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public bool MultipleActiveResultSets { get; set; }
        public int ConnectTimeout { get; set; }

        public ConnectionData(string DataSource, string InitialCatalog
            , string UserID, string Password, bool MultipleActiveResultSets
            , int ConnectTimeout)
        {
            this.DataSource = DataSource;
            this.InitialCatalog = InitialCatalog;
            this.UserID = UserID;
            this.Password = Password;
            this.MultipleActiveResultSets = MultipleActiveResultSets;
            this.ConnectTimeout = ConnectTimeout;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Data Source={0};", this.DataSource);
            sb.AppendFormat("Initial Catalog={0};Integrated Security=false;", this.InitialCatalog);
            sb.AppendFormat("User ID={0};", this.UserID);
            sb.AppendFormat("Password={0};", this.Password);
            sb.AppendFormat("MultipleActiveResultSets={0};", this.MultipleActiveResultSets);
            sb.AppendFormat("Connect Timeout={0};", this.ConnectTimeout);
            return sb.ToString();
        }
    }
}
