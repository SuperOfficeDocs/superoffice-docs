var options = GetSystemUserWebApiOptions(tenant);

var dta = new DatabaseTableAgent(options);

// table name

string tableName = "contact";

// table columns (non-nullable columns)

string[] columns = { "name", "country_id", "business_idx", "category_idx" };

// table row data

string[][] data = 
{
    new [] { "Red A",    "220", "6", "3" },
    new [] { "Orange A", "98",  "1", "2" },
    new [] { "Yellow A", "27",  "4", "1" },
    new [] { "Green A",  "61",  "0", "0" },
    new [] { "Blue A",   "104", "9", "1" },
    new [] { "Indigo A", "109", "8", "4" },
    new [] { "Violet A", "186", "5", "4" }
};

MassOperationResult results = await dta.InsertAsync(tableName, columns, data);