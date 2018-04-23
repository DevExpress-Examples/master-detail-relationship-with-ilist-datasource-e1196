using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.ASPxTabControl;
using DevExpress.Web.ASPxEditors;

namespace WebApplication5
{
    public partial class _Default : System.Web.UI.Page
    {
        private clsDetails currentDetails = new clsDetails();
        protected void Page_Init(object sender, EventArgs e)
        {
            grdNames.DataSource = new clsNames();
            grdNames.DataBind();
        }

        protected void grdNames_HtmlRowCreated(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs e)
        {
            if (e.RowType == DevExpress.Web.ASPxGridView.GridViewRowType.Detail)
            {
                string code = e.GetValue("Code").ToString();
                clsDetail det = currentDetails.GetDetails(code);

                ASPxPageControl cntrl = ((ASPxGridView)sender).FindDetailRowTemplateControl(e.VisibleIndex, "ASPxPageControl1") as ASPxPageControl;

                ASPxLabel genLab = cntrl.FindControl("ASPxLabel1") as ASPxLabel;
                if (genLab != null)
                {
                    genLab.Text = det.Gender;
                }

                ASPxLabel courtLab = cntrl.FindControl("ASPxLabel2") as ASPxLabel;
                if (courtLab != null)
                {
                    courtLab.Text = det.TitleOfCourt;
                }

                ASPxLabel addrLab = cntrl.FindControl("ASPxLabel3") as ASPxLabel;
                if (addrLab != null)
                {
                    addrLab.Text = det.Address;
                }

            }
        }
    }
}
