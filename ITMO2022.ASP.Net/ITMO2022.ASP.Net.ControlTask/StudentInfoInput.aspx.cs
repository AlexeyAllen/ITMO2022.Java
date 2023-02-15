using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ITMO2022.ASP.Net.ControlTask
{
    public partial class StudentInfoInput : System.Web.UI.Page
    {
        StudentContext2 context = new StudentContext2();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) 
            {
                Page.Validate(); 
                if (!Page.IsValid) 
                    return;
                StudentInfo stinfo = new StudentInfo(firstName.Text, lastName.Text, email.Text,
                    phoneNumber.Text);

                GradeInfo grdinfo = new GradeInfo(Convert.ToByte(lesson1Mark.Text), Convert.ToByte(lesson2Mark.Text),
                    Convert.ToByte(lesson3Mark.Text), Convert.ToByte(lesson4Mark.Text),
                    Convert.ToByte(lesson5Mark.Text));

                try 
                {
                    //StudentContext2 context = new StudentContext2(); 
                    context.StudentInfos.Add(stinfo);
                    context.GradeInfos.Add(grdinfo);
                    context.SaveChanges(); 
                } 
                catch (Exception ex) 
                { 
                    Response.Redirect("Ошибка " + ex.Message); 
                }

                //StudentInfoRepository.GetStudentInfoRepository().AddStudentInfo(stinfo);

                Response.Redirect("InputDataAccepted.html");
            }
        }
    }
}