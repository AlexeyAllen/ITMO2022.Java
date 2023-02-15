using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ITMO2022.ASP.Net.ControlTask
{
    public partial class Sammary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected string Worse5Students()
        //{
        //    StringBuilder html = new StringBuilder();
        //    var worseData = StudentInfoRepository.GetStudentInfoRepository()
        //                     .GetAllInfo();
        //        //Where(r => !r.WillAttend.Value); 
        //    foreach (var worse in worseData)
        //    {
        //        html.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>", 
        //            worse.FirstName, worse.LastName, worse.Email, worse.PhoneNumber));
        //    }
        //    return html.ToString();
        //}
    }
}