using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using Excel;


public partial class Visualizer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        String path = @"C:\Users\livieric\Documents\GitHub Projects\visualdata\Resources\sampledata.xlsx";
        foreach (var worksheet in Workbook.Worksheets(path)) {
            int numberOfColumns = worksheet.NumberOfColumns;
            int numberOfRows = worksheet.Rows.Length;

            ExcelObject _graph = new ExcelObject(numberOfColumns, numberOfRows);
            /**
             * First, we take the first row and separate out our column headers
             * Assume that the workbook data is formatted properly
             * First row is name, each row after that is a specific object
             **/
            var _firstRow = worksheet.Rows.First<Row>();
            for (int i = 0; i < worksheet.NumberOfColumns; i ++ ){
                _graph.columns[i] = _firstRow.Cells[i].Text;
            }
            /**
             *  Next, we take the rest of the rows and feed them into specific
             *  Excel objects, each one representing an element in the graph.
             **/
            for (int j = 1; j < numberOfRows; j++ ) {
                _graph.InsertRow(worksheet.Rows[j]);
            }
                //We have the rows for each segment
                foreach (var row in worksheet.Rows){
                    //Get the cells in every row
                    foreach (var cell in row.Cells){
                        //Make sure the cell has content
                        if (cell != null){
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