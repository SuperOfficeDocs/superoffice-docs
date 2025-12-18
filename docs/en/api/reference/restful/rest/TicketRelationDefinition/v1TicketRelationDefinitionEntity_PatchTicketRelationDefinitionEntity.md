---
title: PATCH TicketRelationDefinition/{id}
uid: v1TicketRelationDefinitionEntity_PatchTicketRelationDefinitionEntity
generated: true
content_type: reference
---

# PATCH TicketRelationDefinition/{id}

```http
PATCH /api/v1/TicketRelationDefinition/{id}
```

Update a TicketRelationDefinitionEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.


See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.
NsApiSlow threshold: 5000 ms. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IListAgent} service SaveTicketRelationDefinitionEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketRelationDefinitionEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/TicketRelationDefinition/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | String | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | String | The property names to modify.  "/users/0/email", "/users/-", |
| value | Object | New/Replaced value - string or object. |

## Response:

TicketRelationDefinitionEntity  updated.

| Response | Description |
|----------------|-------------|
| 200 | TicketRelationDefinitionEntity  updated. |
| 404 | TicketRelationDefinitionEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because TicketRelationDefinitionEntity has changed since the requested If-Unmodified-Since timestamp. |

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

[!include[sample request](../../samples/rest/request/v1TicketRelationDefinitionEntity_PatchTicketRelationDefinitionEntity.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1TicketRelationDefinitionEntity_PatchTicketRelationDefinitionEntity.md)]