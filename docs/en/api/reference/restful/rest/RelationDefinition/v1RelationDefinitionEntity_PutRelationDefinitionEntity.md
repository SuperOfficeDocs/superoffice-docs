---
title: PUT RelationDefinition/{id}
uid: v1RelationDefinitionEntity_PutRelationDefinitionEntity
generated: true
---

# PUT RelationDefinition/{id}

```http
PUT /api/v1/RelationDefinition/{id}
```

Updates the existing RelationDefinitionEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The RelationDefinitionEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/RelationDefinition/{id}?$select=name,department,category/id
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

RelationDefinitionEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | RelationDefinitionEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: RelationDefinitionEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/RelationDefinition/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 137,
  "Name": "Rohan, Jast and Greenholt",
  "Tooltip": "ipsum",
  "PassiveText": "mollitia",
  "Deleted": false,
  "Rank": 641,
  "Source": "Both",
  "Destination": "Both"
}
```

## Sample response

```http_
HTTP/1.1 200 RelationDefinitionEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ReldefId": 987,
  "Name": "Jones, Hettinger and Quitzon",
  "Tooltip": "consequatur",
  "PassiveText": "sapiente",
  "Deleted": false,
  "Rank": 885,
  "Source": "Both",
  "Destination": "Both",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 475
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```