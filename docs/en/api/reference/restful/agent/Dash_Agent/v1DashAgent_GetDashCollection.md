---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
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
      "DashboardId": 784,
      "UniqueId": "ullam",
      "Name": "Strosin-Bauch",
      "Description": "Enterprise-wide regional capacity",
      "AssociateId": 755,
      "Columns": 776,
      "Theme": null,
      "VisibleForAll": 214,
      "VisibleForAssociates": [
        495,
        146
      ],
      "VisibleForGroups": [
        139,
        884
      ],
      "PinForAll": 754,
      "PinForAssociates": [
        739,
        280
      ],
      "PinForGroups": [
        305,
        798
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 235,
      "UniqueId": "dolores",
      "Name": "Huels LLC",
      "Description": "Extended grid-enabled benchmark",
      "AssociateId": 796,
      "Columns": 478,
      "Theme": null,
      "VisibleForAll": 855,
      "VisibleForAssociates": [
        399,
        163
      ],
      "VisibleForGroups": [
        624,
        547
      ],
      "PinForAll": 504,
      "PinForAssociates": [
        561,
        257
      ],
      "PinForGroups": [
        23,
        246
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 728
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 26,
      "UniqueId": "nihil",
      "Name": "Wyman-Farrell",
      "Description": "Self-enabling background open architecture",
      "AssociateId": 243,
      "Columns": 632,
      "Theme": null,
      "VisibleForAll": 976,
      "VisibleForAssociates": [
        409,
        873
      ],
      "VisibleForGroups": [
        339,
        366
      ],
      "PinForAll": 450,
      "PinForAssociates": [
        552,
        5
      ],
      "PinForGroups": [
        273,
        177
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 270
    }
  }
}
```