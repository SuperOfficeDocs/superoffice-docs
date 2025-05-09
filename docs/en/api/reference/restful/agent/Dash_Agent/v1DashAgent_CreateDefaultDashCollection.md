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
      "DashboardId": 299,
      "UniqueId": "aut",
      "Name": "Breitenberg LLC",
      "Description": "Adaptive fresh-thinking customer loyalty",
      "AssociateId": 74,
      "Columns": 858,
      "Theme": null,
      "VisibleForAll": 659,
      "VisibleForAssociates": [
        468,
        92
      ],
      "VisibleForGroups": [
        220,
        936
      ],
      "PinForAll": 710,
      "PinForAssociates": [
        852,
        885
      ],
      "PinForGroups": [
        548,
        193
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 726
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 952,
      "UniqueId": "voluptatem",
      "Name": "Kilback, Waelchi and Stokes",
      "Description": "Extended analyzing hub",
      "AssociateId": 428,
      "Columns": 355,
      "Theme": null,
      "VisibleForAll": 471,
      "VisibleForAssociates": [
        433,
        359
      ],
      "VisibleForGroups": [
        354,
        979
      ],
      "PinForAll": 79,
      "PinForAssociates": [
        619,
        903
      ],
      "PinForGroups": [
        213,
        774
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 220,
      "UniqueId": "cumque",
      "Name": "Casper-Blick",
      "Description": "Assimilated zero defect concept",
      "AssociateId": 865,
      "Columns": 755,
      "Theme": null,
      "VisibleForAll": 765,
      "VisibleForAssociates": [
        987,
        502
      ],
      "VisibleForGroups": [
        22,
        355
      ],
      "PinForAll": 600,
      "PinForAssociates": [
        662,
        901
      ],
      "PinForGroups": [
        901,
        367
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 498
    }
  }
}
```