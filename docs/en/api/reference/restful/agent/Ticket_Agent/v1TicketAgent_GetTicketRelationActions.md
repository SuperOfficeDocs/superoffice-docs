---
title: POST Agents/Ticket/GetTicketRelationActions
uid: v1TicketAgent_GetTicketRelationActions
generated: true
content_type: reference
---

# POST Agents/Ticket/GetTicketRelationActions

```http
POST /api/v1/Agents/Ticket/GetTicketRelationActions
```

Get the relation-driven actions that apply to a ticket, such as whether to offer closing the parent or whether open children are blocking the ticket from being closed.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketRelationActions?$select=name,department,category/id
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

TicketId, ParentTicketId, TicketTypeId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketId | Integer |  |
| ParentTicketId | Integer |  |
| TicketTypeId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketRelationAction

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketIdToClose | int32 | ID of the parent ticket to offer closing when all its children are closed. 0 if not applicable. |
| IsParentRequired | bool | True if a parent relation is mandatory for this ticket type. |
| CanCloseCurrentTicket | bool | True if the ticket may be closed. False if unclosed children are blocking it. |
| Children | array | Ids of unclosed child tickets. If CanCloseCurrentTicket is false, these are the tickets blocking the close. |

## Sample request

[!include[sample request](../../samples/agent/request/v1TicketAgent_GetTicketRelationActions.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1TicketAgent_GetTicketRelationActions.md)]