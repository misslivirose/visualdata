using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page
{
    public ExcelObject _excelDB;
    protected void Page_Load(object sender, EventArgs e)
    {
        String _path = @"C:\Users\livieric\Documents\GitHub Projects\visualdata\Resources\sampledata.xlsx";
        _excelDB = ConvertFile.CreateFromFile(_path);
    }
    protected void UploadButton_Click(object sender, EventArgs e)
    {
        // Upload the file that is submitted
        Server.Transfer("\\Visualizer.aspx");
    }

    public ExcelObject CurrentObject
    {
        get
        {
            return _excelDB;
        }
    }
}