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
      "DashboardId": 719,
      "UniqueId": "quas",
      "Name": "Gottlieb, Bartoletti and McCullough",
      "Description": "Versatile motivating focus group",
      "AssociateId": 546,
      "Columns": 746,
      "Theme": null,
      "VisibleForAll": 723,
      "VisibleForAssociates": [
        593,
        100
      ],
      "VisibleForGroups": [
        668,
        790
      ],
      "PinForAll": 762,
      "PinForAssociates": [
        160,
        297
      ],
      "PinForGroups": [
        726,
        220
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 466
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 149,
      "UniqueId": "cupiditate",
      "Name": "Stroman LLC",
      "Description": "Reactive local policy",
      "AssociateId": 36,
      "Columns": 887,
      "Theme": null,
      "VisibleForAll": 811,
      "VisibleForAssociates": [
        400,
        598
      ],
      "VisibleForGroups": [
        863,
        748
      ],
      "PinForAll": 982,
      "PinForAssociates": [
        468,
        518
      ],
      "PinForGroups": [
        712,
        239
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 50,
      "UniqueId": "iste",
      "Name": "Pfannerstill-Bogan",
      "Description": "Versatile object-oriented info-mediaries",
      "AssociateId": 71,
      "Columns": 570,
      "Theme": null,
      "VisibleForAll": 576,
      "VisibleForAssociates": [
        117,
        496
      ],
      "VisibleForGroups": [
        976,
        167
      ],
      "PinForAll": 608,
      "PinForAssociates": [
        730,
        973
      ],
      "PinForGroups": [
        374,
        467
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 162
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 900
    }
  }
}
```