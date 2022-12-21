using SuperOffice.Data.Dialect;
using SuperOffice.CRM.Globalization;

var mo = MassOperations.GetCurrent();

// table name

string tableName = "y_rental";

// table columns (non-nullable columns)

var columns = new[] { "x_start", "x_end", "x_amount", "x_contact", "x_equipment" };

// use CultureDataFormatter to encode date and numerical values. 

var today = CultureDataFormatter.EncodeDateTime(DateTime.Today.DropFractionsOfSecond());
var yesterday = CultureDataFormatter.EncodeDateTime(DateTime.Today.AddDays(-1).DropFractionsOfSecond());

// table row data

var data = new string[][]
{
	new[] {yesterday, today, CultureDataFormatter.EncodeInt(2), "123", "0" },
	new[] {yesterday, today, CultureDataFormatter.EncodeInt(200), "456", "1" },
};

MassResult massResult = mo.Insert(tableName, columns, data);