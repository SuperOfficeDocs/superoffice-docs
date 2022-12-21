---
title: POST Agents/Targets/SaveTargetGroup
uid: v1TargetsAgent_SaveTargetGroup
---

# POST Agents/Targets/SaveTargetGroup

```http
POST /api/v1/Agents/Targets/SaveTargetGroup
```

Updates the existing TargetGroup or creates a new TargetGroup if the id parameter is empty








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

The TargetGroup to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetGroupId | int32 | Primary key |
| Year | int32 | The year this set of targets are associated with (2020, 2021...) |
| EntityType | string | Entity type for this set of targets (Sale, Project, Selection, Appointment...) |
| PeriodType | string | Period type for editing this set of targets (Year, Quarter...) |
| TargetAssignments | array | Collection of target values |
| TargetDimension |  | Info about the target dimensions |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetGroupId | int32 | Primary key |
| Year | int32 | The year this set of targets are associated with (2020, 2021...) |
| EntityType | string | Entity type for this set of targets (Sale, Project, Selection, Appointment...) |
| PeriodType | string | Period type for editing this set of targets (Year, Quarter...) |
| TargetAssignments | array | Collection of target values |
| TargetDimension |  | Info about the target dimensions |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Targets/SaveTargetGroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TargetGroupId": 420,
  "Year": 959,
  "EntityType": "None",
  "PeriodType": "HalfYear",
  "TargetAssignments": [
    {
      "TargetAssignmentInfoId": 169,
      "Values": [
        200,
        461
      ],
      "Locked": false,
      "TargetAssociate": null,
      "TargetContact": null,
      "TargetUserGroup": null,
      "Currency": null,
      "DimensionListItem": 621,
      "DimensionListItemDisplayName": "Schmeler-Hartmann"
    }
  ],
  "TargetDimension": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TargetGroupId": 863,
  "Year": 991,
  "EntityType": "None",
  "PeriodType": "HalfYear",
  "TargetAssignments": [
    {
      "TargetAssignmentInfoId": 799,
      "Values": [
        282,
        62
      ],
      "Locked": true,
      "TargetAssociate": null,
      "TargetContact": null,
      "TargetUserGroup": null,
      "Currency": null,
      "DimensionListItem": 936,
      "DimensionListItemDisplayName": "O'Hara LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 663
        }
      }
    }
  ],
  "TargetDimension": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 103
    }
  }
}
```