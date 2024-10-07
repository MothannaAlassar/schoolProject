using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //System.Data.SqlClient.SqlDataAdapter ad;
            //using (var sqlconn = new System.Data.SqlClient.SqlConnection(GetConnectionString()))
            //{
            //    using (var cmd = new System.Data.SqlClient.SqlCommand("select * dbo.Reportings ", sqlconn))
            //    {
            //        ad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            //    }

            //}
            //return ad;
        }
        string sql = @"select *, case when coursFialCount<=0 then RamkByGroupInner else '' end RamkByGroup
,case when coursFialCount<=0 then RamkByLevelInner else '' end RamkByLevel 
,round((ttl/lvlCourseCount),2) avarage from 
(
select sd.studentid ,sd.levelid,sd.yearID
--,  stl.stdid
  , st.sname
  , st.LastName
  --, st.levelid
  , st.bdate
  , st.BirthPlace
  , st.gender
  , stl.sgroup
  , stl.GroupID
  , stl.lvlState
  , isnull(st.IsLeave,0) IsLeave
  , st.SeqID
  , st.natianalityt
  , (select lv.levelname from levels lv where lv.levelid=sd.levelid) levelname

,sum(case when sd.termid=1 and sd.courseID=1 then sd.TotalAll else 0 end) qrn1
,sum(case when sd.termid=2 and sd.courseID=1 then sd.TotalAll else 0 end) qrn2
,sum(case when sd.courseID=1 then sd.forFull else 0 end) qrnForFull
,sum(case when sd.courseID=1 then sd.TotalAll else 0 end) qrnTotal

,sum(case when sd.termid=1 and sd.courseID=2 then sd.TotalAll else 0 end) Islamic1
,sum(case when sd.termid=2 and sd.courseID=2 then sd.TotalAll else 0 end) Islamic2
,sum(case when sd.courseID=2 then sd.forFull else 0 end) IslamicForFull
,sum(case when sd.courseID=2 then sd.TotalAll else 0 end) IslamicTotal

,sum(case when sd.termid=1 and sd.courseID=3 then sd.TotalAll else 0 end) Arabic1
,sum(case when sd.termid=2 and sd.courseID=3 then sd.TotalAll else 0 end) Arabic2
,sum(case when sd.courseID=3 then sd.forFull else 0 end) ArabicForFull
,sum(case when sd.courseID=3 then sd.TotalAll else 0 end) ArabicTotal

,sum(case when sd.termid=1 and sd.courseID=4 then sd.TotalAll else 0 end) English1
,sum(case when sd.termid=2 and sd.courseID=4 then sd.TotalAll else 0 end) English2
,sum(case when sd.courseID=4 then sd.forFull else 0 end) EnglishForFull
,sum(case when sd.courseID=4 then sd.TotalAll else 0 end) EnglishTotal

,sum(case when sd.termid=1 and sd.courseID=5 then sd.TotalAll else 0 end) Math1
,sum(case when sd.termid=2 and sd.courseID=5 then sd.TotalAll else 0 end) Math2
,sum(case when sd.courseID=5 then sd.forFull else 0 end) MathForFull
,sum(case when sd.courseID=5 then sd.TotalAll else 0 end) MathTotal

,sum(case when sd.termid=1 and sd.courseID=6 then sd.TotalAll else 0 end) Socil1
,sum(case when sd.termid=2 and sd.courseID=6 then sd.TotalAll else 0 end) Socil2
,sum(case when sd.courseID=6 then sd.forFull else 0 end) ScoForFull
,sum(case when sd.courseID=6 then sd.TotalAll else 0 end) ScoTotal

,sum(case when sd.termid=1 and sd.courseID=7 then sd.TotalAll else 0 end) Sciense1
,sum(case when sd.termid=2 and sd.courseID=7 then sd.TotalAll else 0 end) Sciense2
,sum(case when sd.courseID=7 then sd.forFull else 0 end) SciForFull
,sum(case when sd.courseID=7 then sd.TotalAll else 0 end) SciTotal

,sum(case when sd.termid=1 and sd.courseID=8 then sd.TotalAll else 0 end) Comp1
,sum(case when sd.termid=2 and sd.courseID=8 then sd.TotalAll else 0 end) Comp2
,sum(case when sd.courseID=8 then sd.forFull else 0 end) ComputerForFull
,sum(case when sd.courseID=8 then sd.TotalAll else 0 end) CompTotal

,sum(case when sd.termid=1 and sd.courseID=9 then sd.TotalAll else 0 end) Art1
,sum(case when sd.termid=2 and sd.courseID=9 then sd.TotalAll else 0 end) Art2
,sum(case when sd.courseID=9 then sd.forFull else 0 end) ArtForFull
,sum(case when sd.courseID=9 then sd.TotalAll else 0 end) ArtTotal

,sum(case when sd.termid=1 and sd.courseID=10 then sd.TotalAll else 0 end) Sport1
,sum(case when sd.termid=2 and sd.courseID=10 then sd.TotalAll else 0 end) Sport2
,sum(case when sd.courseID=10 then sd.forFull else 0 end) SportForFull
,sum(case when sd.courseID=10 then sd.TotalAll else 0 end) SportTotal

,sum(case when sd.termid=1 and sd.courseID=11 then sd.TotalAll else 0 end) Physic1
,sum(case when sd.termid=2 and sd.courseID=11 then sd.TotalAll else 0 end) Physic2
,sum(case when sd.courseID=11 then sd.forFull else 0 end) PhysicForFull
,sum(case when sd.courseID=11 then sd.TotalAll else 0 end) PhysicTotal

,sum(case when sd.termid=1 and sd.courseID=12 then sd.TotalAll else 0 end) chemistry1
,sum(case when sd.termid=2 and sd.courseID=12 then sd.TotalAll else 0 end) chemistry2
,sum(case when sd.courseID=12 then sd.forFull else 0 end) chemistryForFull
,sum(case when sd.courseID=12 then sd.TotalAll else 0 end) chemistryTotal

,sum(case when sd.termid=1 and sd.courseID=13 then sd.TotalAll else 0 end) Biology1
,sum(case when sd.termid=2 and sd.courseID=13 then sd.TotalAll else 0 end) Biology2
,sum(case when sd.courseID=13 then sd.forFull else 0 end) BiologyForFull
,sum(case when sd.courseID=13 then sd.TotalAll else 0 end) BiologyTotal

,sum(case when sd.termid=1 and sd.courseID=14 then sd.TotalAll else 0 end) Geographic1
,sum(case when sd.termid=2 and sd.courseID=14 then sd.TotalAll else 0 end) Geographic2
,sum(case when sd.courseID=14 then sd.forFull else 0 end) GeographicFull
,sum(case when sd.courseID=14 then sd.TotalAll else 0 end) GeographicTotal

,sum(case when sd.termid=1 and sd.courseID=15 then sd.TotalAll else 0 end) History1
,sum(case when sd.termid=2 and sd.courseID=15 then sd.TotalAll else 0 end) History2
,sum(case when sd.courseID=15 then sd.forFull else 0 end) HistoryFull
,sum(case when sd.courseID=15 then sd.TotalAll else 0 end) History1Total

,sum(case when sd.termid=1 and sd.courseID=16 then sd.TotalAll else 0 end) Community1
,sum(case when sd.termid=2 and sd.courseID=16 then sd.TotalAll else 0 end) Community2
,sum(case when sd.courseID=16 then sd.forFull else 0 end) Community1Full
,sum(case when sd.courseID=16 then sd.TotalAll else 0 end) Community1Total

,ISNULL((select tms.TotalMins from GetTotalMinsGrade() tms where tms.LevelID=sd.levelid and tms.studentid=sd.studentid and tms.YearID=sd.yearID),0) ttmines
,case when (sum(case when sd.courseID=1 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=1 then sd.TotalAll else 0 end)-50 else 0 end qrnmins
,case when (sum(case when sd.courseID=2 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=2 then sd.TotalAll else 0 end)-50 else 0 end IslamicMins
,case when (sum(case when sd.courseID=3 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=3 then sd.TotalAll else 0 end)-50 else 0 end ArabicMM
,case when (sum(case when sd.courseID=5 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=5 then sd.TotalAll else 0 end)-50 else 0 end MathMins
,case when (sum(case when sd.courseID=4 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=4 then sd.TotalAll else 0 end)-50 else 0 end EngMins
,case when (sum(case when sd.courseID=6 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=6 then sd.TotalAll else 0 end)-50 else 0 end ScoMins
,case when (sum(case when sd.courseID=7 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=7 then sd.TotalAll else 0 end)-50 else 0 end SciMins
,case when (sum(case when sd.courseID=8 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=8 then sd.TotalAll else 0 end)-50 else 0 end CompMins
,case when (sum(case when sd.courseID=9 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=9 then sd.TotalAll else 0 end)-50 else 0 end ArtMins
,case when (sum(case when sd.courseID=10 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=10 then sd.TotalAll else 0 end)-50 else 0 end SportMins
,case when (sum(case when sd.courseID=11 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=11 then sd.TotalAll else 0 end)-50 else 0 end PhysicMins
,case when (sum(case when sd.courseID=12 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=12 then sd.TotalAll else 0 end)-50 else 0 end ChemistryMins
,case when (sum(case when sd.courseID=13 then sd.TotalAll else 0 end)-50)<0 then sum(case when sd.courseID=13 then sd.TotalAll else 0 end)-50 else 0 end BiologyMins


,isnull(SUM(case when (sd.forFull>0) then 1 else 0 end ),0) CountCourseForFull
,(select count(*)  from dbo.LevelCourse lvc where lvc.LevelID=sd.levelid and lvc.IsActive=1 and lvc.termID=2 and lvc.PlanID =(select p.ID from Plans p where p.YearID=sd.yearID)) lvlCourseCount
,(select sum(d1.TotalAll) from studentdegree d1 inner join dbo.LevelCourse lvc on lvc.ID=d1.courseLevelID where lvc.IsActive=1 and d1.studentid=sd.studentid and d1.levelid=sd.levelid and d1.yearID=sd.yearID) ttl
,SUm(sd.forFull) TotalAllForFull
,DENSE_RANK() over ( partition by sd.yearid, sd.levelid order by sd.levelid,((select sum(d1.TotalAll) from studentdegree d1 inner join dbo.LevelCourse lvc on lvc.ID=d1.courseLevelID where lvc.IsActive=1 and d1.studentid=sd.studentid and d1.levelid=sd.levelid and d1.yearID=sd.yearID)
) desc) 
  as StudentRamkNumberByLevel
  ,(case  
DENSE_RANK() over ( partition by sd.yearid, sd.levelid order by sd.levelid,sum(sd.TotalAll) desc) 

when 1  then N'الأول' 
when 2  then N'الثاني'
when 3  then N'الثالث'
when 4  then N'الرابع'
when 5  then N'الخامس'
when 6  then N'السادس'
when 7  then N'السابع'
when 8  then N'الثامن'
when 9  then N'التاسع'
when 10 then N'العاشر'
else	N''
end) 
  as RamkByLevelInner
  , 
DENSE_RANK() over ( partition by sd.yearid, sd.levelid,stl.GroupID order by sd.levelid,((select sum(d1.TotalAll) from studentdegree d1 inner join dbo.LevelCourse lvc on lvc.ID=d1.courseLevelID where lvc.IsActive=1 and d1.studentid=sd.studentid and d1.levelid=sd.levelid and d1.yearID=sd.yearID)
) desc) 
  as StudentRamkNumberByGroup
  ,(case  
DENSE_RANK() over ( partition by sd.yearid, sd.levelid,stl.GroupID order by sd.levelid,sum(sd.TotalAll) desc) 

when 1  then N'الأول' 
when 2  then N'الثاني'
when 3  then N'الثالث'
when 4  then N'الرابع'
when 5  then N'الخامس'
when 6  then N'السادس'
when 7  then N'السابع'
when 8  then N'الثامن'
when 9  then N'التاسع'
when 10 then N'العاشر'
else	N''
end)  
  as RamkByGroupInner
  , CASE WHEN st.gender = 'انثى' THEN 2 ELSE 1 END AS genderNumber
,(select count(*) from studentdegree d1 inner join dbo.LevelCourse lvc on lvc.ID=d1.courseLevelID where lvc.IsActive=1 and d1.amontapsentcourse>0 and d1.studentid=sd.studentid and d1.levelid=sd.levelid and d1.yearID=sd.yearID) cntApsentCourse
,isnull((select cf.coursFialCount from dbo.GetCourseFail() cf where cf.levelid=sd.levelid and cf.studentid=sd.studentid and cf.YearID=sd.yearID),0) coursFialCount
,(select count(*) from StudentLevels sl where sl.StdID=sd.studentid and sl.lvlState=N'معيد' AND SL.LevelID=SD.levelid and sl.YearID<=sd.yearID) countFailYear
from studentdegree sd inner join dbo.student st on st.ID=sd.studentid inner join dbo.StudentLevels stl on st.ID=stl.StdID and stl.LevelID=sd.levelid and stl.YearID=sd.yearID
 where stl.YearID=2010 and  
 st.IsDelete=0 and stl.LevelID=2  
group by sd.yearID, sd.levelid, sd.studentid 
       , st.sname
  , st.LastName
  --, st.levelid
  , st.bdate
  , st.BirthPlace
  , st.gender
  , stl.sgroup
  , stl.GroupID
  , stl.lvlState
  , st.IsLeave
  , st.SeqID
  , st.natianalityt
  ) tbl
  order by tbl.yearID, tbl.levelid,tbl.gender desc ,tbl.sname,tbl.LastName";
        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\WALEED\\Documents\\SchoolPublic.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataAdapter da;
            SqlConnection conn = new SqlConnection(constr);
            var cmd = new SqlCommand(sql, conn);
           

            // cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@yearid", 2010);
            //cmd.Parameters.AddWithValue("@levelid", 2);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            samDataGridView1.DataSource = dt;
           // cmd.ExecuteReader();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.TimeOfDay.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
