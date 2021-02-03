var options = GetSystemUserWebApiOptions(tenant);

var dta = new DatabaseTableAgent(options);

string tableName = "y_foobar";

// table columns

string[] columns = { "id", "x_col_a", "x_col_b" };

// key column 

string[] keys = { "id" };

// table row data 

string[][] data =
{
    new [] { "0",  "x", "123" },
    new [] { "42", "y", "234" },
    new [] { null, "0", "345" },
    new [] { "0",  "æ", "456" }
};

MassOperationResult results = await dta.UpsertAsync(tableName, columns, keys, false, data);

