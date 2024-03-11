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
      "DashboardId": 856,
      "UniqueId": "magnam",
      "Name": "Treutel, Stiedemann and Keeling",
      "Description": "Customizable coherent definition",
      "AssociateId": 408,
      "Columns": 700,
      "Theme": null,
      "VisibleForAll": 288,
      "VisibleForAssociates": [
        367,
        206
      ],
      "VisibleForGroups": [
        785,
        536
      ],
      "PinForAll": 754,
      "PinForAssociates": [
        146,
        73
      ],
      "PinForGroups": [
        815,
        834
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 845
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 26,
      "UniqueId": "sunt",
      "Name": "Kohler-Swaniawski",
      "Description": "De-engineered object-oriented collaboration",
      "AssociateId": 335,
      "Columns": 204,
      "Theme": null,
      "VisibleForAll": 765,
      "VisibleForAssociates": [
        649,
        271
      ],
      "VisibleForGroups": [
        901,
        280
      ],
      "PinForAll": 267,
      "PinForAssociates": [
        69,
        861
      ],
      "PinForGroups": [
        718,
        786
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 765
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 267,
      "UniqueId": "perspiciatis",
      "Name": "Hickle, Schmeler and Marvin",
      "Description": "Mandatory content-based strategy",
      "AssociateId": 927,
      "Columns": 120,
      "Theme": null,
      "VisibleForAll": 298,
      "VisibleForAssociates": [
        97,
        684
      ],
      "VisibleForGroups": [
        404,
        79
      ],
      "PinForAll": 168,
      "PinForAssociates": [
        297,
        458
      ],
      "PinForGroups": [
        356,
        327
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 459
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 508
    }
  }
}
```