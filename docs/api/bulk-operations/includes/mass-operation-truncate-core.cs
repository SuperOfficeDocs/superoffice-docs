using SuperOffice.Data.Dialect;
using SuperOffice.CRM.Globalization;

// table name

string tableName = "y_rental";

var mo = MassOperations.GetCurrent();

MassOperationResult massResult = mo.Truncate(tableName);

if(massResult.Success)
{
    Console.WriteLine($"Removed {massResult.Deletes} records from {tableName}.");
}