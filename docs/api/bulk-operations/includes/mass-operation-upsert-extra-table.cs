using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
var dta = new DatabaseTableAgent(options);

string tableName = "y_rental_gear";

// table columns

string[] columns = { "x_code", "x_quantity", "x_description" };

// key column 

string[] keys = { "x_code" };

// table row data 

string[][] data =
{
    new [] { "XO", "7", "Extra-Ordinary Bike" },
    new [] { "UB", "10", "Uni-cycle" }
};

MassOperationResult results = await dta.UpsertAsync(tableName, columns, keys, false, data);

