---
title: POST Agents/Ticket/GetTicketRelations
uid: v1TicketAgent_GetTicketRelations
generated: true
content_type: reference
---

# POST Agents/Ticket/GetTicketRelations

```http
POST /api/v1/Agents/Ticket/GetTicketRelations
```

Get all relations for a ticket.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketRelations?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

TicketId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketRelationId | int32 | Primary key |
| RelationType | string | How this item relates to the source ticket: parent, child, or related. |
| RelationComment | string | Free-text comment stored on the relation row. |
| HasParent | bool | Whether the related ticket has a parent relation. |
| ChildCount | int32 | Number of child relations the related ticket has. |
| RelatedCount | int32 | Number of plain related relations the related ticket has. |
| RelationCreatedAt | date-time | Registered when  in UTC. |
| TicketId | int32 | The primary key (auto-incremented) |
| Title | string | The title of the ticket. |
| IconHint | string | Icon representing the ticket's state. |
| CustId | int32 | The reference to the customer. NULL or -1 if ticket is not connected to customer. |
| PersonFullname | string | Get the full name for the primary person (customer) |
| ContactId | int32 | The company of the person in the cust_id field, if that person belongs to a company |
| ContactName | string | The name of the connected contact |
| BaseStatus | string | The status of the ticket. I.e. active/closed/postponed/deleted |
| TicketStatus | int32 | User defined ticket status |
| TicketStatusDisplayValue | string | Get the display name of the ticket status. |
| TicketCreatedAt | date-time | When the ticket was created. |

## Sample request

[!include[sample request](../../samples/agent/request/v1TicketAgent_GetTicketRelations.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1TicketAgent_GetTicketRelations.md)]