---
uid: crmscript_ref_Company_getValue_String_colName
title: Company.getValue(String colName)
intellisense: Company.getValue
sortOrder: 165
keywords: getValue(String)
so.topic: reference
---

Gets a String with the value of a given column.



## Parameters


 - String colName

## Possible colNames


 - id: Integer, The primary key (auto-incremented)
 - primContact: Integer, The id of the customer who is the primary contact for this company customer.id
 - name: String, The name of the company
 - note: String, A freetext field for various notes about this company
 - phone: String, The company's phone number
 - fax: String, The company's faxnumber
 - adr: String, The company's address
 - priority: Integer, The reference to the default priority for this company. NULL or -1 if not set. ticket\_priority.id
 - deleted: Bool, A boolean telling if the company is deleted
 - language: Integer, The reference to the default customer language for this company. NULL or -1 if not set. cust\_lang.id
 - ourContact: Integer, The customer's primary contact ejuser.id
 - extTable: Integer, The reference to the external table if this is a cached entry. NULL or -1 if not. ext\_table.id
 - extKey: String, The primary key for the cached entry in the external datasource.
 - extLastCached: DateTime, When the cached entry was last updated.
 - domain: String, A display version of the company\_domain table for this company.
 - x_* The extrafield with the given database field name.


Returns a string value of the given column.



## Example


    Company c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());
    
    print(c.getValue("name"));


