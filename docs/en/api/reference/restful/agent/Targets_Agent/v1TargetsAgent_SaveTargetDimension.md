---
title: POST Agents/Targets/SaveTargetDimension
uid: v1TargetsAgent_SaveTargetDimension
generated: true
---

# POST Agents/Targets/SaveTargetDimension

```http
POST /api/v1/Agents/Targets/SaveTargetDimension
```

Updates the existing TargetDimension or creates a new TargetDimension if the id parameter is empty








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

The TargetDimension to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetDimensionId | Integer | Primary key |
| AssignmentLevel | String | What level this dimension can be assigned to (Company, Group, Associate) |
| EntityType | String | Entity type for this set of targets (Sale, Project, Selection, Appointment...) |
| MeasurementUnit | String | What to measure (Amount, Count, Profit... |
| DimensionListField | String | List that defines the dimensions for this target matrix (ex: Sale type, source, partner, business, udef or extrafield lists...) |
| DimensionListName | String | List name (can be used by list provider system to get list items) |
| DimensionListId | Integer | List id (can be used by list provider system to get list items) |
| DimensionListLabel | String | list label (list column name) |
| SelectedDimensions | Array | id's of the selected/wanted dimensions (what sale types or udef list lines that should be target dimensions) |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TargetDimension

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetDimensionId | int32 | Primary key |
| AssignmentLevel | string | What level this dimension can be assigned to (Company, Group, Associate) |
| EntityType | string | Entity type for this set of targets (Sale, Project, Selection, Appointment...) |
| MeasurementUnit | string | What to measure (Amount, Count, Profit... |
| DimensionListField | string | List that defines the dimensions for this target matrix (ex: Sale type, source, partner, business, udef or extrafield lists...) |
| DimensionListName | string | List name (can be used by list provider system to get list items) |
| DimensionListId | int32 | List id (can be used by list provider system to get list items) |
| DimensionListLabel | string | list label (list column name) |
| SelectedDimensions | array | id's of the selected/wanted dimensions (what sale types or udef list lines that should be target dimensions) |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Targets/SaveTargetDimension
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TargetDimensionId": 494,
  "AssignmentLevel": "Associate",
  "EntityType": "None",
  "MeasurementUnit": "Amount",
  "DimensionListField": "odit",
  "DimensionListName": "Simonis Group",
  "DimensionListId": 824,
  "DimensionListLabel": "autem",
  "SelectedDimensions": [
    132,
    217
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TargetDimensionId": 580,
  "AssignmentLevel": "Associate",
  "EntityType": "None",
  "MeasurementUnit": "Amount",
  "DimensionListField": "eum",
  "DimensionListName": "Blick-Simonis",
  "DimensionListId": 831,
  "DimensionListLabel": "asperiores",
  "SelectedDimensions": [
    92,
    154
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 356
    }
  }
}
```