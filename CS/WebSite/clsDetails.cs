using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

public class clsDetails : List<clsDetail>
{
    public clsDetails()
    {
        this.Add(new clsDetail("A", "M", "Mr", "Address1"));
        this.Add(new clsDetail("B", "M", "Dr", "Address2"));
        this.Add(new clsDetail("C", "M", "Mr", "Address3"));
        this.Add(new clsDetail("D", "M", "Mr", "Address4"));
        this.Add(new clsDetail("E", "F", "Mrs","Address5"));
        this.Add(new clsDetail("F", "M", "Dr","Address6"));
        this.Add(new clsDetail("G", "M", "Mr","Address7"));
        this.Add(new clsDetail("H", "F", "Ms","Address8"));
        this.Add(new clsDetail("I", "F", "Dr","Address9"));
        this.Add(new clsDetail("J", "M", "Mr","Address10"));
        this.Add(new clsDetail("K", "M", "Mr", "Address11"));
    }

    public clsDetail GetDetails(string code)
    {
        clsDetail det = new clsDetail("undefined","undefined","undefined","undefined");
        for (int i = 0; i < this.Count; i++)
        {
            string currentCode = this[i].Code;
            if (currentCode == code)
            {
                det =  this[i];
                break;
            }
           
        }
        return det;
    }
}