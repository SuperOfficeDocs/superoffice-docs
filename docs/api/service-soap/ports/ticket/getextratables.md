---
title: getExtraTables
uid: cs_soap_ports_ticket_getextratables
description: Services SOAP interface ticket reference getExtraTables
author: {github-id}
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getExtraTables

## Description

Retrieves information about all extra tables and all columns in each extra table.

The flags returned for extra fields are a bit-combination of the following:

| Flag | Bit | Description |
|---|---|---|
| FlagSearchable | (1<<0) | The field is searchable |
| FlagPublic | (1<<1) | The field is public (external) |
| FlagInNewTicket | (1<<2) | The field is viewed in new-ticket form |
| FlagSetWhenClicked | (1<<3) | The field is set (datetime) when clicked  |
| FlagCannotChange | (1<<4) | The field cannot change after being set |
| FlagDropDown | (1<<5) | The field is a dropdown (extra string fields) |
| FlagReadable | (1<<6) | The field is directly readable from the database |
| FlagDontEscape | (1<<7) | Do not HTML-escape the value when displaying field |
| FlagDeleted | (1<<8) | The field is deleted |
| FlagIsId | (1<<9)   The field is the ID |
| FlagIsForeignId | (1<<10) | The field is a foreign ID |
| FlagReadOnly | (1<<11) | The field is not writeable |
| FlagUseDefault | (1<<12) | Use default value for field if no value is supplied |
| FlagListRelations | (1<<13) | List relations |
| FlagViewInList | (1<<14) | View this field when listing rows |
| FlagHideHeaderIfEmpty | (1<<15)   Hide the header for this list if there are no entries |

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| extraTables | An array of all extra tables: id, name, flags, fields (array) |
| id | |
| name | |
| datatype | [See field types][3] |
| flags | see description |

## Example

```csharp
string sessionKey;
ticket.ticketService ticketService | new ticket.ticketService();

if(ticketService.login("test","test", out sessionKey) | = "0")
{
  ticket.ExtraTablesStruct[] extraTables;
  string res | ticketService.getExtraTables(sessionKey, out extraTables);
  if(res | = "0")
  {
    foreach(i ticket.ExtraTableStruct in extraTables)
    {
      //...doStuffWithExtraTables...
    }
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md
[3]: ../../field-types.md
