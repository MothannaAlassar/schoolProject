
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.DataModel
{
    class CustomPropertiesClass
    {

    }
    public partial class ExamPeriod
    {
        public string PeriodName
        {
            get
            {
                return this.Period.Name;
            }
        }
        public int ExamDuration
        {
            get
            {   int h = (this.ToTime.Value.TimeOfDay.Hours - this.FromTime.Value.TimeOfDay.Hours) * 60;
                int m = (this.ToTime.Value.TimeOfDay.Minutes - this.FromTime.Value.TimeOfDay.Minutes);
                return h + m;
            }
        }
    }
    public partial class GetDistributeStudent_Result
    {
        public int ExamDuration
        {
            get
            {
                int h = (this.ToTime.Value.TimeOfDay.Hours - this.FromTime.Value.TimeOfDay.Hours) * 60;
                int m = (this.ToTime.Value.TimeOfDay.Minutes - this.FromTime.Value.TimeOfDay.Minutes);
                return h + m;
            }
        }
    }
    public partial class TableExam
    {
        public String LevelName
        {
            get
            {
               
                return this.level.levelname;
            }
        }
        public string PeriodName
        {
            get
            {
                return this.ExamPeriod.Period.Name;
            }
        }
        public String CourseName
        {
            get
            {
                return this.course.coursename;
            }
        }

        public int CourseCountLetters
        {
            get
            {
                return this.course.coursename.Count();
            }
        }
    }
   public partial class RoomStudentInExam
    {
        public string PeriodName
        {
            get
            {
                return this.ExamPeriod.Period.Name;
            }
        }
    }
    public partial class student
    {
        alhaqldbEntities ctx = Factory.CreateCtx();
        public string StudentState
        {
            get
            {
                if(myear!=null)
                {
                    var obj = ctx.StudentLevels.FirstOrDefault(a => a.StdID == this.ID && a.YearID == myear.seqid);
                    if (obj != null)
                        return obj.lvlState;
                    else
                        return this.lvlState;
                }

                else
                    return this.lvlState;


            }
        }
        studyYear myear = DataModel.Connection.getCurrentYear();

        public int StudentGroupID
        {
            get
            {

                return this.StudentLevels.FirstOrDefault(a => a.YearID == myear.seqid)?.GroupID??0;
            }
        }
        public int StudentCurrentlevel
        {
            get
            {
                return this.StudentLevels.Where(a => a.studyYear.IsActive == true).FirstOrDefault().LevelID ?? 0;
            }
        }

        public string StudentCurrentGroup
        {
            get
            {
                return this.StudentLevels.Where(a => a.studyYear.IsActive == true).FirstOrDefault().sgroup;
            }
        }
    }
    public partial class PageOperaion
    {
        public string FullOperationNme
        {
            get
            {
                return this.Page.PageTitle + " >>" + this.OperationName;
            }
        }
    }
    public partial class LectureWeek
    {
        public string LevelName
        {
            get
            {
                return this.level.levelname;
            }
        }
        public string CourseName
        {
            get
            {
                return this.course.coursename;
            }
        }
        public string TermName
        {
            get
            {
                return this.term.termname;
            }
        }
        public string NameOfLecture
        {
            get
            {
                return this.GetLectureName(this.NumLecture ?? 0);
            }
        }
        public string NameOfDay
        {
            get
            {
                return this.getDayNameArabic(this.CdayNum ?? 0);
            }
        }
        string getDayNameArabic(int dt)
        {
            if (dt == 1)
                return "السبت";
            if (dt == 2)
                return "الاحد";
            if (dt == 3)
                return "الاثنين";
            if (dt == 4)
                return "الثلاثاء";
            if (dt == 5)
                return "الاربعاء";
            if (dt == 6)
                return "الخميس";
            if (dt == 7)
                return "الجمعة";
            else return "";
        }
        
        private  string GetLectureName(int lecnum)
        {
            switch (lecnum)
            {
                case 1:
                    return "الحصة الاولى";
                case 2:
                    return "الحصة الثانية";
                case 3:
                    return "الحصة الثالثة";
                case 4:
                    return "الحصة الرابعة";
                case 5:
                    return "الحصة الخامسة";
                    case 6:
                    return "الحصة السادسة";
                default:
                    return "";
            }
        } 
    }

  public partial class StudentLevel
    {
        public string StudentName
        {
            get
            {
                return this.student.sname + " " + this.student.LastName;
            }
        }
        public string YearName
        {
            get
            {
                return this.studyYear.studyYearEngl;
            }
        }
    }
    public partial class proc_GetFinalResultStudentNew_Result
    {
        // DataModel.alhaqldbEntities ctx = DataModel.Factory.CreateCtx();
        //int year=DataModel.Connection.
        //  List<DataModel.LevelCourse> lstvc = new List<LevelCourse>();

        Double SetMinDegree()
        {

            double rtv = 0;
            foreach (var p in CustomOperationCall.GetCourseActive(this.levelid ?? 0, this.yearID ?? 0))
            {
                if (p.CourseID == 1 && p.IsActive == true && p.maxDegree > this.qrnTotal)
                    rtv += p.maxDegree - this.qrnTotal ?? 0;
                else if (p.CourseID == 2 && p.IsActive == true && p.maxDegree > this.IslamicTotal)
                    rtv += p.maxDegree - this.IslamicTotal ?? 0;
                else if (p.CourseID == 3 && p.IsActive == true && p.maxDegree > this.ArabicTotal)
                    rtv += p.maxDegree - this.ArabicTotal ?? 0;
                else if (p.CourseID == 4 && p.IsActive == true && p.maxDegree > this.EnglishTotal)
                    rtv += p.maxDegree - this.EnglishTotal ?? 0;
                else if (p.CourseID == 5 && p.IsActive == true && p.maxDegree > this.MathTotal)
                    rtv += p.maxDegree - this.MathTotal ?? 0;
                else if (p.CourseID == 6 && p.IsActive == true && p.maxDegree > this.ScoTotal)
                    rtv += p.maxDegree - this.ScoTotal ?? 0;
                else if (p.CourseID == 7 && p.IsActive == true && p.maxDegree > this.SciTotal)
                    rtv += p.maxDegree - this.SciTotal ?? 0;
                else if (p.CourseID == 8 && p.IsActive == true && p.maxDegree > this.CompTotal)
                    rtv += p.maxDegree - this.CompTotal ?? 0;
                else if (p.CourseID == 9 && p.IsActive == true && p.maxDegree > this.ArtTotal)
                    rtv += p.maxDegree - this.ArtTotal ?? 0;
                else if (p.CourseID == 10 && p.IsActive == true && p.maxDegree > this.SportTotal)
                    rtv += p.maxDegree - this.SportTotal ?? 0;

                else if (p.CourseID == 11 && p.IsActive == true && p.maxDegree > this.PhysicTotal)
                    rtv += p.maxDegree - this.PhysicTotal ?? 0;
                else if (p.CourseID == 12 && p.IsActive == true && p.maxDegree > this.chemistryTotal)
                    rtv += p.maxDegree - this.chemistryTotal ?? 0;
                else if (p.CourseID == 13 && p.IsActive == true && p.maxDegree > this.BiologyTotal)
                    rtv += p.maxDegree - this.BiologyTotal ?? 0;
                else if (p.CourseID == 14 && p.IsActive == true && p.maxDegree > this.GeographicTotal)
                    rtv += p.maxDegree - this.GeographicTotal ?? 0;
                else if (p.CourseID == 15 && p.IsActive == true && p.maxDegree > this.History1Total)
                    rtv += p.maxDegree - this.History1Total ?? 0;
                else if (p.CourseID == 16 && p.IsActive == true && p.maxDegree > this.Community1Total)
                    rtv += p.maxDegree - this.Community1Total ?? 0;
            }
            return rtv;
        }
        public double prcnt
        {
            get
            {
                if (this.lvlCourseCount <= 0)
                    return 0;
                return Math.Round((this.ttl??0) / (this.lvlCourseCount??0),2);
            }
        }
        public string ResultTxt
        {
            get
            {
                if (this.cntApsentCourse > 0 && this.coursFialCount > 0)
                    return "3";
                else if (this.coursFialCount > 0)
                    return "2";
                else if (this.coursFialCount <= 0)
                    return "1";
                else return "1";
            }
        }
       
        
        public Double ToataNeedForFull
        {
            get
            {
                return  SetMinDegree();
            }
        }
    }
    public partial class studentdegree
    {
        public double TotalDegree
        {
            get
            {
                return ((this.deg1 ?? 0) + (this.deg2 ?? 0));
            }

        }

        public string StudentFullName
        {
            get
            {
                return this.student.sname?.Trim();
            }
        }
        public string StudentGender
        {
            get
            {
                return this.student.gender;
            }
        }
        public string StudentLastName
        {
            get
            {
                return this.student.LastName?.Trim();
            }
        }
        public string LevelName
        {
            get
            {
                return this.level.levelname;
            }
        }
        alhaqldbEntities ctx = DataModel.Factory.CreateCtx();
        public string CourseName
        {
            get
            {
                return ctx.courses.FirstOrDefault(a => a.courseid == this.courseID).coursename;
            }
        }
        public string TermName
        {
            get
            {
                return this.term.termname;
            }
        }
        public void RefreshEditing(DataModel.studentdegree obj)
        {
            //obj.TotalDegree= obj.deg1 ?? 0 + obj.deg2 ?? 0;

        }
    }

    //prcnt
    public partial class proc_GetResultFinalStudent_Result
    {
        DataModel.alhaqldbEntities ctx = DataModel.Factory.CreateCtx();
        //int year=DataModel.Connection.
        List<DataModel.LevelCourse> lstvc = new List<LevelCourse>();
        
       Double SetMinDegree()
        {
            
            double rtv = 0;
            foreach(var p in CustomOperationCall.GetCourseActive(this.levelid,this.yearID))
            {
                if (p.CourseID == 1 && p.IsActive == true && p.maxDegree > this.QrnTotal)
                    rtv += p.maxDegree - this.QrnTotal ?? 0;
                else if (p.CourseID == 2 && p.IsActive == true && p.maxDegree > this.IslamicTotal)
                    rtv += p.maxDegree - this.IslamicTotal ?? 0;
                else if (p.CourseID == 3 && p.IsActive == true && p.maxDegree > this.ArbicTotal)
                    rtv += p.maxDegree - this.ArbicTotal ?? 0;
                else if (p.CourseID == 4 && p.IsActive == true && p.maxDegree > this.EngTotal)
                    rtv += p.maxDegree - this.EngTotal ?? 0;
                else if (p.CourseID == 5 && p.IsActive == true && p.maxDegree > this.MathTotal)
                    rtv += p.maxDegree - this.MathTotal ?? 0;
                else if (p.CourseID == 6 && p.IsActive == true && p.maxDegree > this.ScoTotal)
                    rtv += p.maxDegree - this.ScoTotal ?? 0;
                else if (p.CourseID == 7 && p.IsActive == true && p.maxDegree > this.SciTotal)
                    rtv += p.maxDegree - this.SciTotal ?? 0;
                else if (p.CourseID == 8 && p.IsActive == true && p.maxDegree > this.CompTotal)
                    rtv += p.maxDegree - this.CompTotal ?? 0;
                else if (p.CourseID == 9 && p.IsActive == true && p.maxDegree > this.ArtTotal)
                    rtv += p.maxDegree - this.ArtTotal ?? 0;
                else if (p.CourseID == 10 && p.IsActive == true && p.maxDegree > this.SportTotal)
                    rtv += p.maxDegree - this.SportTotal ?? 0;
            }
            return rtv;
        }
       public Double ToataNeedForFull
        {
            get
            {
               return SetMinDegree();
            }
        }
       
        public Double QrnTotal
        {
            get
            {
                return (this.QrnDegTotal1 ?? 0) + (this.QrnDegTotal2 ?? 0);
            }
        }

        public Double IslamicTotal
        {
            get
            {
                return (this.IslamicDegTotal1 ?? 0) + (this.IslamicDegTotal2 ?? 0);
            }
        }
        public Double ArbicTotal
        {
            get
            {
                return (this.arDegTotal1 ?? 0) + (this.arDegTotal2 ?? 0);
            }
        }
        public Double ArtTotal
        {
            get
            {
                return (this.artDegTotal1 ?? 0) + (this.artDegTotal2 ?? 0);
            }
        }
        public Double EngTotal
        {
            get
            {
                return (this.EnDegTotal1 ?? 0) + (this.EnDegTotal2 ?? 0);
            }
        }
        public Double MathTotal
        {
            get
            {
                return (this.mathDegTotal1 ?? 0) + (this.mathDegTotal2 ?? 0);
            }
        }
        public Double SciTotal
        {
            get
            {
                return (this.sciDegTotal1 ?? 0) + (this.sciDegTotal2 ?? 0);
            }
        }
        public Double ScoTotal
        {
            get
            {
                return (this.scoDegTotal1 ?? 0) + (this.scoDegTotal2 ?? 0);
            }
        }
        public Double SportTotal
        {
            get
            {
                return (this.sportDegTotal1 ?? 0) + (this.sportDegTotal2 ?? 0);
            }
        }
        public Double CompTotal
        {
            get
            {
                return (this.compDegTotal1 ?? 0) + (this.compDegTotal2 ?? 0);
            }
        }
    }
    public partial class Proc_GetFinalResultDataForTermNew_Result
    {
        public double PhysicTotalAll
        {
            get
            {
                return (this.PhysicDeg1 ?? 0) + (this.PhysicDeg2 ?? 0);
            }
        }
        public string PhysicGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.PhysicTotalAll);
            }
        }
        public string GeographicGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.GeographicTotal??0);
            }
        }
        public string HistoryGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.History1Total??0);
            }
        }
        public string CommunityGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.Community1Total??0);
            }
        }
        public double GeographicTotalAll
        {
            get
            {
                return (this.Geographic1 ?? 0) + (this.Geographic2 ?? 0);
            }
        }
        public double HistoryTotalAll
        {
            get
            {
                return (this.History1 ?? 0) + (this.History2 ?? 0);
            }
        }
        public double CommunityTotalAll
        {
            get
            {
                return (this.Community1 ?? 0) + (this.Community2 ?? 0);
            }
        }
        public double chemistryTotalAll
        {
            get
            {
                return (this.chemistryDeg1 ?? 0) + (this.chemistryDeg2 ?? 0);
            }
        }
        public string ChemistryGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.chemistryTotalAll);
            }
        }
        public double BiologyDegTotalAll
        {
            get
            {
                return (this.BiologyDeg1 ?? 0) + (this.BiologyDeg2 ?? 0);
            }
        }
        public string BiologyGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.BiologyDegTotalAll);
            }
        }
        public Double QrnTotal
        {
            get
            {
                return (this.Qrndeg1 ?? 0) + (this.Qrndeg2 ?? 0);
            }
        }
        public string QrnGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.QrnTotal);
            }
        }

        public Double IslamicTotal
        {
            get
            {
                return (this.Islamicdeg1 ?? 0) + (this.Islamicdeg2 ?? 0);
            }
        }
        public string IslamicGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.IslamicTotal);
            }
        }
        public Double ArbicTotal
        {
            get
            {
                return (this.ardeg1 ?? 0) + (this.ardeg2 ?? 0);
            }
        }
        public string ArabicGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.ArbicTotal);
            }
        }
        public Double ArtTotal
        {
            get
            {
                return (this.artdeg1 ?? 0) + (this.artdeg2 ?? 0);
            }
        }
        public string ArtGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.ArtTotal);
            }
        }
        public Double EngTotal
        {
            get
            {
                return (this.Endeg1 ?? 0) + (this.Endeg2 ?? 0);
            }
        }

        public string EngGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.EngTotal);
            }
        }
        public Double MathTotal
        {
            get
            {
                return (this.mathdeg1 ?? 0) + (this.mathdeg2 ?? 0);
            }
        }
        public string MathGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.MathTotal);
            }
        }
        public Double SciTotal
        {
            get
            {
                return (this.scideg1 ?? 0) + (this.scideg2 ?? 0);
            }
        }
        public string SciGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.SciTotal);
            }
        }
        public Double ScoTotal
        {
            get
            {
                return (this.scodeg1 ?? 0) + (this.scodeg2 ?? 0);
            }
        }
        public string scoGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.ScoTotal);
            }
        }
        public Double SportTotal
        {
            get
            {
                return (this.sportdeg1 ?? 0) + (this.sportdeg2 ?? 0);
            }
        }
        public string SportGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.SportTotal);
            }
        }
        public Double CompTotal
        {
            get
            {
                return (this.compdeg1 ?? 0) + (this.compdeg2 ?? 0);
            }
        }
        public string CompGradeRank
        {
            get
            {
                return CustomOperationCall.GetGradeRank(this.CompTotal);
            }
        }
        public string ResultTxt
        {
            get
            {
                if (this.amontapsentcourse > 0 && this.coursFialCount > 0)
                    return "3";
                else if (this.coursFialCount > 0)
                    return "2";
                else if (this.coursFialCount <= 0)
                    return "1";
                else return "1";
            }
        }
        public double prcnt
        {
            get
            {
                if (this.LevelCrsCounts > 0)
                    return Math.Round(((this.ttl ?? 0) / (this.LevelCrsCounts ?? 0)), 2);
                else
                    return 0;
            }
        }
    }
  
    public partial class Proc_GetStudentDataForTerm_Result
    {
        public Double QrnTotal
        {
            get
            {
                return (this.Qrndeg1 ?? 0) + (this.Qrndeg2 ?? 0);
            }
        }

        public Double IslamicTotal
        {
            get
            {
                return (this.Islamicdeg1 ?? 0) + (this.Islamicdeg2 ?? 0);
            }
        }
        public Double ArbicTotal
        {
            get
            {
                return (this.ardeg1 ?? 0) + (this.ardeg2 ?? 0);
            }
        }
        public Double ArtTotal
        {
            get
            {
                return (this.artdeg1 ?? 0) + (this.artdeg2 ?? 0);
            }
        }
        public Double EngTotal
        {
            get
            {
                return (this.Endeg1 ?? 0) + (this.Endeg2 ?? 0);
            }
        }
        public Double MathTotal
        {
            get
            {
                return (this.mathdeg1 ?? 0) + (this.mathdeg2 ?? 0);
            }
        }
        public Double SciTotal
        {
            get
            {
                return (this.scideg1 ?? 0) + (this.scideg2 ?? 0);
            }
        }
        public Double ScoTotal
        {
            get
            {
                return (this.scodeg1 ?? 0) + (this.scodeg2 ?? 0);
            }
        }
        public Double SportTotal
        {
            get
            {
                return (this.sportdeg1 ?? 0) + (this.sportdeg2 ?? 0);
            }
        }
        public Double CompTotal
        {
            get
            {
                return (this.compdeg1 ?? 0) + (this.compdeg2 ?? 0);
            }
        }
    }
    public partial class alhaqldbEntities : System.Data.Entity.DbContext
    {
        public alhaqldbEntities(string conn)
            : base(conn)
        {
        }
    }
}
