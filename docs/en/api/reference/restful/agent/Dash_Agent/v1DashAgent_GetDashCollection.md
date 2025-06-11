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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 333,
      "UniqueId": "dolore",
      "Name": "Dibbert-Adams",
      "Description": "Up-sized tertiary approach",
      "AssociateId": 417,
      "Columns": 369,
      "Theme": null,
      "VisibleForAll": 606,
      "VisibleForAssociates": [
        246,
        967
      ],
      "VisibleForGroups": [
        778,
        391
      ],
      "PinForAll": 582,
      "PinForAssociates": [
        904,
        920
      ],
      "PinForGroups": [
        964,
        481
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 211
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 457,
      "UniqueId": "sint",
      "Name": "Kovacek LLC",
      "Description": "Compatible analyzing hub",
      "AssociateId": 897,
      "Columns": 597,
      "Theme": null,
      "VisibleForAll": 153,
      "VisibleForAssociates": [
        197,
        845
      ],
      "VisibleForGroups": [
        912,
        192
      ],
      "PinForAll": 107,
      "PinForAssociates": [
        864,
        857
      ],
      "PinForGroups": [
        765,
        26
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 732
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 61,
      "UniqueId": "autem",
      "Name": "Windler, Osinski and Schiller",
      "Description": "Multi-layered 3rd generation migration",
      "AssociateId": 648,
      "Columns": 893,
      "Theme": null,
      "VisibleForAll": 628,
      "VisibleForAssociates": [
        210,
        452
      ],
      "VisibleForGroups": [
        110,
        951
      ],
      "PinForAll": 632,
      "PinForAssociates": [
        557,
        498
      ],
      "PinForGroups": [
        736,
        41
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 567
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 902
    }
  }
}
```