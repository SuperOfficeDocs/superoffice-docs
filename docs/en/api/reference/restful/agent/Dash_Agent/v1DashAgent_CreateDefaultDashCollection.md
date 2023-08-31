---
title: POST Agents/Dash/CreateDefaultDashCollection
uid: v1DashAgent_CreateDefaultDashCollection
generated: true
---

# POST Agents/Dash/CreateDefaultDashCollection

```http
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
```

Set default values into a new DashCollection.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Dash/CreateDefaultDashCollection
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
      "DashboardId": 526,
      "UniqueId": "iure",
      "Name": "Gutmann-Heaney",
      "Description": "Reduced attitude-oriented success",
      "AssociateId": 131,
      "Columns": 143,
      "Theme": null,
      "VisibleForAll": 300,
      "VisibleForAssociates": [
        875,
        69
      ],
      "VisibleForGroups": [
        996,
        829
      ],
      "PinForAll": 344,
      "PinForAssociates": [
        988,
        120
      ],
      "PinForGroups": [
        430,
        186
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 513,
      "UniqueId": "ab",
      "Name": "Emmerich LLC",
      "Description": "Diverse client-driven definition",
      "AssociateId": 118,
      "Columns": 586,
      "Theme": null,
      "VisibleForAll": 272,
      "VisibleForAssociates": [
        828,
        320
      ],
      "VisibleForGroups": [
        992,
        562
      ],
      "PinForAll": 338,
      "PinForAssociates": [
        643,
        253
      ],
      "PinForGroups": [
        690,
        825
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 596,
      "UniqueId": "numquam",
      "Name": "Goldner Inc and Sons",
      "Description": "Profit-focused disintermediate data-warehouse",
      "AssociateId": 201,
      "Columns": 714,
      "Theme": null,
      "VisibleForAll": 180,
      "VisibleForAssociates": [
        822,
        626
      ],
      "VisibleForGroups": [
        340,
        361
      ],
      "PinForAll": 10,
      "PinForAssociates": [
        844,
        471
      ],
      "PinForGroups": [
        808,
        621
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 979
    }
  }
}
```