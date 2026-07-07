---
title: GET CustomObject/{definitionName}/{id}
uid: v1CustomObject_GetCustomObject
generated: true
content_type: reference
---

# GET CustomObject/{definitionName}/{id}

```http
GET /api/v1/CustomObject/{definitionName}/{id}
```

Returns a single Custom Object row by definition name and primary key.






| Path Part | Type | Description |
|-----------|------|-------------|
| definitionName | string | Database table name of the Custom Object Definition, e.g. 'y_equipment'. **Required** |
| id | int32 | Primary key of the row to fetch. **Required** |



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
| 404 | Not Found. |

### Response body: CustomObject

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefinitionName | string | Database table name of the Custom Object Definition this row belongs to, e.g. 'y_equipment'. |
| Id | int32 | Primary key of the row. |
| Values | object | Column values for this row. Keys are database column names; values are formatted with CultureDataFormatter (e.g. '[I:42]' for integers). |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/rest/request/v1CustomObject_GetCustomObject.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CustomObject_GetCustomObject.md)]