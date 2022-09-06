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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Pinned | array | Dashboards pinned to the associate |
| Favourites | array | The assocates favourite dashboards |
| Other | array | Other dashboards |
| TableRight |  |  |
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
      "DashboardId": 839,
      "UniqueId": "et",
      "Name": "Rowe-Cummings",
      "Description": "Function-based zero tolerance methodology",
      "AssociateId": 991,
      "Columns": 295,
      "Theme": null,
      "VisibleForAll": 739,
      "VisibleForAssociates": [
        105,
        335
      ],
      "VisibleForGroups": [
        227,
        523
      ],
      "PinForAll": 777,
      "PinForAssociates": [
        544,
        295
      ],
      "PinForGroups": [
        965,
        172
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 397
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 34,
      "UniqueId": "incidunt",
      "Name": "Rogahn-Kerluke",
      "Description": "Re-contextualized needs-based toolset",
      "AssociateId": 913,
      "Columns": 496,
      "Theme": null,
      "VisibleForAll": 247,
      "VisibleForAssociates": [
        896,
        18
      ],
      "VisibleForGroups": [
        473,
        48
      ],
      "PinForAll": 179,
      "PinForAssociates": [
        757,
        905
      ],
      "PinForGroups": [
        929,
        707
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 544,
      "UniqueId": "mollitia",
      "Name": "Stehr-Collins",
      "Description": "Cross-group attitude-oriented paradigm",
      "AssociateId": 182,
      "Columns": 704,
      "Theme": null,
      "VisibleForAll": 126,
      "VisibleForAssociates": [
        323,
        707
      ],
      "VisibleForGroups": [
        606,
        309
      ],
      "PinForAll": 286,
      "PinForAssociates": [
        566,
        990
      ],
      "PinForGroups": [
        610,
        649
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 52
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 621
    }
  }
}
```
