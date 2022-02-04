---
title: getCategories
uid: cs_soap_ports_ticket_getcategories
description: Services SOAP interface ticket reference getCategoriesgetCategories
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getCategories

## Description

Retrieves all categories that are available in the system. If you wish to build a tree structure you can do this manually by checking the parent IDs of each category. The array returned is ordered so that each `parentId` has a corresponding id earlier in the array. This makes it easy to create a tree structure representation of the category hierarchy.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |.

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| categoryIds | An array of all categories. Elements of this structure are as follows:<br>id (The category ID)<br>name (External category name)<br>parentId (The category ID of the parent. -1 if this is a top level category.)<br>isInternal (Boolean indicating if it is internal or external) |

## Example

```csharp
string sessionKey;
ticket.ticketService ticketService = new ticket.ticketService();

if(ticketService.login("test","test", out sessionKey) == "0")
{
  ticket.CategoryStruct[] categoryIds;
  string res = ticketService.getCategories(sessionKey, out categoryIds);
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
