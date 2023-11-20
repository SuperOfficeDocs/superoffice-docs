---
title: POST Agents/List/SaveRelationDefinitionEntity
uid: v1ListAgent_SaveRelationDefinitionEntity
generated: true
---

# POST Agents/List/SaveRelationDefinitionEntity

```http
POST /api/v1/Agents/List/SaveRelationDefinitionEntity
```

Updates the existing RelationDefinitionEntity or creates a new RelationDefinitionEntity if the id parameter is empty








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

The RelationDefinitionEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReldefId | Integer | Primary key |
| Name | String | Active text |
| Tooltip | String | Tooltip or other description |
| PassiveText | String | Text used in passive direction |
| Deleted | Boolean | True if deleted |
| Rank | Integer | Rank order |
| Source | String | The source of the relation |
| Destination | String | The destination of the relation |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: RelationDefinitionEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReldefId | int32 | Primary key |
| Name | string | Active text |
| Tooltip | string | Tooltip or other description |
| PassiveText | string | Text used in passive direction |
| Deleted | bool | True if deleted |
| Rank | int32 | Rank order |
| Source | string | The source of the relation |
| Destination | string | The destination of the relation |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveRelationDefinitionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 215,
  "Name": "Strosin-Dicki",
  "Tooltip": "delectus",
  "PassiveText": "voluptatem",
  "Deleted": false,
  "Rank": 325,
  "Source": "Both",
  "Destination": "Both"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 347,
  "Name": "Johns, Schmeler and Tillman",
  "Tooltip": "esse",
  "PassiveText": "ullam",
  "Deleted": true,
  "Rank": 1002,
  "Source": "Both",
  "Destination": "Both",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 394
    }
  }
}
```