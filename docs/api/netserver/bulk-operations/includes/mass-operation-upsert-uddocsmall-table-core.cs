using SuperOffice.Data.Dialect;
using SuperOffice.CRM.Globalization;

var mo = MassOperations.GetCurrent();

string tableName = "uddocsmall";

// key column 

string[] keys = { "document_id" };

// table columns

string[] columns = 
{ 
    keys[0],         //document_id PK
    "SuperOffice:3", //uddocsmall.long05,  documentnumber
    "SuperOffice:4", //uddocsmall.long06   documentdate	        
    "SuperOffice:6", //uddocsmall.long07   documentcheckbox	    
    "SuperOffice:7", //uddocsmall.long08   documentdropdownlistbox	
    "SuperOffice:1", //uddocsmall.string05 documentshorttext	    
    "SuperOffice:5", //uddocsmall.string06 documentunlimiteddate	
    "SuperOffice:8"  //uddocsmall.double05 documentdecimal	        
};

var startTime = CultureDataFormatter.EncodeDate(DateTime.Today);
var endTime = CultureDataFormatter.EncodeDate(DateTime.Today.AddDays(1));

// table row data for document ids 1, 2, 3 and 4

string[][] data =
{
    new [] 
    { 
        CultureDataFormatter.EncodeInt(1),
        "[I:10]", 
        startTime, 
        "0", 
        "5", 
        "Text 10", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(10)}"
    },
    new [] 
    { 
        CultureDataFormatter.EncodeInt(2),
        "[I:20]", 
        startTime, 
        "0", 
        "5", 
        "Text 20", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(20)}"
    },
    new [] 
    { 
        CultureDataFormatter.EncodeInt(3),
        "[I:30]", 
        startTime, 
        "0", 
        "5", 
        "Text 30", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(30)}"
    },
    new [] 
    { 
        CultureDataFormatter.EncodeInt(4),
        "[I:40]", 
        startTime, 
        "0", 
        "5", 
        "Text 40", 
        endTime, 
        $"{CultureDataFormatter.EncodeDouble(40)}"
    }
};

MassResult massResult = mo.Upsert(tableName, columns, keys, data, UpsertNomatchAction.NoChange);
