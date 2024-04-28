---
uid: custom-objects
title: custom-objects
description: "How to use Custom Objects to search for information"
author: Eivind Fasting
so.date: 04.28.2024
keywords: custom objects, get
so.topic: howto
---

# How to use Custom Objects to search for information

While the other sections shows examples on how to [Read][1], [Insert][2], [Update][3] and [Delete][4], this section will focus on how to find/search for companies with existing relations connected to them.
Even though we use Companies as an example, the logic would be for the other default entities inside of SuperOffice.

## Get available fields for the Contact Archive

One of the first things we need to ask ourself is what relations do companies actually have inside our SuperOffice database. One way of doing this would be to use the GetAvailableColumns Archice to get all the fields that has a relation to the Contact.

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/Archive/GetAvailableColumns?$select=name HTTP/1.1
Authorization: Bearer {{token}}
Accept: application/json; charset=utf-8
Content-Type: application/json

{
  "ProviderName": "Contact",
  "Columns": ""
}
```

In the returned result all ExtraTable relations should be shown in the format of:
contactExtra/{tableName}/{yourfield}

In the case where you also have relations between ExtraTables these will be shown like this:
contactExtra/y_rentals/x_contact_id/x_equipment/x_name

You can then go ahead and select the columns/information you are after, and use the GetArchiveListByColumns2 Archive to select the fields you want.

## Practical Example

In the following example we have an ExtraTable called y_rentals, and another ExtraTable called y_equipment.
y_equipment in this case contains different items we are renting out.
y_rentals is the link-table between the available items and the companies, and functions as a registry of what items are rented out to which customer.

I would like to find what items a spesific customerId has rented.
The query would look something like this:

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/Archive/GetArchiveListByColumns2
Accept: application/json
Content-Type: application/json
Authorization: Bearer {{token}}

{
  "Columns": "contactExtra/y_rentals/x_contact_id,contactExtra/y_rentals/x_contact_id/x_equipment/x_name",
  "ProviderName": "contact",
  "Page": 0,
  "PageSize": 1,
  "Entities": "contact",
  "SortOrder": "",
  "Restrictions": "contactId eq 4"
}

```

>Note
>Take not of the Restictions-parameter here! With this you can also use the contactExtra-fields and search for customers that has rented a spesific item.
>Make sure you adjust PageSize to be more suited for your usercase.


<!-- Referenced links -->
[1]: ./custom-objects-ReadRow.md
[2]: ./custom-objects-InsertRow.md
[3]: ./custom-objects-UpdateRow.md
[4]: ./custom-objects-DeleteRow.md
