---
title: POST Agents/CustomObject/GetCustomObjectDefinition
uid: v1CustomObjectAgent_GetCustomObjectDefinition
generated: true
content_type: reference
---

# POST Agents/CustomObject/GetCustomObjectDefinition

```http
POST /api/v1/Agents/CustomObject/GetCustomObjectDefinition
```

Returns the schema (table + field definitions) for a Custom Object Definition by its database table name.


NsApiSlow threshold: 5000 ms.


## Experimental: ## The CustomObject agent is experimental, subject to change, and not intended for partners.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/CustomObject/GetCustomObjectDefinition?$select=name,department,category/id
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

DefinitionName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefinitionName | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CustomObjectDefinition

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | Primary key in the extra-tables table. |
| Name | string | Database table name of the Custom Object, e.g. 'y_equipment'. |
| Title | string | User-visible title of the Custom Object. |
| DisplayField | string | Name of the field used to represent a row in lists and previews. |
| Description | string | Description of the Custom Object. |
| IconId | int32 | Icon binary-object id used in the UI. |
| Flags | int32 | Bitmask of ExtraTableFlag values. |
| Fields | array | Field definitions for this Custom Object. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/agent/request/v1CustomObjectAgent_GetCustomObjectDefinition.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CustomObjectAgent_GetCustomObjectDefinition.md)]