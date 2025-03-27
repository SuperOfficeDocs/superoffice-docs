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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Pinned": [
    {
      "DashboardId": 710,
      "UniqueId": "perspiciatis",
      "Name": "Armstrong Inc and Sons",
      "Description": "Adaptive 4th generation task-force",
      "AssociateId": 662,
      "Columns": 794,
      "Theme": null,
      "VisibleForAll": 852,
      "VisibleForAssociates": [
        472,
        487
      ],
      "VisibleForGroups": [
        44,
        535
      ],
      "PinForAll": 71,
      "PinForAssociates": [
        831,
        629
      ],
      "PinForGroups": [
        448,
        148
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 140,
      "UniqueId": "tempora",
      "Name": "Padberg, Walsh and Okuneva",
      "Description": "Implemented 24 hour open architecture",
      "AssociateId": 700,
      "Columns": 475,
      "Theme": null,
      "VisibleForAll": 814,
      "VisibleForAssociates": [
        137,
        313
      ],
      "VisibleForGroups": [
        303,
        638
      ],
      "PinForAll": 391,
      "PinForAssociates": [
        855,
        230
      ],
      "PinForGroups": [
        40,
        823
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 875
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 524,
      "UniqueId": "maiores",
      "Name": "Terry Group",
      "Description": "Realigned coherent Graphical User Interface",
      "AssociateId": 554,
      "Columns": 653,
      "Theme": null,
      "VisibleForAll": 654,
      "VisibleForAssociates": [
        99,
        957
      ],
      "VisibleForGroups": [
        103,
        916
      ],
      "PinForAll": 140,
      "PinForAssociates": [
        228,
        540
      ],
      "PinForGroups": [
        709,
        307
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 563
    }
  }
}
```