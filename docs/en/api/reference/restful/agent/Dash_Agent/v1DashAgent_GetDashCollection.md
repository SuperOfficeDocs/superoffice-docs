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
      "DashboardId": 182,
      "UniqueId": "sed",
      "Name": "Kuhn-Yundt",
      "Description": "Right-sized dedicated open system",
      "AssociateId": 61,
      "Columns": 281,
      "Theme": null,
      "VisibleForAll": 184,
      "VisibleForAssociates": [
        212,
        683
      ],
      "VisibleForGroups": [
        434,
        781
      ],
      "PinForAll": 520,
      "PinForAssociates": [
        692,
        944
      ],
      "PinForGroups": [
        266,
        121
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 660,
      "UniqueId": "totam",
      "Name": "Medhurst-Murray",
      "Description": "Organic optimizing strategy",
      "AssociateId": 608,
      "Columns": 477,
      "Theme": null,
      "VisibleForAll": 19,
      "VisibleForAssociates": [
        124,
        763
      ],
      "VisibleForGroups": [
        667,
        674
      ],
      "PinForAll": 403,
      "PinForAssociates": [
        501,
        152
      ],
      "PinForGroups": [
        88,
        797
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 228,
      "UniqueId": "perferendis",
      "Name": "Abbott-Rohan",
      "Description": "Managed mission-critical utilisation",
      "AssociateId": 832,
      "Columns": 727,
      "Theme": null,
      "VisibleForAll": 471,
      "VisibleForAssociates": [
        300,
        107
      ],
      "VisibleForGroups": [
        558,
        306
      ],
      "PinForAll": 8,
      "PinForAssociates": [
        174,
        977
      ],
      "PinForGroups": [
        160,
        44
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 17
    }
  }
}
```