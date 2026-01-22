---
title: POST Agents/List/SaveTicketRelationDefinitionEntity
uid: v1ListAgent_SaveTicketRelationDefinitionEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveTicketRelationDefinitionEntity

```http
POST /api/v1/Agents/List/SaveTicketRelationDefinitionEntity
```

Updates the existing TicketRelationDefinitionEntity or creates a new TicketRelationDefinitionEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: ticketRelationDefinitionEntity 

The TicketRelationDefinitionEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketRelationDefId | Integer | Primary key |
| Name | String | The name of this Ticket relation |
| Description | String | Tooltip or other description |
| Rank | Integer | Rank order |
| RelationType | String | Type of the relation (Related, Parent, Child) |
| IsBuiltIn | Boolean | Is this row part of SuperOffice priming data |
| IsParentMandatory | Boolean | Parent relation is mandatory when a new request is created |
| IsCloseParentWithChild | Boolean | Close parent when all children are closed |
| IsPreventClosingParent | Boolean | Prevent closing parent until all children are closed |
| IsCloseWithParent | Boolean | Offer to close all related when parent is closed |
| SourceTicketTypes | Array | Source ticket type(s) for this relation |
| DestinationTicketTypes | Array | Destination ticket type(s) for this relation |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketRelationDefinitionEntity

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

## Sample request

[!include[sample request](../../samples/agent/request/v1ListAgent_SaveTicketRelationDefinitionEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ListAgent_SaveTicketRelationDefinitionEntity.md)]