using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

WebApiOptions options = GetSystemUserWebApiOptions(tenant);
DatabaseTableAgent dta = new DatabaseTableAgent(options);

// table name

string tableName = "y_rental";

MassOperationResult massResult = await dta.TruncateAsync(tableName);

if(massResult.Success)
{
    Console.WriteLine($"Removed {massResult.Deletes} records from {tableName}.");
}