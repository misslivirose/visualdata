using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    public ExcelObject _excelDB;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void UploadButton_Click(object sender, EventArgs e)
    {
        // Upload the file that is submitted
        if(FileUpload1.HasFile)
        {
            string fullPath = Path.Combine(Server.MapPath(" "), FileUpload1.FileName);
            FileUpload1.SaveAs(fullPath);
            _excelDB = ConvertFile.CreateFromFile(fullPath);
            File.Delete(fullPath);
            Server.Transfer("\\Visualizer.aspx");
        }
        else
        {
            string message = "You need to upload an Excel File to visualize";
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("alert('");
            builder.Append(message);
            builder.Append("');");
            ClientScript.RegisterOnSubmitStatement(this.GetType(), "alert", builder.ToString());
        }

    }

    public ExcelObject CurrentObject
    {
        get
        {
            return _excelDB;
        }
    }
}