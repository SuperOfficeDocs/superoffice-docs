using SuperOffice.Data.Dialect;

var mo = MassOperations.GetCurrent();

string tableName = "contact";

// table columns (non-nullable columns)

string[] columns = { "name", "country_id", "business_idx", "category_idx" };

// key column 

string[] keys = { "name" };

// table row data 

string[][] data =
{
    new [] { "Red",    "[I:5]", "[I:3]", "[I:1]" },
    new [] { "Orange", "[I:4]", "[I:4]", "[I:1]" },
    new [] { "Yellow", "[I:3]", "[I:5]", "[I:2]" },
    new [] { "Green",  "[I:2]", "[I:3]", "[I:2]" },
    new [] { "Blue",   "[I:1]", "[I:4]", "[I:3]" },
    new [] { "Indigo", "[I:2]", "[I:5]", "[I:3]" },
    new [] { "Violet", "[I:3]", "[I:3]", "[I:4]" },

MassResult massResult = mo.Upsert(tableName, columns, keys, data, UpsertNomatchAction.NoChange);
