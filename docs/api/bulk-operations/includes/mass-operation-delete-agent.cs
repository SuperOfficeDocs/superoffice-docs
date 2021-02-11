// set up the DatabaseTable agent

var options = new WebApiOptions(webApiUrl, authorization);
var dbTableAgent = new SuperOffice.WebApi.Agents.DatabaseTableAgent(options);

// set the table name and primary key parameters

string tableName = "y_myExtraTableName";
int[] primaryKeys = { 1,2,3,4,5,6,7,8,9 };

// perform the delete operation

var massOperationResult = await dbTableAgent.DeleteAsync(tableName, primaryKeys);

// check the result status and print out the number of changes.

if(massOperationResult.Success)
{
    Console.WriteLine($"Deleted {massOperationResult.Deletes} records from {tableName}.");
}