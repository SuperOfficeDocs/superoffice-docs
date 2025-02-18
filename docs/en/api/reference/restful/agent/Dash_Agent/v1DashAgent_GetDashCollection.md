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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 782,
      "UniqueId": "sit",
      "Name": "Turner Group",
      "Description": "Multi-lateral 6th generation success",
      "AssociateId": 943,
      "Columns": 253,
      "Theme": null,
      "VisibleForAll": 36,
      "VisibleForAssociates": [
        679,
        698
      ],
      "VisibleForGroups": [
        158,
        265
      ],
      "PinForAll": 662,
      "PinForAssociates": [
        850,
        489
      ],
      "PinForGroups": [
        347,
        320
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 180,
      "UniqueId": "veniam",
      "Name": "Lubowitz, Herzog and Gutkowski",
      "Description": "Phased assymetric artificial intelligence",
      "AssociateId": 209,
      "Columns": 37,
      "Theme": null,
      "VisibleForAll": 357,
      "VisibleForAssociates": [
        340,
        696
      ],
      "VisibleForGroups": [
        548,
        134
      ],
      "PinForAll": 714,
      "PinForAssociates": [
        320,
        699
      ],
      "PinForGroups": [
        826,
        625
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 792
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 59,
      "UniqueId": "suscipit",
      "Name": "Barton Group",
      "Description": "Open-architected composite attitude",
      "AssociateId": 954,
      "Columns": 969,
      "Theme": null,
      "VisibleForAll": 481,
      "VisibleForAssociates": [
        740,
        740
      ],
      "VisibleForGroups": [
        127,
        505
      ],
      "PinForAll": 297,
      "PinForAssociates": [
        787,
        150
      ],
      "PinForGroups": [
        437,
        42
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 582
    }
  }
}
```