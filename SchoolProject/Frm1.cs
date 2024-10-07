using SchoolProject.Properties;
using SchoolProject.PublicSetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class Frm1 : BaseForm
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            //fntItem = new Font("Arial", 11.25f, FontStyle.Bold);
            //fntColor = Color.Black;
            //Settings.Default.BackColur = Color.MediumAquamarine;
            //Settings.Default.FontStyleItem = fntItem;
            //Settings.Default.FontColorItem = fntColor;
            //Settings.Default.Save();
        }
        private void SetPropertyObject()
        {

            //switch (CtypeID)
            //{
            //    case CertificateType.None:
            //        break;
            //    case CertificateType.Sale:
            //        propertyGrid1.SelectedObject = new UI.SysConfigDir.PersistSaleConfig(CtypeID.ToString());
            //        break;
            //    default:
            //        break;
            //}
            propertyGrid1.SelectedObject = null;
            propertyGrid1.SelectedObject = new PublicSetting.PersistSysConfig("schoolPro");
            //propertyGrid1.SelectedObject = new UI.SysConfigDir.PersistSaleConfig(CtypeID.ToString());
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
           // fntItem = this.Font;
           // fntColor = this.ForeColor;
           
            // if(Settings.Default.ToolStripBackColor!=null)
            //toolStrip1.BackColor = Settings.Default.ToolStripBackColor;
            //panel1.BackColor = Settings.Default.BackColur;
            SetPropertyObject();
            gradeRankBindingSource.DataSource = ctx.GradeRanks.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fntItem = this.Font;

            var obj = propertyGrid1.SelectedObject as MainPersistConfig;
            if (obj != null)
            {
                if (MessageBox.Show("هل تريد حفظ التعيرات - " , "تاكيد العميلة", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    string rtv = obj.SaveData();
                    if (rtv.IsNull())
                        MessageBox.Show("تم حفظ التغييرات ");
                    else
                       MessageBox.Show(rtv);
                }
            }
            this.Refresh();
            ctx.SaveChanges();
            //var sysst= new PublicSetting.PersistAccountKashfConfig("schoolPro");
            //this.BackColor = sysst.BackColurSys;
            //this.ForeColor = sysst.ForColurSys;
            //var grst = new PublicSetting.PersistThemeConfig(CustControl.ThemeType.Grid);
            //samDataGridView1.ForeColor=
            //fntColor = this.ForeColor;
            //Settings.Default.BackColur = bckcolor;
            //Settings.Default.FontStyleItem = fntItem;
            //Settings.Default.FontColorItem = fntColor;
            //Settings.Default.ToolStripBackColor = toolStrip1.BackColor;
            //Settings.Default.Save();
        }
        Font fntItem=new Font("Arial", 11.25f,FontStyle.Bold);
        Color fntColor = Color.Black;
        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
        Color bckcolor = Color.LightBlue;
        private void propertyGrid1_BackColorChanged(object sender, EventArgs e)
        {
            bckcolor = propertyGrid1.BackColor;
        }

        private void propertyGrid1_FontChanged(object sender, EventArgs e)
        {
            fntItem = propertyGrid1.Font;
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = null;
            propertyGrid1.SelectedObject = new PublicSetting.PersistThemeConfig(CustControl.ThemeType.ToolStrip);
        }

        private void Frm1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = null;
            propertyGrid1.SelectedObject = new PublicSetting.PersistSysConfig("schoolPro");
        }

        private void samDataGridView1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = null;
            propertyGrid1.SelectedObject = new PublicSetting.PersistThemeConfig(CustControl.ThemeType.Grid);
        }

        private void samDataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (samDataGridView2.CurrentRow == null) return;
            if (samDataGridView2.CurrentCell == null) return;
            if (samDataGridView2.CurrentRow.IsNewRow) return;
            var crntCell = samDataGridView2.CurrentCell;
            var cllVal = e.FormattedValue;
            Current = gradeRankBindingSource.Current as DataModel.GradeRank;

            if (Current == null) return;
            var insobj = Current as DataModel.GradeRank;
            //if (lstrslt.Where(a => a.stdid == insobj.stdid && a.yearID == masterYear).Count() <= 0)
            //    lstrslt.Add(insobj);
            if ((crntCell.OwningColumn.Name == fromGradeDataGridViewTextBoxColumn.Name))
            {
                var obj = samDataGridView2.CurrentRow.DataBoundItem as DataModel.GradeRank;
                double dval;


                if (cllVal != null)
                {
                    if (!double.TryParse(cllVal.ToString(), out dval))
                    {

                        MessageBox.Show("قيم عددية فقط");
                        e.Cancel = true;
                    }
                    else if (dval < 0)
                    {
                        MessageBox.Show("قيم صحيحة موجبه فقط");
                        e.Cancel = true;
                    }
                    else if ((obj != null) && dval > 50)
                    {
                        MessageBox.Show("  حدد درجة صحيحة ");
                        if (obj.ID > 0)
                        {
                            if (crntCell.IsInEditMode)
                                e.Cancel = true;
                            else
                                SendKeys.Send("{ESC}");
                        }

                        else
                        {
                            if (obj != null)
                                crntCell.Value = "0";
                        }
                    }

                }

            }
            if ((crntCell.OwningColumn.Name == toGradeDataGridViewTextBoxColumn.Name))
            {
                var obj = samDataGridView2.CurrentRow.DataBoundItem as DataModel.GradeRank;
                double dval;


                if (cllVal != null)
                {
                    if (!double.TryParse(cllVal.ToString(), out dval))
                    {

                        MessageBox.Show("قيم عددية فقط");
                        e.Cancel = true;
                    }
                    else if (dval < 0)
                    {
                        MessageBox.Show("قيم صحيحة موجبه فقط");
                        e.Cancel = true;
                    }
                    else if ((obj != null) && dval > 50)
                    {
                        MessageBox.Show("  حدد درجة صحيحة ");
                        if (obj.ID > 0)
                        {
                            if (crntCell.IsInEditMode)
                                e.Cancel = true;
                            else
                                SendKeys.Send("{ESC}");
                        }

                        else
                        {
                            if (obj != null)
                                crntCell.Value = "0";
                        }
                    }

                }

            }
            double frmval = 0;
            if (!double.TryParse(samDataGridView2.CurrentRow.Cells[fromGradeDataGridViewTextBoxColumn.Name].ToString(), out frmval))
                frmval = 0;
            double toval = 0;
            if (!double.TryParse(samDataGridView2.CurrentRow.Cells[toGradeDataGridViewTextBoxColumn.Name].ToString(), out toval))
                toval = 0;
            if ( frmval>toval)
                {
                    MessageBox.Show("من درجة يجب ان تكون اقل من الى درجة");
                    e.Cancel = true;
                }
            
        }
    }
}
