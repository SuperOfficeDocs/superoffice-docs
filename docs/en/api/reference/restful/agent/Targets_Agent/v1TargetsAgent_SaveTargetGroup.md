---
title: POST Agents/Targets/SaveTargetGroup
uid: v1TargetsAgent_SaveTargetGroup
generated: true
content_type: reference
---

# POST Agents/Targets/SaveTargetGroup

```http
POST /api/v1/Agents/Targets/SaveTargetGroup
```

Updates the existing TargetGroup or creates a new TargetGroup if the id parameter is 0.








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

## Request Body: targetGroup 

The TargetGroup that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetGroupId | Integer | Primary key |
| Year | Integer | The year this set of targets are associated with (2020, 2021...) |
| EntityType | String | Entity type for this set of targets (Sale, Project, Selection, Appointment...) |
| PeriodType | String | Period type for editing this set of targets (Year, Quarter...) |
| TargetAssignments | Array | Collection of target values |
| TargetDimension | TargetDimension | Info about the target dimensions |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TargetGroup

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetGroupId | int32 | Primary key |
| Year | int32 | The year this set of targets are associated with (2020, 2021...) |
| EntityType | string | Entity type for this set of targets (Sale, Project, Selection, Appointment...) |
| PeriodType | string | Period type for editing this set of targets (Year, Quarter...) |
| TargetAssignments | array | Collection of target values |
| TargetDimension | TargetDimension | Info about the target dimensions |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Targets/SaveTargetGroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TargetGroupId": 50,
  "Year": 56,
  "EntityType": "None",
  "PeriodType": "HalfYear",
  "TargetAssignments": [
    {
      "TargetAssignmentInfoId": 395,
      "Values": [
        576,
        406
      ],
      "Locked": true,
      "TargetAssociate": null,
      "TargetContact": null,
      "TargetUserGroup": null,
      "Currency": null,
      "DimensionListItem": 773,
      "DimensionListItemDisplayName": "Medhurst LLC"
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
  "TargetGroupId": 486,
  "Year": 475,
  "EntityType": "None",
  "PeriodType": "HalfYear",
  "TargetAssignments": [
    {
      "TargetAssignmentInfoId": 885,
      "Values": [
        678,
        242
      ],
      "Locked": false,
      "TargetAssociate": null,
      "TargetContact": null,
      "TargetUserGroup": null,
      "Currency": null,
      "DimensionListItem": 907,
      "DimensionListItemDisplayName": "Ernser, Weber and Douglas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "TargetDimension": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 521
    }
  }
}
```