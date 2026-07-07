---
title: PUT CustomObject/{definitionName}
uid: v1CustomObject_SaveCustomObject
generated: true
content_type: reference
---

# PUT CustomObject/{definitionName}

```http
PUT /api/v1/CustomObject/{definitionName}
```

Saves a Custom Object row.


If the row has a primary key set it will be updated, otherwise a new row is inserted.





| Path Part | Type | Description |
|-----------|------|-------------|
| definitionName | string | Database table name of the Custom Object Definition, e.g. 'y_equipment'. **Required** |



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

## Request Body: row 

The Custom Object row to save. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefinitionName | String | Database table name of the Custom Object Definition this row belongs to, e.g. 'y_equipment'. |
| Id | Integer | Primary key of the row. |
| Values | Object | Column values for this row. Keys are database column names; values are formatted with CultureDataFormatter (e.g. '[I:42]' for integers). |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CustomObject

| Property Name | Type |  Description |
|----------------|------|--------------|
| DefinitionName | string | Database table name of the Custom Object Definition this row belongs to, e.g. 'y_equipment'. |
| Id | int32 | Primary key of the row. |
| Values | object | Column values for this row. Keys are database column names; values are formatted with CultureDataFormatter (e.g. '[I:42]' for integers). |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/rest/request/v1CustomObject_SaveCustomObject.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1CustomObject_SaveCustomObject.md)]