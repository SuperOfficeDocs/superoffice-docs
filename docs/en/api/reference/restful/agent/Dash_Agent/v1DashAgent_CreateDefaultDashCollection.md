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
      "DashboardId": 277,
      "UniqueId": "perferendis",
      "Name": "Quigley, Muller and Breitenberg",
      "Description": "Assimilated empowering emulation",
      "AssociateId": 436,
      "Columns": 739,
      "Theme": null,
      "VisibleForAll": 470,
      "VisibleForAssociates": [
        42,
        159
      ],
      "VisibleForGroups": [
        277,
        523
      ],
      "PinForAll": 629,
      "PinForAssociates": [
        415,
        497
      ],
      "PinForGroups": [
        477,
        595
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "Favourites": [
    {
      "DashboardId": 676,
      "UniqueId": "sit",
      "Name": "Kilback, Purdy and Goodwin",
      "Description": "Team-oriented actuating pricing structure",
      "AssociateId": 627,
      "Columns": 51,
      "Theme": null,
      "VisibleForAll": 9,
      "VisibleForAssociates": [
        52,
        782
      ],
      "VisibleForGroups": [
        471,
        774
      ],
      "PinForAll": 222,
      "PinForAssociates": [
        948,
        678
      ],
      "PinForGroups": [
        838,
        406
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "Other": [
    {
      "DashboardId": 726,
      "UniqueId": "earum",
      "Name": "Kunde-Schroeder",
      "Description": "Devolved impactful time-frame",
      "AssociateId": 399,
      "Columns": 361,
      "Theme": null,
      "VisibleForAll": 853,
      "VisibleForAssociates": [
        561,
        878
      ],
      "VisibleForGroups": [
        956,
        746
      ],
      "PinForAll": 178,
      "PinForAssociates": [
        674,
        691
      ],
      "PinForGroups": [
        259,
        301
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 278
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 235
    }
  }
}
```