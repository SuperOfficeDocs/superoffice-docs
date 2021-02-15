using SuperOffice.Data.Dialect;
using SuperOffice.CRM.Globalization;

var mo = MassOperations.GetCurrent();

string tableName = "uddocsmall";

// key column 

string[] keys = { "uddocsmall_id" };

// table columns

string[] columns = 
{ 
    "SuperOffice:3", //uddocsmall.long05,  documentnumber
    "SuperOffice:4", //uddocsmall.long06   documentdate	        
    "SuperOffice:6", //uddocsmall.long07   documentcheckbox	    
    "SuperOffice:7", //uddocsmall.long08   documentdropdownlistbox	
    "SuperOffice:1", //uddocsmall.string05 documentshorttext	    
    "SuperOffice:5", //uddocsmall.string06 documentunlimiteddate	
    "SuperOffice:8", //uddocsmall.double05 documentdecimal	        
    keys[0]          //uddocsmall.uddocsmall_id PK
};

var startTime = CultureDataFormatter.EncodeDate(DateTime.Today);
var endTime = CultureDataFormatter.EncodeDate(DateTime.Today.AddDays(1));

// table row data 

string[][] data =
{
    new [] 
    { 
        "[I:10]", 
        startTime, 
        "0", 
        "5", 
        "Text 10", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(10)}", 
        "1" 
    },
    new [] 
    { 
        "[I:20]", 
        startTime, 
        "0", 
        "5", 
        "Text 20", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(20)}", 
        "2" 
    },
    new [] 
    { 
        "[I:30]", 
        startTime, 
        "0", 
        "5", 
        "Text 30", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(30)}", 
        "3" 
    },
    new [] 
    { 
        "[I:40]", 
        startTime, 
        "0", 
        "5", 
        "Text 40", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(40)}", 
        "4" 
    }
};

MassResult massResult = mo.Upsert(tableName, columns, keys, data, UpsertNomatchAction.NoChange);
