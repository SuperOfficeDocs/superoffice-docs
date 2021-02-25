---
title: cs_soap_ports_ticket_getextrafields
description: Services SOAP interface ticket reference getExtraFields
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getExtraFields

## Description

Finds the extra fields that are connected to customer, company, or ticket. The structure returned contains information about the extra field, such as data type, name, and ID. The method will return all fields (both internal and external).

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| domain | The domain to list. Can be "customer", "company" or "ticket". Only the extra fields connected to the domain specified will be returned. |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
 extraFields | The available extra fields. Contained in the structure are the following fields: |

| extraFields | Description |
|---|---|
| fieldName | Internal name of the field ("customer.x\_1" )|
| displayField | The external name of the extra field |
| fieldId | The internal ID. Same as the number in `fieldName` |
| fieldType | [Data type of the field][2] |

## Example

```csharp
string sessionKey;
ticket.ticketService ticketService = new ticket.ticketService();

if(ticketService.login("test","test",out sessionKey)=="0")
{
  ticket.ExtraFieldsStruct[] extraFields;
  ticketService.getExtraFields(sessionKey, "customer", out extraFields);
}
```

<!-- Referenced links -->
[1]: ../error-codes.md
[2]: ../field-types.md
