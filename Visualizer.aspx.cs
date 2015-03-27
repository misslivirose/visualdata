using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel;


public partial class Visualizer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String path = @"C:\Users\livieric\Documents\GitHub Projects\visualdata\Resources\sampledata.xlsx";
        foreach (var worksheet in Workbook.Worksheets(path))
        {
            foreach (var row in worksheet.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    if(cell != null)
                    {
                        Label newLabel = new Label();
                        newLabel.Text = cell.Text;
                        form1.Controls.Add(newLabel);
                    }
                }
            }
        }    
    }
}