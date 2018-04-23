using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for clsDetail
/// </summary>
public class clsDetail
{
    private string _code = "";
    private string _gender = "";
    private string _titleOfCourt = "";
    private string _address = "";

    public clsDetail(string code, string gender, string titleOfCourt, string address)
    {
        _code = code;
        _gender = gender;
        _titleOfCourt = titleOfCourt;
        _address = address;
    }

    public string Code
    {
        get { return _code; }
    }

    public string Gender
    {
        get { return _gender; }
    }

    public string TitleOfCourt
    {
        get { return _titleOfCourt; }
    }
    public string Address
    {
        get { return _address; }
    }
}
