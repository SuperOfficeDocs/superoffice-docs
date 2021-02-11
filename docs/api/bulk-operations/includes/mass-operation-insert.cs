using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

WebApiOptions options = GetSystemUserWebApiOptions(tenant);
DatabaseTableAgent dta = new DatabaseTableAgent(options);

// table name

string tableName = "y_rental";

// table columns (non-nullable columns)

var columns = new[] { "x_start", "x_end", "x_amount", "x_contact", "x_equipment" };

// table row data

var data = new string[][]
{
	new[] {yesterday, today, CultureDataFormatter.EncodeInt(2), "123", "0" },
	new[] {yesterday, today, CultureDataFormatter.EncodeInt(200), "456", "1" },
};

MassOperationResult results = await dta.InsertAsync(tableName, columns, data);