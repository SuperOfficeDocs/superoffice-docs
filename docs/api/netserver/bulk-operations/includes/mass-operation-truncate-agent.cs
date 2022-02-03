using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;


// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
DatabaseTableAgent dta = new DatabaseTableAgent(options);

// table name

string tableName = "y_rental";

MassOperationResult massResult = await dta.TruncateAsync(tableName);

if(massResult.Success)
{
    Console.WriteLine($"Removed {massResult.Deletes} records from {tableName}.");
}