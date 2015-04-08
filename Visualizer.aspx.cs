using System;  
using System.IO;
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

    // Called when the page is loaded. Do all setup here.
    protected void Page_Load(object sender, EventArgs e)
    {
        _graph = PreviousPage.CurrentObject;
        _graphJSON = _graph.GraphToJSON();
    }
    // Create our ExcelObject from the file specified.
    // This will use the file from the page file picker.
    public void Setup()
    {

    }
}