---
title: POST Agents/Ticket/CreateTicketRelations
uid: v1TicketAgent_CreateTicketRelations
generated: true
content_type: reference
---

# POST Agents/Ticket/CreateTicketRelations

```http
POST /api/v1/Agents/Ticket/CreateTicketRelations
```

Create multiple ticket relations in a single call.


Returns a result per source ticket indicating success or failure.
NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/CreateTicketRelations?$select=name,department,category/id
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

SourceTicketIds, DestinationTicketId, RelationType, Comment 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketIds | Array |  |
| DestinationTicketId | Integer |  |
| RelationType | String |  |
| Comment | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceTicketId | int32 | The id of the source ticket this result applies to. |
| IsValid | bool | True if the operation succeeded; false if it failed. |
| RelationError | string | The reason the operation failed, if IsValid is false. |
| ErrorMessage | string | Error message describing why the operation failed, if IsValid is false. |

## Sample request

[!include[sample request](../../samples/agent/request/v1TicketAgent_CreateTicketRelations.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1TicketAgent_CreateTicketRelations.md)]