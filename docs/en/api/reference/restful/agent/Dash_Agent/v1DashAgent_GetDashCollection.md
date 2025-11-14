---
title: POST Agents/Dash/GetDashCollection
uid: v1DashAgent_GetDashCollection
generated: true
content_type: reference
---

# POST Agents/Dash/GetDashCollection

```http
POST /api/v1/Agents/Dash/GetDashCollection
```

Gets a collection of dashboards for the current associate


NsApiSlow threshold: 5000 ms.






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
      "DashboardId": 711,
      "UniqueId": "sit",
      "Name": "Langosh, Bernier and Deckow",
      "Description": "Integrated eco-centric leverage",
      "AssociateId": 691,
      "Columns": 59,
      "Theme": null,
      "VisibleForAll": 954,
      "VisibleForAssociates": [
        296,
        747
      ],
      "VisibleForGroups": [
        358,
        284
      ],
      "PinForAll": 66,
      "PinForAssociates": [
        684,
        596
      ],
      "PinForGroups": [
        340,
        537
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 420
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 324,
      "UniqueId": "ducimus",
      "Name": "Kunze-Bahringer",
      "Description": "Re-contextualized leading edge service-desk",
      "AssociateId": 549,
      "Columns": 955,
      "Theme": null,
      "VisibleForAll": 420,
      "VisibleForAssociates": [
        150,
        634
      ],
      "VisibleForGroups": [
        247,
        633
      ],
      "PinForAll": 217,
      "PinForAssociates": [
        590,
        552
      ],
      "PinForGroups": [
        621,
        495
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 784
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 270,
      "UniqueId": "nihil",
      "Name": "Jacobi-Abernathy",
      "Description": "Grass-roots static success",
      "AssociateId": 308,
      "Columns": 178,
      "Theme": null,
      "VisibleForAll": 521,
      "VisibleForAssociates": [
        150,
        890
      ],
      "VisibleForGroups": [
        639,
        964
      ],
      "PinForAll": 43,
      "PinForAssociates": [
        302,
        875
      ],
      "PinForGroups": [
        719,
        437
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 106
    }
  }
}
```