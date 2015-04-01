using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Web;
using Excel;

/// <summary>
/// Summary description for ConvertFile
/// </summary>
public abstract class ConvertFile
{
    public static ExcelObject CreateFromFile(String path)
    {
        String _filePath = path;
        worksheet _createFrom = Workbook.Worksheets(_filePath).ElementAt(0);
        ExcelObject _EOReturn = new ExcelObject(_createFrom.NumberOfColumns, _createFrom.Rows.Length-1);

        // Separate out first row as column headers
        var _firstRow = _createFrom.Rows.First<Row>();
        for (int i = 0; i < _createFrom.NumberOfColumns; i++)
        {
            _EOReturn.columns[i] = _firstRow.Cells[i].Text;
        }

        // Add in the rest of the rows
        for (int j = 0; j < _EOReturn.rows.Length; j++)
        {
            _EOReturn.rows[j] = _createFrom.Rows[j + 1];
        }
        Debug.WriteLine("Finished adding in data");
        return _EOReturn;
    }
}