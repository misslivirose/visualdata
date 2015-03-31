using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Diagnostics;
using Excel;

public partial class Visualizer : System.Web.UI.Page
{
    public ExcelObject _graph;
    public string _graphJSON;
    protected void Page_Load(object sender, EventArgs e){
        String path = @"C:\Users\livieric\Documents\GitHub Projects\visualdata\Resources\sampledata.xlsx";
        foreach (var worksheet in Workbook.Worksheets(path))
        {
            int numberOfColumns = worksheet.NumberOfColumns;
            int numberOfRows = worksheet.Rows.Length-1;

             _graph = new ExcelObject(numberOfColumns, numberOfRows);
            /**
             * First, we take the first row and separate out our column headers
             * Assume that the workbook data is formatted properly
             * First row is name, each row after that is a specific object
             **/
            var _firstRow = worksheet.Rows.First<Row>();
            for (int i = 0; i < worksheet.NumberOfColumns; i++)
            {
                _graph.columns[i] = _firstRow.Cells[i].Text;
            }
                     
            /**
             *  Next, we take the rest of the rows and feed them into specific
             *  Excel objects, each one representing an element in the graph.
             **/
            for (int j = 0; j < numberOfRows; j++)
            {
                _graph.rows[j] = worksheet.Rows[j+1];
                String _test = _graph.RowToJSON(j);
                Debug.WriteLine(_test);
            }
            Debug.WriteLine("Finished adding in data");

            /**
             *  Objects in rows n > 1 are a pair {data point 1, data point 2} where 
             *  data point 1 = x-axis and data point 2 = y-axis. We want our count representation
             *  that we visualize using Three.js to use the y-axis values, and will use the data point 1
             *  value as a string to label the data from data point 2.
             **/
            
            foreach (Row r in _graph.rows)
            {
                Label _temp = new Label();
                _temp.Text = "Data Point: " + r.Cells[0].Text + " has value: " + r.Cells[1].Text;
                form1.Controls.Add(_temp);
                form1.Controls.Add(new LiteralControl("<div></div>"));
            }
            _graphJSON = _graph.GraphToJSON();
        }
    }
}