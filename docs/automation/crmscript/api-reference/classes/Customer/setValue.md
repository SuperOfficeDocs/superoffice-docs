---
uid: crmscript_ref_Customer_setValue_String_field_String_value
title: Customer.setValue(String field, String value)
intellisense: Customer.setValue
sortOrder: 192
keywords: setValue(String,String)
so.topic: reference
---

# Customer.setValue(String field, String value)
   
**Sets the given field with the given value. The following fields are available:**   

 - name or display\_name: The name of the customer.
 - firstname
 - lastname
 - title (From 7.x)
 - mrmrs (From 7.x)
 - year\_of_birth (From 7.x)
 - month\_of_birth (From 7.x)
 - day\_of_birth (From 7.x)
 - birth\_date (From 7.x)
 - person\_number (From 7.x)
 - post1 (From 7.x)
 - post2 (From 7.x)
 - post3 (From 7.x)
 - salutation (From 7.x)
 - middleName (From 7.x)
 - phone
 - direct/formattedNumber: Same as phone(From 7.x)
 - phone/formattedNumber:  Same as phone (From 7.x)
 - cellphone
 - mobile/formattedNumber: Same as cellphone (From 7.x)
 - note
 - infoText: Same as note. (From 7.x)
 - username: This is the usedname used for the external web.
 - password: This is the password used for the external web.
 - email or display\_email: Adds an email to the customer (does not erase existing ones).
 - company: The id of the related company
 - display\_company: The value showing the name of the related company.
 - deleted
 - dbi\_agent_id
 - dbi\_key
 - dbi\_last_modified
 - dbi\_last_syncronized: These values are for database integration
 - priority or priority\_id: The id or name of the customers priority.
 - language: The name, languagecode or id of the customers language.
 - ourContact: The username, loginname or id of the related contact (user).
 - x_* The extrafield with the given database field name.
 - [extra field] The extrafield with the given name (e.g. "Country").

## Parameters

 - field: The field to set.
 - value: The value to set.

## Example

    Customer c;
    
    c.load(3);
    Bool b = c.checkTableRights("select");
    print(b.toString());
    
    c.setValue("name", "Test");
    print(c.getValue("name"));

