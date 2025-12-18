---
title: PUT TicketRelation/{id}
uid: v1TicketRelationEntity_PutTicketRelationEntity
generated: true
content_type: reference
---

# PUT TicketRelation/{id}

```http
PUT /api/v1/TicketRelation/{id}
```

Updates the existing TicketRelationEntity


NsApiSlow threshold: 5000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketRelationEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/TicketRelation/{id}?$select=name,department,category/id
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

## Request Body: entity 

The TicketRelationEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketRelationId | Integer | Primary key |
| SourceTicketId | Integer | Source ticket in this relation |
| DestinationTicketId | Integer | Destination ticket in this relation |
| RelationType | String | Ticket relation type |
| Comment | String | Comment for relation |

## Response:

TicketRelationEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | TicketRelationEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: TicketRelationEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketRelationId | int32 | Primary key |
| SourceTicketId | int32 | Source ticket in this relation |
| DestinationTicketId | int32 | Destination ticket in this relation |
| RelationType | string | Ticket relation type |
| Comment | string | Comment for relation |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/rest/request/v1TicketRelationEntity_PutTicketRelationEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TicketRelationEntity_PutTicketRelationEntity.md)]