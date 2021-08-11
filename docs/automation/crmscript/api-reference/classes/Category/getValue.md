---
uid: crmscript_ref_Category_getValue_String_field
title: Category.getValue(String field)
intellisense: Category.getValue
sortOrder: 153
keywords: getValue(String)
so.topic: reference
---

# Category.getValue(String field)

Retrieves the value of the given field in the category.

## Available fields

 - id: The id of the category.
 - parent: The id of the parent category.
 - name: The name of the category.
 - fullname: The full name of the category (e.g. "Support/Product A/bugs").
 - externalName: The external name of the category.
 - categoryMaster: The id of the category master.
 - children: A comma separated list of children ids.
 - notificationEmail: The value of the email Notification field

## Parameters

 - field: The field to get.

## Example

    Category c;
    
    c.load(2);
    print(c.getValue("name"));
