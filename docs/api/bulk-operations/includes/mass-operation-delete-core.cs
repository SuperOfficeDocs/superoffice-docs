using SuperOffice.Data.Dialect;

// set the table name and primary key parameters

string tableName = "y_myExtraTableName";
int[] primaryKeys = {1,2,3,4,5,6,7,8,9};

var mo = MassOperations.GetCurrent();

// perform the delete operation

MassResult massResult = mo.Delete(tableName, primaryKeys);

// check the result status and print out the number of changes.

if(massOperationResult.Success)
{
    Console.WriteLine($"Deleted {massOperationResult.Deletes} records from {tableName}.");
}