using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excel;

/// <summary>
/// Summary description for ExcelObject
/// </summary>
public class ExcelObject
{
    public string[] columns {get; set;}
    public Row[] rows { get; set; }

	public ExcelObject(int _numColumns, int _numRows){
		columns = new string [_numColumns];
        rows = new Row[_numRows];
	}
}