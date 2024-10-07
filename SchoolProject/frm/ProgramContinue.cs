using SchoolProject.Assests;
using SchoolProject.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SchoolProject.frm
{
    public partial class ProgramContinue : BaseForm
    {
        BL.CLS_Room rm = new BL.CLS_Room();
BL.CLS_Class Addsrc = new BL.CLS_Class();
BL.CLS_Level lvl = new CLS_Level();
String type;
int IdRec;
Panel[] pipe;
MyMessageBox mmb; 
DataTable dt;
        Button[] ButtonState=new Button[100];
        NotifiForm nf;
public ProgramContinue()
{
InitializeComponent();
pipe = new Panel[] { ahd, athnin, thlathaa, arbaa, khamis, jumaa, sbt }; RefreshColor();
nf = new NotifiForm("",1);
nf.Visible = false;
}
public void RefreshColor()
{
   // TopPanel.BackColor = Assests.CLS_Setting.ColorApp;
    //logo.BackColor = Assests.CLS_Setting.ColorApp;
    //button1.BackColor = Assests.CLS_Setting.ColorApp;
    button2.BackColor = Assests.CLS_Setting.ColorApp;
    button3.BackColor = Assests.CLS_Setting.ColorApp;
    
}
private void btnClose_Click(object sender, EventArgs e)
{
this.Close();
}
private void btnOk_Click(object sender, EventArgs e)
{

}
public void OverSem(Control sender)
{
    //nf.Location = new Point(sender.Location.X,sender.Size.Height+sender.Location.Y);
    
    //nf.ShowDialog();
}
    private void Class_Load(object sender, EventArgs e)
    {
    
    }
    public  void ClickSem(int id)
    {
        ComeAndLeave cal = new ComeAndLeave(Int32.Parse(dt.Rows[id][0].ToString()), Assests.CLS_Setting.date2String(dtpDay.Value), Int32.Parse(dt.Rows[id][2].ToString()));
        cal.ShowDialog(this);
        this.ahd.Controls.Clear();
        this.athnin.Controls.Clear();
        this.thlathaa.Controls.Clear();
        this.arbaa.Controls.Clear();
        this.khamis.Controls.Clear();
        this.jumaa.Controls.Clear();
        this.sbt.Controls.Clear();
        dt = rm.AllSemForRoom(Int32.Parse(cmbRoom.Text));
        loadRoom(dt);
    }
    private void btnClose_Click_1(object sender, EventArgs e)
    {
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        Close();
    }
    public int getlengthSem(DateTime d1,DateTime d2)
    {
        int dif = Assests.CLS_SqlToStringDate.SubTime(d1,d2);
        
       dif = ConvertRat(dif);

        return dif;
    }
    public int ConvertRat(int input)
    {
        return (int)(input * 1300 / (60 * 15));
    }
    public void loadRoom(DataTable dt)
    {
        for (int i = 0; i < dt.Rows.Count;i++ )
        {
            String dtime_s1=dt.Rows[i][4].ToString();
            
            String dtime_s2=dt.Rows[i][5].ToString();
            DateTime dtime1 = Assests.CLS_SqlToStringDate.ConvertString2Time(dtime_s1);
            DateTime dtime2 = Assests.CLS_SqlToStringDate.ConvertString2Time(dtime_s2);
            
            DateTime dtimeDefault = new DateTime(2017, 1, 1,6,0,0);
            ButtonState[i] = new MyButtonSem(dt.Rows[i][1].ToString(), i, getlengthSem(dtime1, dtimeDefault), 2, this, getlengthSem(dtime2, dtime1));
            this.pipe[Int32.Parse(dt.Rows[i][3].ToString())].Controls.Add(ButtonState[i]);
        }
    }
    private void button3_Click(object sender, EventArgs e)
    {
        if (cmbRoom.SelectedIndex >= 0)
        {
            AddSem asem = new AddSem(Int32.Parse(cmbRoom.Text),dt);
            asem.ShowDialog(this);
            dt=rm.AllSemForRoom(Int32.Parse(cmbRoom.Text));
             dt = rm.AllSemForRoom(Int32.Parse(cmbRoom.Text));
             loadRoom(dt);

        }
        else
        {
            mmb = new MyMessageBox("حدد القاعة");
            mmb.ShowDialog(this);
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void TopPanel_Click(object sender, EventArgs e)
    {

    }
        
    private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.ahd.Controls.Clear();
        this.athnin.Controls.Clear();
        this.thlathaa.Controls.Clear();
        this.arbaa.Controls.Clear();
        this.khamis.Controls.Clear();
        this.jumaa.Controls.Clear();
        this.sbt.Controls.Clear();

        dt = rm.AllSemForRoom(Int32.Parse(cmbRoom.Text));
        loadRoom(dt);
    }
}
}
