---
title: POST Agents/CustomObject/CreateDefaultCustomObjectDefinition
uid: v1CustomObjectAgent_CreateDefaultCustomObjectDefinition
generated: true
content_type: reference
---

# POST Agents/CustomObject/CreateDefaultCustomObjectDefinition

```http
POST /api/v1/Agents/CustomObject/CreateDefaultCustomObjectDefinition
```

Loading default values into a new CustomObjectDefinition.


NsApiSlow threshold: 5000 ms.


## Experimental: ## The CustomObject agent is experimental, subject to change, and not intended for partners.







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

[!include[sample request](../../samples/agent/request/v1CustomObjectAgent_CreateDefaultCustomObjectDefinition.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1CustomObjectAgent_CreateDefaultCustomObjectDefinition.md)]