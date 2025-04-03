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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 344,
      "UniqueId": "delectus",
      "Name": "Borer Group",
      "Description": "Diverse maximized circuit",
      "AssociateId": 806,
      "Columns": 974,
      "Theme": null,
      "VisibleForAll": 106,
      "VisibleForAssociates": [
        254,
        547
      ],
      "VisibleForGroups": [
        902,
        958
      ],
      "PinForAll": 362,
      "PinForAssociates": [
        39,
        477
      ],
      "PinForGroups": [
        511,
        591
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 783,
      "UniqueId": "numquam",
      "Name": "Lubowitz-Kuhic",
      "Description": "Down-sized regional Graphical User Interface",
      "AssociateId": 608,
      "Columns": 297,
      "Theme": null,
      "VisibleForAll": 813,
      "VisibleForAssociates": [
        631,
        985
      ],
      "VisibleForGroups": [
        283,
        686
      ],
      "PinForAll": 706,
      "PinForAssociates": [
        864,
        407
      ],
      "PinForGroups": [
        619,
        34
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 768
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 318,
      "UniqueId": "dicta",
      "Name": "Waelchi, Reinger and Littel",
      "Description": "Business-focused maximized archive",
      "AssociateId": 546,
      "Columns": 301,
      "Theme": null,
      "VisibleForAll": 898,
      "VisibleForAssociates": [
        955,
        317
      ],
      "VisibleForGroups": [
        329,
        909
      ],
      "PinForAll": 358,
      "PinForAssociates": [
        913,
        906
      ],
      "PinForGroups": [
        325,
        477
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 820
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 229
    }
  }
}
```