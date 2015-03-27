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
            //We have the rows for each segment
            foreach (var row in worksheet.Rows)
            {
                //Get the cells in every row
                foreach (var cell in row.Cells)
                {
                    //Make sure the cell has content
                    if(cell != null)
                    {
                        //Do stuff - format a JSON object for all of the data in a spreadsheet? 
                        Label newLabel = new Label();
                        newLabel.Text = cell.Text + " ";
                        form1.Controls.Add(newLabel);
                    }
                }
                //Visual break between rows
                form1.Controls.Add(new LiteralControl("<br>"));
            }
        }    
    }
}