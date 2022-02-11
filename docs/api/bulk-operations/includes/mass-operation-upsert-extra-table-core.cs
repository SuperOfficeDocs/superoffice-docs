using SuperOffice.Data.Dialect;

var mo = MassOperations.GetCurrent();

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

MassResult massResult = mo.Upsert(tableName, columns, keys, data, UpsertNomatchAction.NoChange);

