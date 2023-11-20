---
title: POST Agents/Targets/GetTargetGroupForYear
uid: v1TargetsAgent_GetTargetGroupForYear
generated: true
---

# POST Agents/Targets/GetTargetGroupForYear

```http
POST /api/v1/Agents/Targets/GetTargetGroupForYear
```

Returns the target group for the specified year and entity type.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Targets/GetTargetGroupForYear?$select=name,department,category/id
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

TargetYear, EntityType 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetYear | Integer |  |
| EntityType | String |  |

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
POST /api/v1/Agents/Targets/GetTargetGroupForYear
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TargetYear": 572,
  "EntityType": "None"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TargetGroupId": 744,
  "Year": 787,
  "EntityType": "None",
  "PeriodType": "HalfYear",
  "TargetAssignments": [
    {
      "TargetAssignmentInfoId": 833,
      "Values": [
        352,
        731
      ],
      "Locked": false,
      "TargetAssociate": null,
      "TargetContact": null,
      "TargetUserGroup": null,
      "Currency": null,
      "DimensionListItem": 336,
      "DimensionListItemDisplayName": "Denesik-Stokes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 681
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
      "FieldLength": 245
    }
  }
}
```