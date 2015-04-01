﻿using System;
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
        Setup(); 
    }
    // Create our ExcelObject from the file specified.
    // This will use the file from the page file picker.
    public void Setup()
    {
        String path = @"C:\Users\livieric\Documents\GitHub Projects\visualdata\Resources\sampledata.xlsx";
        _graph = ConvertFile.CreateFromFile(path);
        _graphJSON = _graph.GraphToJSON();
    }
    // A temporary method to display ExcelObject data on page.
    // This will be replaced by a later Three.JS visualization. 
    public void PrintToPage()
    {
        foreach (Row r in _graph.rows)
        {
            Label _temp = new Label();
            _temp.Text = "Data Point: " + r.Cells[0].Text + " has value: " + r.Cells[1].Text;
            form1.Controls.Add(_temp);
            form1.Controls.Add(new LiteralControl("<div></div>"));
        }
    }
}