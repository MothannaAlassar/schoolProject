using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SchoolProject.Assests
{
    class MyDataTable : DataTable
    {
        public static float SumAllColumn(DataTable dt, int columnIndex)
        {
            float sum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sum = sum + float.Parse(dt.Rows[i][columnIndex].ToString());
            }
            return sum;
        }
    }
}
