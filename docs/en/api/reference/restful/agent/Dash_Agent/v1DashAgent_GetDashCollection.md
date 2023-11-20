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
      "DashboardId": 82,
      "UniqueId": "commodi",
      "Name": "Schroeder-Prohaska",
      "Description": "Persevering grid-enabled data-warehouse",
      "AssociateId": 116,
      "Columns": 36,
      "Theme": null,
      "VisibleForAll": 730,
      "VisibleForAssociates": [
        493,
        928
      ],
      "VisibleForGroups": [
        134,
        338
      ],
      "PinForAll": 243,
      "PinForAssociates": [
        422,
        316
      ],
      "PinForGroups": [
        614,
        913
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 507,
      "UniqueId": "earum",
      "Name": "Ferry Inc and Sons",
      "Description": "Re-contextualized high-level internet solution",
      "AssociateId": 943,
      "Columns": 183,
      "Theme": null,
      "VisibleForAll": 653,
      "VisibleForAssociates": [
        151,
        991
      ],
      "VisibleForGroups": [
        48,
        217
      ],
      "PinForAll": 312,
      "PinForAssociates": [
        204,
        328
      ],
      "PinForGroups": [
        672,
        994
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 824,
      "UniqueId": "eaque",
      "Name": "Vandervort, Kihn and Hirthe",
      "Description": "Multi-tiered intermediate process improvement",
      "AssociateId": 273,
      "Columns": 798,
      "Theme": null,
      "VisibleForAll": 700,
      "VisibleForAssociates": [
        665,
        305
      ],
      "VisibleForGroups": [
        140,
        53
      ],
      "PinForAll": 753,
      "PinForAssociates": [
        690,
        286
      ],
      "PinForGroups": [
        49,
        529
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 22
    }
  }
}
```