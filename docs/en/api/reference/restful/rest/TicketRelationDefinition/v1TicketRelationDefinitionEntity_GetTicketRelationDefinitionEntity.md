---
title: GET TicketRelationDefinition/{id}
uid: v1TicketRelationDefinitionEntity_GetTicketRelationDefinitionEntity
generated: true
content_type: reference
---

# GET TicketRelationDefinition/{id}

```http
GET /api/v1/TicketRelationDefinition/{id}
```

Gets a TicketRelationDefinitionEntity object.


Calls the List agent service GetTicketRelationDefinitionEntity.
NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketRelationDefinitionEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/TicketRelationDefinition/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

TicketRelationDefinitionEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketRelationDefinitionEntity found. |
| 404 | Not Found. |

### Response body: TicketRelationDefinitionEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketRelationDefId | int32 | Primary key |
| Name | string | The name of this Ticket relation |
| Description | string | Tooltip or other description |
| Rank | int32 | Rank order |
| RelationType | string | Type of the relation (Related, Parent, Child) |
| IsBuiltIn | bool | Is this row part of SuperOffice priming data |
| IsParentMandatory | bool | Parent relation is mandatory when a new request is created |
| IsCloseParentWithChild | bool | Close parent when all children are closed |
| IsPreventClosingParent | bool | Prevent closing parent until all children are closed |
| IsCloseWithParent | bool | Offer to close all related when parent is closed |
| SourceTicketTypes | array | Source ticket type(s) for this relation |
| DestinationTicketTypes | array | Destination ticket type(s) for this relation |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

[!include[sample request](../../samples/rest/request/v1TicketRelationDefinitionEntity_GetTicketRelationDefinitionEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TicketRelationDefinitionEntity_GetTicketRelationDefinitionEntity.md)]