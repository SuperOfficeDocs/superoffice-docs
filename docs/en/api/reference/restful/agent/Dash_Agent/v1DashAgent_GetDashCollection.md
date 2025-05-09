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
      "DashboardId": 958,
      "UniqueId": "rerum",
      "Name": "Heidenreich-DuBuque",
      "Description": "Multi-layered 4th generation analyzer",
      "AssociateId": 858,
      "Columns": 807,
      "Theme": null,
      "VisibleForAll": 258,
      "VisibleForAssociates": [
        371,
        495
      ],
      "VisibleForGroups": [
        967,
        772
      ],
      "PinForAll": 150,
      "PinForAssociates": [
        469,
        900
      ],
      "PinForGroups": [
        866,
        612
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 44
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 996,
      "UniqueId": "possimus",
      "Name": "Cronin, Walsh and Lubowitz",
      "Description": "Multi-lateral needs-based parallelism",
      "AssociateId": 738,
      "Columns": 74,
      "Theme": null,
      "VisibleForAll": 645,
      "VisibleForAssociates": [
        552,
        317
      ],
      "VisibleForGroups": [
        244,
        690
      ],
      "PinForAll": 168,
      "PinForAssociates": [
        203,
        567
      ],
      "PinForGroups": [
        123,
        629
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 668
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 487,
      "UniqueId": "sit",
      "Name": "Barrows, Hoeger and Schowalter",
      "Description": "Multi-layered bifurcated paradigm",
      "AssociateId": 957,
      "Columns": 843,
      "Theme": null,
      "VisibleForAll": 507,
      "VisibleForAssociates": [
        458,
        446
      ],
      "VisibleForGroups": [
        964,
        88
      ],
      "PinForAll": 160,
      "PinForAssociates": [
        267,
        572
      ],
      "PinForGroups": [
        597,
        690
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 533
    }
  }
}
```