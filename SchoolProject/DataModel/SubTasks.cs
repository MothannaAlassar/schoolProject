using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
  public  class SubTasks
    {
        public static bool IsAuthorised(string PageName, string OpSymbol, int roleID = -1)
        {
            //System.GC.Collect();
            bool ret = false;
            try
            {
                ret = (UserScope.UserData?.RoleActiveOperations?.Count(a => a.PageName.Equals(PageName ?? "") && a.OperationSymbol.Equals(OpSymbol ?? "")) ?? 0) > 0;

            }
            catch { ret = false; }
            return ret;

        }
        public static System.Drawing.Color GetTaskColor(int TaskStage, System.Drawing.Color dfltColor)
        {
            switch (TaskStage)
            {
                case 0: return System.Drawing.Color.Red;
                case 1: return System.Drawing.Color.Pink;
                case 2: return System.Drawing.Color.Green;
                case 3: return System.Drawing.Color.Yellow;
                default: return dfltColor;
            }
        }
    }
}
