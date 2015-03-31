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
    public string PrintRow(int rowNumber)
    {
        if(rowNumber < rows.Length)
        {
            String _return = "";
            for (int i = 0; i < columns.Length; i++)
            {
                Cell _current = rows[rowNumber].Cells[i];
                _return = _return + " " + _current.Text;
            }
            return _return;
        }
        return "Unable to process row";
    }
    // Given a row number, return row formatted as a JSON object
    public string RowToJSON(int rowNumber)
    {
        if (rowNumber < rows.Length)
        {
            String _JSON = "{" + '\n';
            for(int i = 0; i < columns.Length; i++)
            {
                _JSON += ("\t\"" + columns[i] + "\"" + ":\t");
                _JSON += ("\"" + rows[rowNumber].Cells[i].Text + "\",\n");

                if(i == columns.Length-1)
                {
                    _JSON = _JSON.TrimEnd('\n');
                    _JSON = _JSON.TrimEnd(',');
                }
            }
            _JSON += "}";
            return "\"" + _JSON + "\"";
        }
        return "Unable to convert row";
    }
    // Return the entire graph as a JSON formatted object
    public string GraphToJSON()
    {
        String _JSON = "{" + '\n';
        for (int i = 0; i < rows.Length; i++ )
        {
            String _rowJSON = this.RowToJSON(i);
            _JSON += ("\t" + _rowJSON + "\n");

        }
        _JSON += "}";
        return "\"" + _JSON + "\"";
    }
}