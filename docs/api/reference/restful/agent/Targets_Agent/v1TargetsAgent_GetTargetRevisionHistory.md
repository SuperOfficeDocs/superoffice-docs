---
title: POST Agents/Targets/GetTargetRevisionHistory
uid: v1TargetsAgent_GetTargetRevisionHistory
---

# POST Agents/Targets/GetTargetRevisionHistory

```http
POST /api/v1/Agents/Targets/GetTargetRevisionHistory
```

Returns the revision history for a given TargetAssignmentInfo in chronological order.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Targets/GetTargetRevisionHistory?$select=name,department,category/id
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

TargetAssignmentInfoId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetAssignmentInfoId | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TargetGroupId | int32 | The group id - but it may not still exist |
| Year | int32 | The year this set of targets are associated with (2020, 2021...) |
| Revisions | array | Collection of revisions (with changes) |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Targets/GetTargetRevisionHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TargetAssignmentInfoId": 428
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TargetGroupId": 373,
  "Year": 983,
  "Revisions": [
    {
      "LogEvent": "Create",
      "Who": null,
      "When": "2007-01-27T11:10:28.1887307+01:00",
      "Changes": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 580
        }
      }
    },
    {
      "LogEvent": "Create",
      "Who": null,
      "When": "2007-01-27T11:10:28.1887307+01:00",
      "Changes": [
        {},
        {}
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 580
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 846
    }
  }
}
```