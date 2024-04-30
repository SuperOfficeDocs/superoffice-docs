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
      "DashboardId": 160,
      "UniqueId": "non",
      "Name": "Ondricka, Stanton and Swaniawski",
      "Description": "Streamlined intermediate installation",
      "AssociateId": 442,
      "Columns": 537,
      "Theme": null,
      "VisibleForAll": 794,
      "VisibleForAssociates": [
        967,
        276
      ],
      "VisibleForGroups": [
        373,
        228
      ],
      "PinForAll": 498,
      "PinForAssociates": [
        532,
        525
      ],
      "PinForGroups": [
        806,
        568
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 602
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 926,
      "UniqueId": "consequatur",
      "Name": "Morissette, Bauch and Davis",
      "Description": "Cross-group contextually-based parallelism",
      "AssociateId": 437,
      "Columns": 853,
      "Theme": null,
      "VisibleForAll": 257,
      "VisibleForAssociates": [
        871,
        862
      ],
      "VisibleForGroups": [
        35,
        626
      ],
      "PinForAll": 181,
      "PinForAssociates": [
        640,
        778
      ],
      "PinForGroups": [
        627,
        409
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 525
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 203,
      "UniqueId": "et",
      "Name": "Schuster-Russel",
      "Description": "Self-enabling radical architecture",
      "AssociateId": 951,
      "Columns": 623,
      "Theme": null,
      "VisibleForAll": 748,
      "VisibleForAssociates": [
        105,
        967
      ],
      "VisibleForGroups": [
        891,
        980
      ],
      "PinForAll": 105,
      "PinForAssociates": [
        181,
        727
      ],
      "PinForGroups": [
        635,
        265
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 822
    }
  }
}
```