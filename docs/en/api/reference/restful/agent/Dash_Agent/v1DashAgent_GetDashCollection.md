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
      "DashboardId": 786,
      "UniqueId": "ad",
      "Name": "Dach-Rutherford",
      "Description": "Advanced client-server array",
      "AssociateId": 931,
      "Columns": 338,
      "Theme": null,
      "VisibleForAll": 910,
      "VisibleForAssociates": [
        949,
        778
      ],
      "VisibleForGroups": [
        278,
        544
      ],
      "PinForAll": 656,
      "PinForAssociates": [
        726,
        799
      ],
      "PinForGroups": [
        18,
        529
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 213,
      "UniqueId": "expedita",
      "Name": "Haag Inc and Sons",
      "Description": "Open-architected optimizing forecast",
      "AssociateId": 612,
      "Columns": 638,
      "Theme": null,
      "VisibleForAll": 171,
      "VisibleForAssociates": [
        459,
        920
      ],
      "VisibleForGroups": [
        13,
        392
      ],
      "PinForAll": 3,
      "PinForAssociates": [
        540,
        750
      ],
      "PinForGroups": [
        617,
        823
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 936
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 670,
      "UniqueId": "porro",
      "Name": "Braun-Upton",
      "Description": "Vision-oriented systemic functionalities",
      "AssociateId": 792,
      "Columns": 273,
      "Theme": null,
      "VisibleForAll": 211,
      "VisibleForAssociates": [
        175,
        796
      ],
      "VisibleForGroups": [
        619,
        843
      ],
      "PinForAll": 403,
      "PinForAssociates": [
        433,
        895
      ],
      "PinForGroups": [
        975,
        186
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 840
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 28
    }
  }
}
```