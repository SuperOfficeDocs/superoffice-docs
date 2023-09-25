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
      "DashboardId": 199,
      "UniqueId": "doloribus",
      "Name": "Hegmann Group",
      "Description": "Expanded homogeneous secured line",
      "AssociateId": 154,
      "Columns": 687,
      "Theme": null,
      "VisibleForAll": 486,
      "VisibleForAssociates": [
        723,
        106
      ],
      "VisibleForGroups": [
        648,
        398
      ],
      "PinForAll": 786,
      "PinForAssociates": [
        498,
        362
      ],
      "PinForGroups": [
        151,
        556
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 592
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 105,
      "UniqueId": "laborum",
      "Name": "Carroll-Funk",
      "Description": "Pre-emptive needs-based core",
      "AssociateId": 329,
      "Columns": 828,
      "Theme": null,
      "VisibleForAll": 553,
      "VisibleForAssociates": [
        498,
        915
      ],
      "VisibleForGroups": [
        856,
        357
      ],
      "PinForAll": 121,
      "PinForAssociates": [
        368,
        769
      ],
      "PinForGroups": [
        993,
        355
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 938
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 919,
      "UniqueId": "molestias",
      "Name": "Mayer LLC",
      "Description": "Universal next generation info-mediaries",
      "AssociateId": 271,
      "Columns": 905,
      "Theme": null,
      "VisibleForAll": 257,
      "VisibleForAssociates": [
        213,
        495
      ],
      "VisibleForGroups": [
        95,
        642
      ],
      "PinForAll": 583,
      "PinForAssociates": [
        433,
        350
      ],
      "PinForGroups": [
        351,
        349
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 913
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 355
    }
  }
}
```