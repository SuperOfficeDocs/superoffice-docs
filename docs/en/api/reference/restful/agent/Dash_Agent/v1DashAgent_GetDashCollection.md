---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
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
      "DashboardId": 131,
      "UniqueId": "quia",
      "Name": "West LLC",
      "Description": "Synergistic radical strategy",
      "AssociateId": 838,
      "Columns": 24,
      "Theme": null,
      "VisibleForAll": 456,
      "VisibleForAssociates": [
        73,
        558
      ],
      "VisibleForGroups": [
        576,
        292
      ],
      "PinForAll": 153,
      "PinForAssociates": [
        883,
        156
      ],
      "PinForGroups": [
        811,
        306
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 13
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 550,
      "UniqueId": "dignissimos",
      "Name": "Trantow, VonRueden and Hoeger",
      "Description": "Grass-roots multi-tasking encoding",
      "AssociateId": 29,
      "Columns": 307,
      "Theme": null,
      "VisibleForAll": 677,
      "VisibleForAssociates": [
        309,
        321
      ],
      "VisibleForGroups": [
        182,
        607
      ],
      "PinForAll": 101,
      "PinForAssociates": [
        277,
        769
      ],
      "PinForGroups": [
        369,
        467
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 196,
      "UniqueId": "labore",
      "Name": "Trantow Group",
      "Description": "Persistent demand-driven service-desk",
      "AssociateId": 94,
      "Columns": 570,
      "Theme": null,
      "VisibleForAll": 287,
      "VisibleForAssociates": [
        348,
        129
      ],
      "VisibleForGroups": [
        625,
        635
      ],
      "PinForAll": 537,
      "PinForAssociates": [
        785,
        66
      ],
      "PinForGroups": [
        431,
        371
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 643
    }
  }
}
```