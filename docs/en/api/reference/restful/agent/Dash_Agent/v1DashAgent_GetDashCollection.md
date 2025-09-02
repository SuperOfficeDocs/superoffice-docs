---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
content_type: reference
---

# POST Agents/Dash/GetDashCollection

```http
POST /api/v1/Agents/Dash/GetDashCollection
```

Gets a collection of dashboards for the current associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dash/GetDashCollection?$select=name,department,category/id
```


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

### Response body: DashCollection

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Dash/GetDashCollection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 974,
      "UniqueId": "modi",
      "Name": "Hessel LLC",
      "Description": "Streamlined incremental database",
      "AssociateId": 408,
      "Columns": 959,
      "Theme": null,
      "VisibleForAll": 620,
      "VisibleForAssociates": [
        379,
        151
      ],
      "VisibleForGroups": [
        557,
        416
      ],
      "PinForAll": 381,
      "PinForAssociates": [
        376,
        520
      ],
      "PinForGroups": [
        691,
        735
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 958
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 799,
      "UniqueId": "dolores",
      "Name": "Goodwin Group",
      "Description": "Business-focused attitude-oriented knowledge user",
      "AssociateId": 69,
      "Columns": 834,
      "Theme": null,
      "VisibleForAll": 772,
      "VisibleForAssociates": [
        30,
        28
      ],
      "VisibleForGroups": [
        984,
        731
      ],
      "PinForAll": 558,
      "PinForAssociates": [
        944,
        726
      ],
      "PinForGroups": [
        978,
        542
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 84
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 285,
      "UniqueId": "modi",
      "Name": "Price, McGlynn and Spencer",
      "Description": "User-friendly coherent website",
      "AssociateId": 675,
      "Columns": 81,
      "Theme": null,
      "VisibleForAll": 349,
      "VisibleForAssociates": [
        245,
        458
      ],
      "VisibleForGroups": [
        867,
        75
      ],
      "PinForAll": 723,
      "PinForAssociates": [
        677,
        44
      ],
      "PinForGroups": [
        520,
        997
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 377
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 499
    }
  }
}
```