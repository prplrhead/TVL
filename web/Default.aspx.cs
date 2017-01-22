using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using web.modules;

namespace web
{
    public partial class Default : System.Web.UI.Page
    {
        protected string test = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            modules.linq_poc q = new modules.linq_poc();

            q.processStringQuery();
            linq_poc db = new linq_poc();

            foreach(var p in db.getPeople()){
                if(test.Length > 0) test += "<br />";
                test += p.FirstName;
            }
            test += "<br />Hello World!";
        }
    }
}