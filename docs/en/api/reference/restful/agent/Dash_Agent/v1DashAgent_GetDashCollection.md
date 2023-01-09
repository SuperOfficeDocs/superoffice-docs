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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
      "DashboardId": 290,
      "UniqueId": "adipisci",
      "Name": "Waters, Gerlach and Russel",
      "Description": "Integrated user-facing initiative",
      "AssociateId": 557,
      "Columns": 185,
      "Theme": null,
      "VisibleForAll": 199,
      "VisibleForAssociates": [
        72,
        296
      ],
      "VisibleForGroups": [
        415,
        520
      ],
      "PinForAll": 92,
      "PinForAssociates": [
        925,
        699
      ],
      "PinForGroups": [
        162,
        678
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 599,
      "UniqueId": "quos",
      "Name": "Lowe, Daniel and Fay",
      "Description": "Digitized interactive firmware",
      "AssociateId": 965,
      "Columns": 496,
      "Theme": null,
      "VisibleForAll": 220,
      "VisibleForAssociates": [
        495,
        126
      ],
      "VisibleForGroups": [
        362,
        264
      ],
      "PinForAll": 828,
      "PinForAssociates": [
        367,
        403
      ],
      "PinForGroups": [
        879,
        753
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 862
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 691,
      "UniqueId": "voluptates",
      "Name": "Pollich-Schroeder",
      "Description": "Assimilated systemic Graphical User Interface",
      "AssociateId": 781,
      "Columns": 476,
      "Theme": null,
      "VisibleForAll": 725,
      "VisibleForAssociates": [
        323,
        985
      ],
      "VisibleForGroups": [
        473,
        978
      ],
      "PinForAll": 634,
      "PinForAssociates": [
        35,
        982
      ],
      "PinForGroups": [
        637,
        452
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 20
    }
  }
}
```