---
uid: crmscript_ref_Company_setValue_String_column_String_value
title: Company.setValue(String column, String value)
intellisense: Company.setValue
sortOrder: 168
keywords: setValue(String,String)
so.topic: reference
---


Sets a value in a column of a company.




## Parameters


 - String column name
 - String value that should be stored

## Possible column names


 - id: Integer, The primary key (auto-incremented)
 - primContact: Integer, The id of the customer who is the primary contact for this company customer.id
 - name: String, The name of the company
 - note: String, A freetext field for various notes about this company
 - infoText: the same as note (From 7.x)
 - phone: String, The company's phone number
 - phone/formattedNumber: String (From 7.x)
 - fax/formattedNumber: String (From 7.x)
 - fax: String, The company's faxnumber
 - adr: String, The company's address (From 7.x setting address with adr is no longer supported. Attempting to do so, will result in a GeneralException. Use NetServer instead)
 - priority: Integer, The reference to the default priority for this company. NULL or -1 if not set. ticket\_priority.id
 - deleted: Bool, A boolean telling if the company is deleted
 - language: Integer, The reference to the default customer language for this company. NULL or -1 if not set. cust\_lang.id
 - ourContact: Integer, The customer's primary contact ejuser.id
 - ourSalesContact: Integer, The sales contact for this company. (From 7.x)
 - supportAssociateId: String, Set the support associate id. Supports both integer and the username. (From 7.x)
 - primContact: Integer, The customer's primary contact customer.id
 - extTable: Integer, The reference to the external table if this is a cached entry. NULL or -1 if not. ext\_table.id
 - extKey: String, The primary key for the cached entry in the external datasource.
 - extLastCached: DateTime, When the cached entry was last updated.
 - domain: String, A display version of the company\_domain table for this company.




## Example


    Company c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());
    
    c.setValue("name", "Test");
    print(c.getValue("name"));


