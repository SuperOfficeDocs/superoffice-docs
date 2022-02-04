using SuperOffice.Data.Dialect;

var mo = MassOperations.GetCurrent();

// table name

string tableName = "y_rental";

MassResult massResult = mo.Truncate(tableName);

if(massResult.Success)
{
    Console.WriteLine($"Removed {massResult.Deletes} records from {tableName}.");
}