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
    public List<Row> rows { get; set; }

	public ExcelObject(int _numColumns, int _numRows){
		columns = new string [_numColumns];
        rows = new List<Row>();
	}
    /**
     * Insert a row from the Excel spreadsheet into its ExcelObject type.
     * Each row will be a separate entity to visualize.
     **/
    public int InsertRow(Row _rowToAdd){
        if (_rowToAdd != null) {
            rows.Add(_rowToAdd);
            return 0;
        }
        return -1;
    }
}